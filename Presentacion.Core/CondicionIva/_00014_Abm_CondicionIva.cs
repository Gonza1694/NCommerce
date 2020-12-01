using IServicios.CondicionIva.DTOs;
using IServicios.Departamento;
using PresentacionBase.Formularios;
using StructureMap;
using System.Windows.Forms;

namespace Presentacion.Core.CondicionIva
{
    public partial class _00014_Abm_CondicionIva : FormAbm
    {
        private readonly ICondicionIvaServicio _provinciaServicio;

        public _00014_Abm_CondicionIva(TipoOperacion tipoOperacion, long? entidadId = null)
                : base(tipoOperacion, entidadId)
        {
            InitializeComponent();
            _provinciaServicio = ObjectFactory.GetInstance<ICondicionIvaServicio>();
        }

        public override void CargarDatos(long? entidadId)
        {
            base.CargarDatos(entidadId);

            if (entidadId.HasValue)
            {
                var resultado = (CondicionIvaDto)_provinciaServicio.Obtener(entidadId.Value);

                if (resultado == null)
                {
                    MessageBox.Show("Ocurrio un error al obtener el registro seleccionado");
                    Close();
                }

                txtDescripcion.Text = resultado.Descripcion;

                if (TipoOperacion == TipoOperacion.Eliminar)
                    DesactivarControles(this);
            }
            else
            {
                btnEjecutar.Text = "Nuevo";
            }
        }

        public override bool VerificarDatosObligatorios()
        {
            return !string.IsNullOrEmpty(txtDescripcion.Text);
        }

        public override bool VerificarSiExiste(long? id = null)
        {
            return _provinciaServicio.VerificarSiExiste(txtDescripcion.Text, id);
        }

        public override void EjecutarComandoNuevo()
        {
            var nuevoRegistro = new CondicionIvaDto();
            nuevoRegistro.Descripcion = txtDescripcion.Text;
            nuevoRegistro.Eliminado = false;

            _provinciaServicio.Insertar(nuevoRegistro);
        }

        public override void EjecutarComandoModificar()
        {
            var modificarRegistro = new CondicionIvaDto();
            modificarRegistro.Id = EntidadId.Value;
            modificarRegistro.Descripcion = txtDescripcion.Text;
            modificarRegistro.Eliminado = false;

            _provinciaServicio.Modificar(modificarRegistro);
        }

        public override void EjecutarComandoEliminar()
        {
            _provinciaServicio.Eliminar(EntidadId.Value);
        }

        public override void LimpiarControles(object obj, bool tieneValorAsociado = false)
        {
            base.LimpiarControles(obj);

            txtDescripcion.Focus();
        }
    }
}