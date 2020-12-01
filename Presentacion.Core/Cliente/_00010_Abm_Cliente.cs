using IServicios.Departamento;
using IServicios.Localidad;
using IServicios.Persona;
using IServicios.Persona.DTOs;
using IServicios.Provincia;
using Presentacion.Core.CondicionIva;
using Presentacion.Core.Departamento;
using Presentacion.Core.Localidad;
using Presentacion.Core.Provincia;
using PresentacionBase.Formularios;
using StructureMap;
using System.Linq;
using System.Windows.Forms;
using static Aplicacion.Constantes.ValidacionDatosEntrada;

namespace Presentacion.Core.Cliente
{
    public partial class _00010_Abm_Cliente : FormAbm
    {
        private readonly ILocalidadServicio _LocalidadServicio;
        private readonly IDepartamentoServicio _departamentoServicio;
        private readonly IProvinciaServicio _provinciaServicio;
        private readonly IClienteServicio _clienteServicio;
        private readonly ICondicionIvaServicio _condicionIvaServicio;

        public _00010_Abm_Cliente(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _LocalidadServicio = ObjectFactory.GetInstance<ILocalidadServicio>();
            _provinciaServicio = ObjectFactory.GetInstance<IProvinciaServicio>();
            _departamentoServicio = ObjectFactory.GetInstance<IDepartamentoServicio>();
            _clienteServicio = ObjectFactory.GetInstance<IClienteServicio>();
            _condicionIvaServicio = ObjectFactory.GetInstance<ICondicionIvaServicio>();

            var provincias = _provinciaServicio.Obtener(string.Empty, false);

            PoblarComboBox(cmbProvincia, provincias, "Descripcion", "Id");

            if (provincias.Any())
            {
                var departamentos = _departamentoServicio.ObtenerPorProvincia(provincias.FirstOrDefault().Id);

                PoblarComboBox(cmbDepartamento, departamentos
                    , "Descripcion", "Id");

                if (departamentos.Any())
                {
                    PoblarComboBox(cmbLocalidad,
                        _LocalidadServicio.ObtenerPorDepartamento(departamentos.FirstOrDefault().Id), "Descripcion",
                        "Id");
                }
            }

            PoblarComboBox(cmbCondicionIva, _condicionIvaServicio.Obtener(string.Empty, false), "Descripcion", "Id");

            txtApellido.KeyPress += delegate (object sender, KeyPressEventArgs args)
            {
                NoInyeccion(sender, args);
                NoSimbolos(sender, args);
            };

            txtNombre.KeyPress += delegate (object sender, KeyPressEventArgs args)
            {
                NoInyeccion(sender, args);
                NoSimbolos(sender, args);
            };

            txtDni.KeyPress += delegate (object sender, KeyPressEventArgs args)
            {
                NoInyeccion(sender, args);
                NoSimbolos(sender, args);
                NoLetras(sender, args);
            };

            txtTelefono.KeyPress += delegate (object sender, KeyPressEventArgs args)
            {
                NoInyeccion(sender, args);
                NoSimbolos(sender, args);
                NoLetras(sender, args);
            };

            txtDomicilio.KeyPress += delegate (object sender, KeyPressEventArgs args)
            {
                NoInyeccion(sender, args);
                NoSimbolos(sender, args);
            };

            txtMail.KeyPress += delegate (object sender, KeyPressEventArgs args)
            {
                NoInyeccion(sender, args);
            };
        }

