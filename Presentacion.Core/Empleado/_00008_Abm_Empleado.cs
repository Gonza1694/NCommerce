using Aplicacion.Constantes;
using IServicios.Departamento;
using IServicios.Localidad;
using IServicios.Persona;
using IServicios.Persona.DTOs;
using IServicios.Provincia;
using Presentacion.Core.Departamento;
using Presentacion.Core.Localidad;
using Presentacion.Core.Provincia;
using PresentacionBase.Formularios;
using StructureMap;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Aplicacion.Constantes.Imagen;
using static Aplicacion.Constantes.ValidacionDatosEntrada;

namespace Presentacion.Core.Empleado
{
    public partial class _00008_Abm_Empleado : FormAbm
    {
        private readonly ILocalidadServicio _LocalidadServicio;
        private readonly IDepartamentoServicio _departamentoServicio;
        private readonly IProvinciaServicio _provinciaServicio;
        private readonly IEmpleadoServicio _empleadoServicio;

        public _00008_Abm_Empleado(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _LocalidadServicio = ObjectFactory.GetInstance<ILocalidadServicio>();
            _provinciaServicio = ObjectFactory.GetInstance<IProvinciaServicio>();
            _departamentoServicio = ObjectFactory.GetInstance<IDepartamentoServicio>();
            _empleadoServicio = ObjectFactory.GetInstance<IEmpleadoServicio>();

            imgFoto.Image = ImagenEmpleadoPorDefecto;

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

            txtMail.KeyPress += delegate (object sender, KeyPressEventArgs args) { NoInyeccion(sender, args); };
        }

        public override void CargarDatos(long? entidadId)
        {
            if (entidadId.HasValue && entidadId.Value > 0)
            {
                var empleado = (EmpleadoDto)_empleadoServicio.Obtener(typeof(EmpleadoDto), entidadId.Value);

                txtLegajo.Text = empleado.Legajo.ToString();
                txtApellido.Text = empleado.Apellido;
                txtNombre.Text = empleado.Nombre;
                txtDni.Text = empleado.Dni;
                txtDomicilio.Text = empleado.Direccion;
                txtMail.Text = empleado.Mail;
                txtTelefono.Text = empleado.Telefono;
                cmbProvincia.SelectedValue = empleado.ProvinciaId;

                var departamentos = _departamentoServicio.ObtenerPorProvincia(empleado.ProvinciaId);

                PoblarComboBox(cmbDepartamento, departamentos
                    , "Descripcion", "Id");

                cmbDepartamento.SelectedValue = empleado.DepartamentoId;

                PoblarComboBox(cmbLocalidad,
                    _LocalidadServicio.ObtenerPorDepartamento(empleado.DepartamentoId), "Descripcion",
                    "Id");

                cmbLocalidad.SelectedValue = empleado.LocalidadId;

                imgFoto.Image = ConvertirImagen(empleado.Foto);

                if (TipoOperacion != TipoOperacion.Eliminar) return;

                DesactivarControles(this);
            }
            else
            {
                LimpiarControles(this);
                txtLegajo.Text = _empleadoServicio.ObtenerSiguienteLegajo().ToString();
            }
        }

        public override void EjecutarComandoNuevo()
        {
            _empleadoServicio.Insertar(new EmpleadoDto
            {
                Legajo = int.Parse(txtLegajo.Text),
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Dni = txtDni.Text,
                Direccion = txtDomicilio.Text,
                LocalidadId = (long)cmbLocalidad.SelectedValue,
                Mail = txtMail.Text,
                Telefono = txtTelefono.Text,
                Foto = ConvertirImagen(imgFoto.Image),
                Eliminado = false
            });
        }

        public override void EjecutarComandoModificar()
        {
            _empleadoServicio.Modificar(new EmpleadoDto
            {
                Id = EntidadId.Value,
                Legajo = int.Parse(txtLegajo.Text),
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Dni = txtDni.Text,
                Direccion = txtDomicilio.Text,
                LocalidadId = (long)cmbLocalidad.SelectedValue,
                Mail = txtMail.Text,
                Telefono = txtTelefono.Text,
                Foto = ConvertirImagen(imgFoto.Image),
            });

            Identidad.Foto = Imagen.ConvertirImagen(imgFoto.Image);
        }

        public override void EjecutarComandoEliminar()
        {
            _empleadoServicio.Eliminar(typeof(EmpleadoDto), EntidadId.Value);
        }

        public override bool VerificarDatosObligatorios()
        {
            if (string.IsNullOrEmpty(txtApellido.Text)) return false;

            if (string.IsNullOrEmpty(txtNombre.Text)) return false;

            if (string.IsNullOrEmpty(txtDni.Text)) return false;

            if (string.IsNullOrEmpty(txtDomicilio.Text)) return false;

            if (cmbLocalidad.Items.Count <= 0) return false;

            return true;
        }

        public override void EjecutarPostLimpieza()
        {
            txtLegajo.Text = _empleadoServicio.ObtenerSiguienteLegajo().ToString();

            var provincias = _provinciaServicio.Obtener(string.Empty);

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

        private void _00008_Abm_Empleado_Shown(object sender, System.EventArgs e)
        {
            txtApellido.Focus();
        }

        private void cmbProvincia_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
        }

        private void btnNuevaProvincia_Click(object sender, System.EventArgs e)
        {
            var fNuevaProvincia = new _00002_Abm_Provincia(TipoOperacion.Nuevo);

            fNuevaProvincia.ShowDialog();

            if (!fNuevaProvincia.RealizoAlgunaOperacion) return;

            var provincias = _provinciaServicio.Obtener(string.Empty);

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

        private void btnImagen_Click(object sender, System.EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imgFoto.Image = string.IsNullOrEmpty(openFile.FileName)
                    ? ImagenEmpleadoPorDefecto
                    : Image.FromFile(openFile.FileName);
            }
            else
            {
                imgFoto.Image = ImagenEmpleadoPorDefecto;
            }
        }
    }
}