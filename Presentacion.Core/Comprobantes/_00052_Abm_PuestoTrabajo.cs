using IServicios.PuestoTrabajo;
using IServicioss.PuestoTrabajo.DTOs;
using PresentacionBase.Formularios;
using StructureMap;
using System.Windows.Forms;
using static Aplicacion.Constantes.ValidacionDatosEntrada;

namespace Presentacion.Core.Comprobantes
{
    public partial class _00052_Abm_PuestoTrabajo : FormAbm
    {
        private readonly IPuestoTrabajoServicio _puestoTrabajoServicio;

        public _00052_Abm_PuestoTrabajo(TipoOperacion tipoOperacion, long? entidadId = null)
                : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _puestoTrabajoServicio = ObjectFactory.GetInstance<IPuestoTrabajoServicio>();

            txtCodigo.KeyPress += delegate (object sender, KeyPressEventArgs args)
            {
                NoSimbolos(sender, args);
                NoInyeccion(sender, args);
                NoLetras(sender, args);
            };

            txtDescripcion.KeyPress += delegate (object sender, KeyPressEventArgs args)
            {
                NoSimbolos(sender, args);
                NoInyeccion(sender, args);
            };
        }

        public override void CargarDatos(long? entidadId)
        {
            base.CargarDatos(entidadId);

            if (entidadId.HasValue)
            {
                var resultado = (PuestoTrabajooDto)_puestoTrabajoServicio.Obtener(entidadId.Value);

                if (resultado == null)
                {
                    MessageBox.Show("Ocurrio un error al obtener el registro seleccionado");
                    Close();
                }

                txtDescripcion.Text = resultado.Descripcion;
                txtCodigo.Text = resultado.Codigo.ToString();

                if (TipoOperacion == TipoOperacion.Eliminar)
                    DesactivarControles(this);
            }
            else
            {
                btnEjecutar.Text = "Grabar";
            }
        }

        public override bool VerificarDatosObligatorios()
        {
            return !string.IsNullOrEmpty(txtDescripcion.Text);
        }

        public override bool VerificarSiExiste(long? id = null)
        {
            return _puestoTrabajoServicio.VerificarSiExiste(txtDescripcion.Text, id);
        }

        public override void EjecutarComandoNuevo()
        {
            var nuevoRegistro = new PuestoTrabajooDto
            {
                Descripcion = txtDescripcion.Text,
                Codigo = int.Parse(txtCodigo.Text),
                Eliminado = false
            };

            _puestoTrabajoServicio.Insertar(nuevoRegistro);
        }

        public override void EjecutarComandoModificar()
        {
            var modificarRegistro = new PuestoTrabajooDto
            {
                Id = EntidadId.Value,
                Codigo = int.Parse(txtCodigo.Text),
                Descripcion = txtDescripcion.Text,
                Eliminado = false
            };

            _puestoTrabajoServicio.Modificar(modificarRegistro);
        }

        public override void EjecutarComandoEliminar()
        {
            _puestoTrabajoServicio.Eliminar(EntidadId.Value);
        }

        public override void LimpiarControles(object obj, bool tieneValorAsociado = false)
        {
            base.LimpiarControles(obj);

            txtDescripcion.Focus();
        }
    }
}