        public override void CargarDatos(long? entidadId)
        {
            if (entidadId.HasValue && entidadId.Value > 0)
            {
                var cliente = (ClienteDto)_clienteServicio.Obtener(typeof(ClienteDto), entidadId.Value);

                txtApellido.Text = cliente.Apellido;
                txtNombre.Text = cliente.Nombre;
                txtDni.Text = cliente.Dni;
                txtDomicilio.Text = cliente.Direccion;
                txtMail.Text = cliente.Mail;
                txtTelefono.Text = cliente.Telefono;
                cmbProvincia.SelectedValue = cliente.ProvinciaId;
                cmbCondicionIva.SelectedValue = cliente.CondicionIvaId;
                chkLimiteCompra.Checked = cliente.TieneLimiteCompra;
                chkActivarCuentaCorriente.Checked = cliente.ActivarCtaCte;
                nudLimiteCompra.Value = cliente.MontoMaximoCtaCte;

                nudLimiteCompra.Enabled = cliente.ActivarCtaCte;
                chkLimiteCompra.Enabled = cliente.ActivarCtaCte;

                var departamentos = _departamentoServicio.ObtenerPorProvincia(cliente.ProvinciaId);

                PoblarComboBox(cmbDepartamento, departamentos
                    , "Descripcion", "Id");

                cmbDepartamento.SelectedValue = cliente.DepartamentoId;

                PoblarComboBox(cmbLocalidad,
                    _LocalidadServicio.ObtenerPorDepartamento(cliente.DepartamentoId), "Descripcion",
                    "Id");

                cmbLocalidad.SelectedValue = cliente.LocalidadId;

                if (TipoOperacion != TipoOperacion.Eliminar) return;

                DesactivarControles(this);
            }
            else
            {
                LimpiarControles(this);
                chkActivarCuentaCorriente.Checked = false;
                chkLimiteCompra.Checked = false;
                chkLimiteCompra.Enabled = false;
                nudLimiteCompra.Value = 0m;
                nudLimiteCompra.Enabled = false;
            }
        }

        public override void EjecutarComandoNuevo()
        {
            _clienteServicio.Insertar(new ClienteDto
            {
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Dni = txtDni.Text,
                Direccion = txtDomicilio.Text,
                LocalidadId = (long)cmbLocalidad.SelectedValue,
                Mail = txtMail.Text,
                Telefono = txtTelefono.Text,
                Eliminado = false,
                CondicionIvaId = (long)cmbCondicionIva.SelectedValue,
                ActivarCtaCte = chkActivarCuentaCorriente.Checked,
                MontoMaximoCtaCte = nudLimiteCompra.Value,
                TieneLimiteCompra = chkLimiteCompra.Checked
            });
        }

        public override void EjecutarComandoModificar()
        {
            _clienteServicio.Modificar(new ClienteDto
            {
                Id = EntidadId.Value,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Dni = txtDni.Text,
                Direccion = txtDomicilio.Text,
                LocalidadId = (long)cmbLocalidad.SelectedValue,
                Mail = txtMail.Text,
                Telefono = txtTelefono.Text,
                CondicionIvaId = (long)cmbCondicionIva.SelectedValue,
                ActivarCtaCte = chkActivarCuentaCorriente.Checked,
                MontoMaximoCtaCte = nudLimiteCompra.Value,
                TieneLimiteCompra = chkLimiteCompra.Checked
            });
        }

        public override void EjecutarComandoEliminar()
        {
            _clienteServicio.Eliminar(typeof(ClienteDto), EntidadId.Value);
        }

        public override bool VerificarDatosObligatorios()
        {
            if (string.IsNullOrEmpty(txtApellido.Text)) return false;

            if (string.IsNullOrEmpty(txtNombre.Text)) return false;

            if (string.IsNullOrEmpty(txtDni.Text)) return false;

            if (string.IsNullOrEmpty(txtDomicilio.Text)) return false;

            if (cmbLocalidad.Items.Count <= 0) return false;

            if (cmbCondicionIva.Items.Count <= 0) return false;

            return true;
        }

        public override void EjecutarPostLimpieza()
        {
            var provincias = _provinciaServicio.Obtener(string.Empty, false);

            PoblarComboBox(cmbProvincia, provincias, "Descripcion", "Id");

            if (provincias.Any())
            {
                var departamentos = _departamentoServicio.ObtenerPorProvincia(provincias.FirstOrDefault().Id);

                PoblarComboBox(cmbDepartamento, departamentos
                    , "Descripcion", "Id");

                if (departamentos.Any())
                {
                    PoblarComboBox(cmbLocalidad,
                        _LocalidadServicio.ObtenerPorDepartamento(departamentos.FirstOrDefault().Id), "Descripcion",
                        "Id");
                }
            }

            txtApellido.Focus();
        }

