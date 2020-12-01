using IServicios.Marca;
using IServicios.Marca.DTOs;
using PresentacionBase.Formularios;
using StructureMap;
using System.Windows.Forms;

namespace Presentacion.Core.Articulo
{
    public partial class _00022_Abm_Marca : FormAbm
    {
        private readonly IMarcaServicio _marcaServicio;

        public _00022_Abm_Marca(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();
            _marcaServicio = ObjectFactory.GetInstance<IMarcaServicio>();
        }

        public override void CargarDatos(long? entidadId)
        {
            base.CargarDatos(entidadId);

            if (entidadId.HasValue)
            {
                var resultado = (MarcaDto)_marcaServicio.Obtener(entidadId.Value);

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
        //    return _marcaServicio.VerificarSiExiste(txtDescripcion.Text, id);
        //}

        public override void EjecutarComandoNuevo()
        {
            var nuevoRegistro = new MarcaDto();
            nuevoRegistro.Descripcion = txtDescripcion.Text;
            nuevoRegistro.Eliminado = false;

            _marcaServicio.Insertar(nuevoRegistro);
        }

        public override void EjecutarComandoModificar()
        {
            var modificarRegistro = new MarcaDto();
            modificarRegistro.Id = EntidadId.Value;
            modificarRegistro.Descripcion = txtDescripcion.Text;
            modificarRegistro.Eliminado = false;

            _marcaServicio.Modificar(modificarRegistro);
        }

        public override void EjecutarComandoEliminar()
        {
            _marcaServicio.Eliminar(EntidadId.Value);
        }
    }
}