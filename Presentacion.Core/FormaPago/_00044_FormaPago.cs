using Aplicacion.Constantes;
using IServicios.Comprobante;
using IServicios.Comprobante.DTOs;
using IServicios.Persona.DTOs;
using Presentacion.Core.Cliente;
using Presentacion.Core.Comprobantes.Clases;
using PresentacionBase.Formularios;
using StructureMap;
using System;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace Presentacion.Core.FormaPago
{
    public partial class _00044_FormaPago : FormBase
    {
        private FacturaView _factura;
        private bool _vieneDeVentas;
        private readonly IBancoServicio _bancoServicio;
        private readonly ITarjetaServicio _tarjetaServicio;
        private readonly IFacturaServicio _facturaServicio;

        public bool RealizoVenta { get; set; } = false;

        public _00044_FormaPago()
        {
            InitializeComponent();

            _bancoServicio = ObjectFactory.GetInstance<IBancoServicio>();
            _tarjetaServicio = ObjectFactory.GetInstance<ITarjetaServicio>();
            _facturaServicio = ObjectFactory.GetInstance<IFacturaServicio>();

            PoblarComboBox(cmbBanco, _bancoServicio.Obtener(string.Empty, false), "Descripcion", "Id");
            PoblarComboBox(cmbTarjeta, _tarjetaServicio.Obtener(string.Empty, false), "Descripcion", "Id");
        }

        public _00044_FormaPago(FacturaView factura)
            : this() // Ctor vacio
        {
            _factura = factura;
            _vieneDeVentas = true;
            CargarDatos(_factura);
        }

        private void CargarDatos(FacturaView factura)
        {
            txtTotalAbonar.Text = factura.TotalStr;
            nudMontoEfectivo.Value = factura.Total;

            nudMontoCheque.Value = 0;
            txtNumeroCheque.Clear();
            dtpFechaVencimientoCheque.Value = DateTime.Now;

            nudMontoCtaCte.Value = 0;
            txtApellido.Text = factura.Cliente.ApyNom;
            txtDni.Text = factura.Cliente.Dni;
            txtTelefono.Text = factura.Cliente.Telefono;
            txtDireccion.Text = factura.Cliente.Direccion;

            nudMontoTarjeta.Value = 0;
            txtNumeroTarjeta.Clear();
            txtCuponPago.Clear();
            nudCantidadCuotas.Value = 1;
        }

        private void nudMontoEfectivo_ValueChanged(object sender, EventArgs e)
        {
            nudTotalEfectivo.Value = nudMontoEfectivo.Value;
        }

        private void nudMontoTarjeta_ValueChanged(object sender, EventArgs e)
        {
            nudTotalTarjeta.Value = nudMontoTarjeta.Value;
        }

        private void nudMontoCheque_ValueChanged(object sender, EventArgs e)
        {
            nudTotalCheque.Value = nudMontoCheque.Value;
        }

        private void nudMontoCtaCte_ValueChanged(object sender, EventArgs e)
        {
            nudTotalCtaCte.Value = nudMontoCtaCte.Value;
        }

        private void nudTotalEfectivo_ValueChanged(object sender, EventArgs e)
        {
            nudTotal.Value = nudTotalCheque.Value
                             + nudTotalEfectivo.Value
                             + nudTotalCtaCte.Value
                             + nudTotalTarjeta.Value;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            RealizoVenta = false;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudTotal.Value > _factura.Total)
                {
                    if (MessageBox.Show("El total que esta por abonar es superior al monto a pagar. ¿Desea continuar?",
                            "Atencion",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question)
                        == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else if (nudTotal.Value < _factura.Total)
                {
                    MessageBox.Show("El total que esta por abonar es inferior al monto a pagar.",
                        "Atencion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                var facturaNueva = new FacturaDto();

                if (_vieneDeVentas)
                {
                    facturaNueva.EmpleadoId = _factura.Vendedor.Id;
                    facturaNueva.ClienteId = _factura.Cliente.Id;
                    facturaNueva.TipoComprobante = _factura.TipoComprobante;

                    facturaNueva.Descuento = _factura.Descuento;
                    facturaNueva.SubTotal = _factura.SubTotal;
                    facturaNueva.Total = _factura.Total;

                    facturaNueva.Estado = Estado.Pagada;
                    facturaNueva.PuestoTrabajoId = _factura.PuntoVentaId;
                    facturaNueva.Fecha = DateTime.Now;
                    facturaNueva.Iva105 = 0;
                    facturaNueva.Iva21 = 0;
                    facturaNueva.UsuarioId = _factura.UsuarioId;

                    foreach (var item in _factura.Items)
                    {
                        facturaNueva.Items.Add(new DetalleComprobanteDto()
                        {
                            Cantidad = item.Cantidad,
                            Iva = item.Iva,
                            Descripcion = item.Descripcion,
                            Precio = item.Precio,
                            ArticuloId = item.ArticuloId,
                            Codigo = item.CodigoBarra,
                            SubTotal = item.SubTotal,

                            Eliminado = false
                        });
                    }
                }
                else
                {
                    //Pendiente de pago
                }

                //FORMAS DE PAGO

                //EFECTIVO
                if (nudTotalEfectivo.Value > 0)
                {
                    facturaNueva.FormasDePagos.Add(new FormaPagoDto()
                    {
                        Monto = nudTotalEfectivo.Value,
                        TipoPago = TipoPago.Efectivo,
                        Eliminado = false
                    });
                }

                //TARJETA
                if (nudTotalTarjeta.Value > 0)
                {
                    facturaNueva.FormasDePagos.Add(new FormaPagoTarjetaDto()
                    {
                        NumeroTarjeta = txtNumeroTarjeta.Text,
                        TipoPago = TipoPago.Tarjeta,
                        CantidadCuotas = (int)nudCantidadCuotas.Value,
                        CuponPago = txtCuponPago.Text,
                        Monto = nudTotalTarjeta.Value,
                        TarjetaId = (long)cmbTarjeta.SelectedValue,
                        Eliminado = false
                    });
                }

                //CHEQUE
                if (nudTotalCheque.Value > 0)
                {
                    facturaNueva.FormasDePagos.Add(new FormaPagoChequeDto()
                    {
                        BancoId = (long)cmbBanco.SelectedValue,
                        Monto = nudTotalCheque.Value,
                        ClienteId = _factura.Cliente.Id,
                        FechaVencimiento = dtpFechaVencimientoCheque.Value,
                        Numero = txtNumeroCheque.Text,
                        TipoPago = TipoPago.Cheque,
                        Eliminado = false
                    });
                }

                //CTA CTE
                if (nudTotalCtaCte.Value > 0)
                {
                    if (_vieneDeVentas)
                    {
                        var deuda = 0;  //Corregir

                        if (_factura.Cliente.ActivarCtaCte)

                        {
                            if (_factura.Cliente.TieneLimiteCompra && _factura.Cliente.MontoMaximoCtaCte < deuda + nudTotalCtaCte.Value)
                            {
                                var mensajeCtaCte =
                                    $"El cliente {_factura.Cliente.ApyNom} esta exediendo el limite permitido."
                                    + Environment.NewLine
                                    + $"El limite es {_factura.Cliente.MontoMaximoCtaCte.ToString("C")}";

                                MessageBox.Show(mensajeCtaCte);
                            }

                            facturaNueva.FormasDePagos.Add(new FormaPagoCtaCteDto()
                            {
                                TipoPago = TipoPago.CtaCte,
                                ClienteId = _factura.Cliente.Id,
                                Monto = nudTotalCtaCte.Value,
                                Eliminado = false
                            });
                        }
                    }
                    else // Si viene de Pendiente
                    {
                    }
                }

                _facturaServicio.Insertar(facturaNueva);

                MessageBox.Show("Los datos se grabaron correctamente.");

                RealizoVenta = true;
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                RealizoVenta = false;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            var fLookUpCliente = ObjectFactory.GetInstance<ClienteLookUp>();
            fLookUpCliente.ShowDialog();

            if (fLookUpCliente.EntidadSeleccionada != null)
            {
                var _cliente = (ClienteDto)fLookUpCliente.EntidadSeleccionada;
                txtApellido.Text = _cliente.ApyNom;
                txtDni.Text = _cliente.Dni;
                txtTelefono.Text = _cliente.Telefono;
                txtDireccion.Text = _cliente.Direccion;

                if (_vieneDeVentas)
                {
                    _factura.Cliente = _cliente;
                }
                else
                {
                    MessageBox.Show($"El cliente {_cliente.ApyNom} no tiene activa la Cta Cte.", "Atencion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void nudPagaCon_ValueChanged(object sender, EventArgs e)
        {
            CalcularVuelto();
        }

        private void nudTotal_ValueChanged(object sender, EventArgs e)
        {
            if (nudPagaCon.Value > 0)
            {
                CalcularVuelto();
            }
        }

        private void CalcularVuelto()
        {
            nudVuelto.Value = nudTotalEfectivo.Value - nudPagaCon.Value >= 0
                ? nudPagaCon.Value - nudTotalEfectivo.Value
                : (nudTotalEfectivo.Value - nudPagaCon.Value) * -1;

            nudVuelto.BackColor = nudTotalEfectivo.Value - nudPagaCon.Value >= 0
                ? Color.Red
                : Color.Green;
            nudVuelto.ForeColor = Color.White;
        }

        private void btnNuevaTarjeta_Click(object sender, EventArgs e)
        {
            var fAbm_Tarjeta = new _00046_Abm_tarjeta(TipoOperacion.Nuevo);
            fAbm_Tarjeta.ShowDialog();
        }

        private void btnNuevoBanco_Click(object sender, EventArgs e)
        {
            var fAbm_Banco = new _00048_Abm_Banco(TipoOperacion.Nuevo);
            fAbm_Banco.ShowDialog();
        }
    }
}