using Aplicacion.Constantes;
using IServicios.Articulo;
using IServicios.Articulo.DTOs;
using IServicios.Configuracion;
using IServicios.Configuracion.DTOs;
using IServicios.Contador;
using IServicios.ListaPrecio;
using IServicios.ListaPrecio.DTOs;
using IServicios.Persona;
using IServicios.Persona.DTOs;
using IServicios.PuestoTrabajo;
using Presentacion.Core.Articulo;
using Presentacion.Core.Cliente;
using Presentacion.Core.Comprobantes.Clases;
using Presentacion.Core.Empleado;
using Presentacion.Core.FormaPago;
using PresentacionBase.Formularios;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Core.Comprobantes
{
    public partial class _00050_Venta : FormBase
    {
        private ClienteDto _clienteSeleccionado;
        private EmpleadoDto _vendedorSeleccionado;
        private ConfiguracionDto _configuracion;
        private FacturaView _factura;
        private ArticuloVentaDto _articuloSeleccionado;
        private ItemView _itemseleccionado;

        private bool _permiteAgregarPorCantidad;
        private bool _articuloConPrecioAlternativo;
        private bool _autorizaPermisoListaPrecio;
        private bool _ingresoPorCodigoBascula;

        private readonly IClienteServicio _clienteServicio;
        private readonly IPuestoTrabajoServicio _puestoTrabajoServicio;
        private readonly IListaPrecioServicio _listaPrecioServicio;
        private readonly IConfiguracionServicio _configuracionServicio;
        private readonly IEmpleadoServicio _empleadoServicio;
        private readonly IContadorServicio _contadorServicio;
        private readonly IArticuloServicio _articuloServicio;

        public _00050_Venta(IClienteServicio clienteServicio,
            IPuestoTrabajoServicio puestoTrabajoServicio,
            IListaPrecioServicio listaPrecioServicio,
            IConfiguracionServicio configuracionServicio,
            IEmpleadoServicio empleadoServicio,
            IContadorServicio contadorServicio,
            IArticuloServicio articuloServicio)
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            // ================================  Servicios   ================================= //

            _clienteServicio = clienteServicio;
            _puestoTrabajoServicio = puestoTrabajoServicio;
            _listaPrecioServicio = listaPrecioServicio;
            _configuracionServicio = configuracionServicio;
            _empleadoServicio = empleadoServicio;
            _contadorServicio = contadorServicio;
            _articuloServicio = articuloServicio;

            // =============================================================================== //

            dgvGrilla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvGrilla.AllowUserToResizeRows = false;

            // =================  Asignacion de Variables Privadas   ========================= //
            _clienteSeleccionado = null;
            _vendedorSeleccionado = null;
            _articuloSeleccionado = null;
            _itemseleccionado = null;

            _permiteAgregarPorCantidad = false;
            _articuloConPrecioAlternativo = false;
            _autorizaPermisoListaPrecio = false;
            _ingresoPorCodigoBascula = false;

            _factura = new FacturaView();

            _configuracion = _configuracionServicio.Obtener();

            if (_configuracion == null)
            {
                MessageBox.Show("Antes de comenzar por favor cargue la configuracion del Sistema");
                Close();
            }
        }

        // ======================================================================== //
        // ====================         Eventos          ========================== //
        // ======================================================================== //

        private void _00050_Venta_Load(object sender, System.EventArgs e)
        {
            CargarCabecera();

            CargarCuerpo();

            CargarPie();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            var lookUpCliente = ObjectFactory.GetInstance<ClienteLookUp>();
            lookUpCliente.ShowDialog();

            if (lookUpCliente.EntidadSeleccionada != null)
            {
                _clienteSeleccionado = (ClienteDto)lookUpCliente.EntidadSeleccionada;
                AsignarDatosCliente((ClienteDto)lookUpCliente.EntidadSeleccionada);
            }
            else
            {
                _clienteSeleccionado = ObtenerClienteConsumidorFinal();
                AsignarDatosCliente(_clienteSeleccionado);
            }
        }

        private void cmbPuestoVenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CambiarTituloDelPuntoVenta();
        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            var lookUpVendedor = ObjectFactory.GetInstance<EmpleadoLookUp>();
            lookUpVendedor.ShowDialog();

            if (lookUpVendedor.EntidadSeleccionada != null)
            {
                _vendedorSeleccionado = (EmpleadoDto)lookUpVendedor.EntidadSeleccionada;
                AsignarDatosVendedor((EmpleadoDto)lookUpVendedor.EntidadSeleccionada);
            }
            else
            {
                _vendedorSeleccionado = ObtenerVendedorPorDefecto();
                AsignarDatosVendedor(_vendedorSeleccionado);
            }
        }

        private void cmbTipoComprobante_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtNroComprobante.Text = _contadorServicio
                .ObtenerSiguienteNumeroComprobante((TipoComprobante)cmbTipoComprobante.SelectedItem).ToString();
        }

        private void nud_Descuento_ValueChanged(object sender, EventArgs e)
        {
            _factura.Descuento = nud_Descuento.Value;
            CargarPie();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (txtCodigo.Text.Contains("*"))
                    {
                        if (AsignarArticuloAlternativo(txtCodigo.Text))
                        {
                            btn_Agregar.PerformClick();
                            return;
                        }
                    }

                    if (txtCodigo.Text.Length == 13)
                    {
                        if (_configuracion.ActivarBascula
                            && _configuracion.CodigoBascula == txtCodigo.Text.Substring(0, 4))
                        {
                            if (AsignarArticuloPorBascula(txtCodigo.Text))
                            {
                                btn_Agregar.PerformClick();
                                return;
                            }
                        }
                        else
                        {
                            _articuloSeleccionado = _articuloServicio.ObtenerPorCodigo(txtCodigo.Text,
                                (long)cmbListaPrecio.SelectedValue,
                                _configuracion.DepositoVentaId);
                        }
                    }
                    else
                    {
                        _articuloSeleccionado = _articuloServicio.ObtenerPorCodigo(txtCodigo.Text,
                            (long)cmbListaPrecio.SelectedValue,
                            _configuracion.DepositoVentaId);
                    }

                    if (_articuloSeleccionado != null)
                    {
                        if (_permiteAgregarPorCantidad)
                        {
                            txtCodigo.Text = _articuloSeleccionado.CodigoBarra;
                            txtDescripcion.Text = _articuloSeleccionado.Descripcion;
                            txtPrecioUnitario.Text = _articuloSeleccionado.PrecioStr;
                            nudCantidad.Focus();
                            nudCantidad.Select(0, nudCantidad.Text.Length);
                            return;
                        }
                        else
                        {
                            btn_Agregar.PerformClick();
                        }
                    }
                    else
                    {
                        LimpiarParaNuevoItem();
                    }
                }
            }

            e.Handled = false;
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                // F5
                case 116:
                    _permiteAgregarPorCantidad = !_permiteAgregarPorCantidad;
                    nudCantidad.Enabled = _permiteAgregarPorCantidad;
                    break;
                // F8
                case 119:

                    var lookUpArticulo = new ArticuloLookUp((long)cmbListaPrecio.SelectedValue);
                    lookUpArticulo.ShowDialog();

                    if (lookUpArticulo.EntidadSeleccionada != null)
                    {
                        _articuloSeleccionado = (ArticuloVentaDto)lookUpArticulo.EntidadSeleccionada;

                        if (_permiteAgregarPorCantidad)
                        {
                            txtCodigo.Text = _articuloSeleccionado.CodigoBarra;
                            txtDescripcion.Text = _articuloSeleccionado.Descripcion;
                            txtPrecioUnitario.Text = _articuloSeleccionado.PrecioStr;
                            nudCantidad.Focus();
                            nudCantidad.Select(0, nudCantidad.Text.Length);
                            return;
                        }
                        else
                        {
                            btn_Agregar.PerformClick();
                            LimpiarParaNuevoItem();
                        }
                    }
                    else
                    {
                        LimpiarParaNuevoItem();
                    }

                    break;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (_articuloSeleccionado != null)
            {
                var listaPrecioSeleccionada = (ListaPrecioDto)cmbListaPrecio.SelectedItem;

                if (listaPrecioSeleccionada.NecesitaAutorizacion)
                {
                    if (!_autorizaPermisoListaPrecio)
                    {
                        var fAutorizacion = ObjectFactory.GetInstance<AutorizacionListaPrecio>();
                        fAutorizacion.ShowDialog();

                        if (!fAutorizacion.PermisoAutorizado) return;

                        _autorizaPermisoListaPrecio = fAutorizacion.PermisoAutorizado;
                        AgregarItem(_articuloSeleccionado, (long)cmbListaPrecio.SelectedValue, nudCantidad.Value);
                    }
                    else
                    {
                        AgregarItem(_articuloSeleccionado, (long)cmbListaPrecio.SelectedValue, nudCantidad.Value);
                    }
                }
                else
                {
                    AgregarItem(_articuloSeleccionado, (long)cmbListaPrecio.SelectedValue, nudCantidad.Value);
                }
            }

            LimpiarParaNuevoItem();
            CargarCuerpo();
            CargarPie();
        }

        private void AgregarItem(ArticuloVentaDto articulo, long listaPrecioId, decimal cantidad)
        {
            // Limite de Venta por cantidad
            if (articulo.TieneRestriccionPorCantidad)
            {
                var totalArticulosItems = _factura.Items
                    .Where(x => x.ArticuloId == articulo.Id)
                    .Sum(x => x.Cantidad);

                if (cantidad + totalArticulosItems > articulo.Limite)
                {
                    var mensajeLimiteVenta = $"El articulo {articulo.Descripcion.ToUpper()} tiene una restricción"
                                  + Environment.NewLine
                                  + $"de Venta por una Cantidad Maxima de {articulo.Limite}.";

                    MessageBox.Show(mensajeLimiteVenta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            if (articulo.TieneRestriccionHorario)
            {
                if (VerificarLimiteHorarioVenta(articulo.HoraDesde, articulo.HoraHasta))
                {
                    var mensajeLimiteHorario = $"El articulo {articulo.Descripcion.ToUpper()} tiene una restricción"
                                             + Environment.NewLine
                                             + $"de Venta por horario entre {articulo.HoraDesde.ToShortTimeString()} hasta {articulo.HoraHasta.ToShortTimeString()}.";

                    MessageBox.Show(mensajeLimiteHorario, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            if (!articulo.PermiteStockNegativo)
            {
                if (!VerificarStock(articulo, nudCantidad.Value))
                {
                    var mensajeStock = $"No hay Stock suficiente para el articulo {articulo.Descripcion.ToUpper()}"
                                       + Environment.NewLine
                                       + $"Stock Actual disponible: {articulo.Stock}.";

                    MessageBox.Show(mensajeStock, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            if (_articuloConPrecioAlternativo || _ingresoPorCodigoBascula)
            {
                _factura.Items.Add(AsignarDatosItem(articulo, listaPrecioId, cantidad));
            }
            else
            {
                if (_configuracion.UnificarRenglonesIngresarMismoProducto)
                {
                    var item = _factura.Items.FirstOrDefault(x => x.ArticuloId == articulo.Id
                                                                  && x.ListaPrecioId == listaPrecioId);

                    if (item == null) // Primera vez por ingresar
                    {
                        _factura.Items.Add(AsignarDatosItem(articulo, listaPrecioId, cantidad));
                    }
                    else
                    {
                        item.Cantidad += cantidad;
                    }
                }
                else
                {
                    _factura.Items.Add(AsignarDatosItem(articulo, listaPrecioId, cantidad));
                }
            }
        }

        private ItemView AsignarDatosItem(ArticuloVentaDto articulo, long listaPrecioId, decimal cantidad)
        {
            _factura.ContadorItem++;
            return new ItemView
            {
                Id = _factura.ContadorItem,
                Descripcion = articulo.Descripcion,
                Iva = articulo.Iva,
                Precio = articulo.Precio,
                CodigoBarra = articulo.CodigoBarra,
                Cantidad = cantidad,
                ListaPrecioId = listaPrecioId,
                ArticuloId = articulo.Id,
                EsArticuloAlternativo = _articuloConPrecioAlternativo,
                IngresoPorBascula = _ingresoPorCodigoBascula
            };
        }

        private bool VerificarStock(ArticuloVentaDto articulo, decimal cantidad)
        {
            var totalArticulosItems = _factura.Items
                .Where(x => x.ArticuloId == articulo.Id)
                .Sum(x => x.Cantidad);

            return totalArticulosItems + cantidad <= articulo.Stock;
        }

        private bool VerificarLimiteHorarioVenta(DateTime limiteHoraDesde, DateTime limiteHoraHasta)
        {
            var _horaDesdeSistena = DateTime.Now.Hour;
            var _minutoDesdeSistema = DateTime.Now.Minute;
            // ------------------------------------------ //
            var _horaDesdeInicioDia = 0;
            var _minutoDesdeInicioDia = 0;
            // ------------------------------------------ //
            var _horaDesdeFinDia = 23;
            var _minutoDesdeFinDia = 59;

            if (limiteHoraDesde <= limiteHoraHasta) // Mismo Dia
            {
                if (_horaDesdeSistena >= limiteHoraDesde.Hour && _minutoDesdeSistema >= limiteHoraDesde.Minute)
                {
                    if (_horaDesdeSistena < limiteHoraHasta.Hour)
                    {
                        return true;
                    }
                    else if (_horaDesdeSistena == limiteHoraHasta.Hour && _minutoDesdeSistema <= limiteHoraHasta.Minute)
                    {
                        return true;
                    }
                }
            }
            else // Dias Diferentes -> Ej: 11:00 PM hasta 06:00 AM
            {
                if (_horaDesdeSistena >= limiteHoraDesde.Hour)
                {
                    // Rango 1
                    return _horaDesdeSistena >= limiteHoraDesde.Hour
                           && _minutoDesdeSistema >= limiteHoraDesde.Minute
                           && _horaDesdeSistena <= _horaDesdeFinDia
                           && _minutoDesdeSistema <= _minutoDesdeFinDia;
                }
                else
                {
                    // Rango 2

                    if (_horaDesdeSistena >= _horaDesdeInicioDia && _minutoDesdeSistema >= _minutoDesdeInicioDia)
                    {
                        if (_horaDesdeSistena < limiteHoraHasta.Hour)
                        {
                            return true;
                        }
                        else if (_horaDesdeSistena == limiteHoraHasta.Hour &&
                                 _minutoDesdeSistema <= limiteHoraHasta.Minute)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private void nudCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Agregar.PerformClick();
            }
        }

        // ======================================================================== //
        // ====================   Metodos Privados    ============================= //
        // ======================================================================== //

        private void CargarCabecera()
        {
            _clienteSeleccionado = ObtenerClienteConsumidorFinal();
            AsignarDatosCliente(_clienteSeleccionado);

            // ============================================================================= //

            lblFechaActual.Text = DateTime.Today.ToShortDateString();

            // ============================================================================= //

            PoblarComboBox(cmbTipoComprobante, Enum.GetValues(typeof(TipoComprobante)));
            cmbTipoComprobante.SelectedItem = TipoComprobante.B;

            txtNroComprobante.Text = _contadorServicio.ObtenerSiguienteNumeroComprobante(TipoComprobante.B).ToString();

            // ============================================================================= //

            PoblarComboBox(cmbPuestoVenta,
                _puestoTrabajoServicio.Obtener(string.Empty, false),
                "Descripcion",
                "Id");

            if (cmbPuestoVenta.Items.Count == 0)
            {
                MessageBox.Show("Por favor Cargue primeramente los puntos de Ventas");
                Close();
            }

            CambiarTituloDelPuntoVenta();

            // ============================================================================= //

            PoblarComboBox(cmbListaPrecio,
                _listaPrecioServicio.Obtener(string.Empty, false),
                "Descripcion",
                "Id");

            if (cmbListaPrecio.Items.Count == 0)
            {
                MessageBox.Show("Por favor Cargue primeramente las listas de Precio");
                Close();
            }

            cmbListaPrecio.SelectedValue = _configuracion.ListaPrecioPorDefectoId;

            // ============================================================================= //

            _vendedorSeleccionado = ObtenerVendedorPorDefecto();
            AsignarDatosVendedor(_vendedorSeleccionado);
        }

        private void CargarCuerpo()
        {
            dgvGrilla.DataSource = _factura.Items.ToList();
            FormatearGrilla(dgvGrilla);

            if (_factura.Items.Any())
            {
                var ultimoItem = _factura.Items.Last();

                lbl_UltimaDescripcion.Text = ultimoItem.Descripcion.ToUpper();
                lblPrecioPorCantidad.Text = $"{ultimoItem.Cantidad} X {ultimoItem.PrecioStr} = {ultimoItem.SubTotalStr}";
            }
            else
            {
                lbl_UltimaDescripcion.Text = string.Empty;
                lblPrecioPorCantidad.Text = string.Empty;
            }
        }

        private void CargarPie()
        {
            txtSubTotal.Text = _factura.SubTotalStr;
            nud_Descuento.Value = _factura.Descuento;
            txtTotal.Text = _factura.TotalStr;
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["CodigoBarra"].Visible = true;
            dgv.Columns["CodigoBarra"].Width = 100;
            dgv.Columns["CodigoBarra"].HeaderText = "Código";
            dgv.Columns["CodigoBarra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.Columns["Descripcion"].Visible = true;
            dgv.Columns["Descripcion"].HeaderText = "Articulo";
            dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["Iva"].Visible = true;
            dgv.Columns["Iva"].Width = 100;
            dgv.Columns["Iva"].HeaderText = "Iva";
            dgv.Columns["Iva"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["PrecioStr"].Visible = true;
            dgv.Columns["PrecioStr"].Width = 120;
            dgv.Columns["PrecioStr"].HeaderText = "Precio";
            dgv.Columns["PrecioStr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["Cantidad"].Visible = true;
            dgv.Columns["Cantidad"].Width = 120;
            dgv.Columns["Cantidad"].HeaderText = "Cantidad";
            dgv.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns["SubTotalStr"].Visible = true;
            dgv.Columns["SubTotalStr"].Width = 120;
            dgv.Columns["SubTotalStr"].HeaderText = "Sub-Total";
            dgv.Columns["SubTotalStr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void AsignarDatosVendedor(EmpleadoDto empleado)
        {
            txtVendedor.Text = empleado.ApyNom;
        }

        private EmpleadoDto ObtenerVendedorPorDefecto()
        {
            return (EmpleadoDto)_empleadoServicio.Obtener(typeof(EmpleadoDto), Identidad.EmpleadoId);
        }

        private void CambiarTituloDelPuntoVenta()
        {
            this.Text = $"TPV - {cmbPuestoVenta.Text}";
        }

        private ClienteDto ObtenerClienteConsumidorFinal()
        {
            var clientes = (List<ClienteDto>)_clienteServicio.Obtener(typeof(ClienteDto),
                Aplicacion.Constantes.Cliente.ConsumidorFinal);

            if (clientes.FirstOrDefault() == null)
            {
                MessageBox.Show("El cliente Consumidor Final no Existe");
                Close();
            }

            return clientes.FirstOrDefault();
        }

        private void AsignarDatosCliente(ClienteDto cliente)
        {
            txt_DniCliente.Text = cliente.Dni;
            txt_Cliente.Text = cliente.ApyNom;
            txt_DomicilioCliente.Text = cliente.Direccion;
            txt_CondicionIvaCliente.Text = cliente.CondicionIva;
            txt_TelefonoCliente.Text = cliente.Telefono;
        }

        private bool AsignarArticuloAlternativo(string codigo)
        {
            _articuloConPrecioAlternativo = true;

            var codigoArticulo = codigo.Substring(0, codigo.IndexOf('*'));

            if (!string.IsNullOrEmpty(codigoArticulo))
            {
                _articuloSeleccionado = _articuloServicio.ObtenerPorCodigo(codigoArticulo, (long)cmbListaPrecio.SelectedValue, _configuracion.DepositoVentaId);

                if (_articuloSeleccionado != null)
                {
                    var precioAlternativo = codigo.Substring(codigo.IndexOf('*') + 1);

                    if (!string.IsNullOrEmpty(precioAlternativo))
                    {
                        if (decimal.TryParse(precioAlternativo, out decimal _precio))
                        {
                            _articuloSeleccionado.Precio = _precio;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return false;
        }

        private bool AsignarArticuloPorBascula(string codigoBascula)
        {
            decimal _precioBascula = 0;
            decimal _pesoBascula = 0;

            _ingresoPorCodigoBascula = true;

            int.TryParse(codigoBascula.Substring(4, 3), out int codigoArticulo);

            var precioPesoArticulo = codigoBascula.Substring(7, 5);

            if (_configuracion.EsImpresionPorPrecio)
            {
                if (!decimal.TryParse(precioPesoArticulo.Insert(3, ","), NumberStyles.Number,
                    new CultureInfo("es-Ar"), out _precioBascula))
                {
                    return false;
                }
            }
            else
            {
                if (!decimal.TryParse(precioPesoArticulo.Insert(2, ","), NumberStyles.Number,
                    new CultureInfo("es-Ar"), out _pesoBascula))
                {
                    return false;
                }
            }

            _articuloSeleccionado = _articuloServicio.ObtenerPorCodigo(codigoArticulo.ToString(), (long)cmbListaPrecio.SelectedValue, _configuracion.DepositoVentaId);

            if (_articuloSeleccionado != null)
            {
                if (_configuracion.EsImpresionPorPrecio)
                {
                    _articuloSeleccionado.Precio = _precioBascula;
                }
                else
                {
                    nudCantidad.Value = _pesoBascula;
                }
            }

            return false;
        }

        private void LimpiarParaNuevoItem()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecioUnitario.Clear();
            nudCantidad.Value = 1;
            nudCantidad.Enabled = false;
            _permiteAgregarPorCantidad = false;
            _articuloConPrecioAlternativo = false;
            _ingresoPorCodigoBascula = false;
            _articuloSeleccionado = null;
            txtCodigo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            //Si el Puesto de trabajado esta separado o no
            _factura.Cliente = _clienteSeleccionado;
            _factura.Vendedor = _vendedorSeleccionado;
            _factura.TipoComprobante = (TipoComprobante)cmbTipoComprobante.SelectedItem;
            _factura.PuntoVentaId = (long)cmbPuestoVenta.SelectedValue;
            _factura.UsuarioId = Identidad.UsuarioId;

            if (_configuracion.PuestoCajaSeparado)
            {
                //Factura estado pendiente
            }
            else
            {
                //Forma de pago
                var fFormaDePago = new _00044_FormaPago(_factura);
                fFormaDePago.ShowDialog();

                if (fFormaDePago.RealizoVenta)
                {
                    LimpiarParaNuevaFactura();
                    txtCodigo.Focus();
                }
            }
        }

        private void LimpiarParaNuevaFactura()
        {
            _factura = new FacturaView();
            CargarCabecera();
            CargarCuerpo();
            CargarPie();
            LimpiarParaNuevoItem();
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.RowCount <= 0) return;

            if (MessageBox.Show($"¿Está seguro que desea eliminar el item {_itemseleccionado.Descripcion}?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _factura.Items.Remove(_itemseleccionado);
                LimpiarParaNuevoItem();
                CargarCuerpo();
                CargarPie();
            }
        }

        private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                _itemseleccionado = (ItemView)dgvGrilla.Rows[e.RowIndex].DataBoundItem;
            }
            else
            {
                _itemseleccionado = null;
            }
        }
    }
}