        private void cmbProvincia_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            if (cmbProvincia.Items.Count <= 0) return;

            var provinciaId = (long)cmbProvincia.SelectedValue;
            PoblarComboBox(cmbDepartamento, _departamentoServicio.ObtenerPorProvincia(provinciaId), "Descripcion",
                "Id");
        }

        private void btnNuevaProvincia_Click(object sender, System.EventArgs e)
        {
            var fNuevaProvincia = new _00002_Abm_Provincia(TipoOperacion.Nuevo);

            fNuevaProvincia.ShowDialog();

            if (!fNuevaProvincia.RealizoAlgunaOperacion) return;

            var provincias = _provinciaServicio.Obtener(string.Empty, false);

            PoblarComboBox(cmbProvincia, provincias, "Descripcion", "Id");

            if (!provincias.Any()) return;

            PoblarComboBox(cmbDepartamento,
                _departamentoServicio.ObtenerPorProvincia(provincias.FirstOrDefault().Id), "Descripcion", "Id");
        }

        private void btnNuevoDepartamento_Click(object sender, System.EventArgs e)
        {
            var fNuevoDepartamento = new _00004_Abm_Departamento(TipoOperacion.Nuevo);

            fNuevoDepartamento.ShowDialog();

            if (!fNuevoDepartamento.RealizoAlgunaOperacion) return;

            if (cmbProvincia.Items.Count <= 0) return;

            var departamentos = _departamentoServicio.ObtenerPorProvincia((long)cmbProvincia.SelectedValue);

            PoblarComboBox(cmbDepartamento, departamentos, "Descripcion", "Id");

            if (!departamentos.Any())
            {
                cmbLocalidad.DataSource = null;
                return;
            }

            PoblarComboBox(cmbLocalidad, _LocalidadServicio.ObtenerPorDepartamento(departamentos.FirstOrDefault().Id),
                "Descripcion", "Id");
        }

        private void cmbDepartamento_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            if (cmbDepartamento.Items.Count <= 0) return;

            PoblarComboBox(cmbLocalidad, _LocalidadServicio.ObtenerPorDepartamento((long)cmbDepartamento.SelectedValue), "Descripcion", "Id");
        }

        private void btnNuevaLocalidad_Click(object sender, System.EventArgs e)
        {
            var fNuevaLocalidad = new _00006_AbmLocalidad(TipoOperacion.Nuevo);

            fNuevaLocalidad.ShowDialog();

            if (!fNuevaLocalidad.RealizoAlgunaOperacion) return;

            if (cmbDepartamento.Items.Count <= 0) return;

            PoblarComboBox(cmbLocalidad, _LocalidadServicio.ObtenerPorDepartamento((long)cmbDepartamento.SelectedValue), "Descripcion", "Id");
        }

        private void btnNuevaCondicionIva_Click(object sender, System.EventArgs e)
        {
            var fCondicionIva = new _00014_Abm_CondicionIva(TipoOperacion.Nuevo);
            fCondicionIva.ShowDialog();

            if (!fCondicionIva.RealizoAlgunaOperacion) return;

            PoblarComboBox(cmbCondicionIva, _condicionIvaServicio.Obtener(string.Empty, false), "Descripcion", "Id");
        }

        private void chkActivarCuentaCorriente_CheckedChanged(object sender, System.EventArgs e)
        {
            chkLimiteCompra.Enabled = chkActivarCuentaCorriente.Checked;
        }

        private void chkLimiteCompra_CheckedChanged(object sender, System.EventArgs e)
        {
            nudLimiteCompra.Enabled = chkLimiteCompra.Checked;
        }
    }
}