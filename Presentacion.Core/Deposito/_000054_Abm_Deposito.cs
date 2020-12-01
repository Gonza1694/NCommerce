using IServicios.Deposito;
using IServicios.Deposito.DTOs;
using PresentacionBase.Formularios;
using StructureMap;
using System.Windows.Forms;

namespace Presentacion.Core.Deposito
{
    public partial class _000054_Abm_Deposito : FormAbm
    {
        private readonly IDepositoSevicio _depositoServicio;

        public _000054_Abm_Deposito(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _depositoServicio = ObjectFactory.GetInstance<IDepositoSevicio>();
        }

        public override void CargarDatos(long? entidadId)
        {
            base.CargarDatos(entidadId);

            if (entidadId.HasValue)
            {
                var resultado = (DepositoDto)_depositoServicio.Obtener(entidadId.Value);

                if (resultado == null)
                {
                    MessageBox.Show("Ocurrio un error al obtener el registro seleccionado");
                    Close();
                }

                txt_descripcion.Text = resultado.Descripcion;

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
            return !string.IsNullOrEmpty(txt_descripcion.Text);
        }

        public override void EjecutarComandoNuevo()
        {
            var nuevoRegistro = new DepositoDto();
            nuevoRegistro.Descripcion = txt_descripcion.Text;
            nuevoRegistro.Ubicacion = txt_ubicacion.Text;
            nuevoRegistro.Eliminado = false;

            _depositoServicio.Insertar(nuevoRegistro);
        }

        public override void EjecutarComandoModificar()
        {
            var modificarRegistro = new DepositoDto();
            modificarRegistro.Id = EntidadId.Value;
            modificarRegistro.Descripcion = txt_descripcion.Text;
            modificarRegistro.Ubicacion = txt_ubicacion.Text;
            modificarRegistro.Eliminado = false;

            _depositoServicio.Modificar(modificarRegistro);
        }

        public override void EjecutarComandoEliminar()
        {
            _depositoServicio.Eliminar(EntidadId.Value);
        }

        //public override bool VerificarSiExiste(long? id = null)
        //{
        //    return _depositoServicio.VerificarSiExiste(txtDescripcion.Text, id);
        //}
    }
}