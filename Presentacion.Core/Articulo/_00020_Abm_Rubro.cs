using IServicios.Rubro;
using IServicios.Rubro.DTOs;
using PresentacionBase.Formularios;
using StructureMap;
using System.Windows.Forms;

namespace Presentacion.Core.Articulo
{
    public partial class _00020_Abm_Rubro : FormAbm
    {
        private readonly IRubroServicio _rubroServicio;

        public _00020_Abm_Rubro(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();
            _rubroServicio = ObjectFactory.GetInstance<IRubroServicio>();
        }

        public override void CargarDatos(long? entidadId)
        {
            base.CargarDatos(entidadId);

            if (entidadId.HasValue)
            {
                var resultado = (RubroDto)_rubroServicio.Obtener(entidadId.Value);

                if (resultado == null)
                {
                    MessageBox.Show("Ocurrio un error al obtener el registro seleccionado");
                    Close();
                }

                txtDescripcion.Text = resultado.Descripcion;

                if (TipoOperacion == TipoOperacion.Eliminar)
                    DesactivarControles(this);
            }
            else // Nuevo
            {
                btnEjecutar.Text = "Nuevo";
            }
        }

        public override bool VerificarDatosObligatorios()
        {
            return !string.IsNullOrEmpty(txtDescripcion.Text);
        }

        //public override bool VerificarSiExiste(long? id = null)
        //{
        //    return _rubroServicio.VerificarSiExiste(txtDescripcion.Text, id);
        //}

        public override void EjecutarComandoNuevo()
        {
            var nuevoRegistro = new RubroDto();
            nuevoRegistro.Descripcion = txtDescripcion.Text;
            nuevoRegistro.Eliminado = false;

            _rubroServicio.Insertar(nuevoRegistro);
        }

        public override void EjecutarComandoModificar()
        {
            var modificarRegistro = new RubroDto();
            modificarRegistro.Id = EntidadId.Value;
            modificarRegistro.Descripcion = txtDescripcion.Text;
            modificarRegistro.Eliminado = false;

            _rubroServicio.Modificar(modificarRegistro);
        }

        public override void EjecutarComandoEliminar()
        {
            _rubroServicio.Eliminar(EntidadId.Value);
        }
    }
}