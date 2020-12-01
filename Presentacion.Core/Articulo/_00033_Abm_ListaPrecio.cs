using IServicios.ListaPrecio;
using IServicios.ListaPrecio.DTOs;
using PresentacionBase.Formularios;
using StructureMap;
using System.Windows.Forms;

namespace Presentacion.Core.Articulo
{
    public partial class _00033_Abm_ListaPrecio : FormAbm
    {
        private readonly IListaPrecioServicio _listaPrecioServicio;

        public _00033_Abm_ListaPrecio(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _listaPrecioServicio = ObjectFactory.GetInstance<IListaPrecioServicio>();
        }

        #region METODOS

        public override void CargarDatos(long? entidadId)
        {
            base.CargarDatos(entidadId);

            if (entidadId.HasValue)
            {
                var resultado = (ListaPrecioDto)_listaPrecioServicio.Obtener(entidadId.Value);

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

        public override void EjecutarComandoEliminar()
        {
            _listaPrecioServicio.Eliminar(EntidadId.Value);
        }

        public override void EjecutarComandoNuevo()
        {
            var nuevoRegistro = new ListaPrecioDto();
            nuevoRegistro.Descripcion = txtDescripcion.Text;
            nuevoRegistro.PorcentajeGanancia = nudPorcentaje.Value;
            nuevoRegistro.NecesitaAutorizacion = chkPedirAutorizacion.Checked;
            nuevoRegistro.Eliminado = false;

            _listaPrecioServicio.Insertar(nuevoRegistro);
        }

        public override void EjecutarComandoModificar()
        {
            var modificarRegistro = new ListaPrecioDto();
            modificarRegistro.Id = EntidadId.Value;
            modificarRegistro.Descripcion = txtDescripcion.Text;
            modificarRegistro.PorcentajeGanancia = nudPorcentaje.Value;
            modificarRegistro.NecesitaAutorizacion = chkPedirAutorizacion.Checked;
            modificarRegistro.Eliminado = false;

            _listaPrecioServicio.Modificar(modificarRegistro);
        }

        public override bool VerificarDatosObligatorios()
        {
            return !string.IsNullOrEmpty(txtDescripcion.Text);
        }

        public override bool VerificarSiExiste(long? id = null)
        {
            return _listaPrecioServicio.VerificarSiExiste(txtDescripcion.Text, id);
        }

        #endregion METODOS

        //public override void LimpiarControles(Form formulario)
        //{
        //    base.LimpiarControles(formulario);

        //    txtDescripcion.Focus();
        //}
    }
}