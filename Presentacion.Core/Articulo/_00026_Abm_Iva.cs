using IServicios.Iva;
using IServicios.Iva.DTOs;
using PresentacionBase.Formularios;
using StructureMap;
using System.Windows.Forms;
using static Aplicacion.Constantes.ValidacionDatosEntrada;

namespace Presentacion.Core.Articulo
{
    public partial class _00026_Abm_Iva : FormAbm
    {
        private readonly IIvaServicio _ivaServicio;

        public _00026_Abm_Iva(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _ivaServicio = ObjectFactory.GetInstance<IIvaServicio>();

            txt_Descripcion.KeyPress += delegate (object sender, KeyPressEventArgs args)
            {
                NoInyeccion(sender, args);
            };
        }

        public override void CargarDatos(long? entidadId)
        {
            base.CargarDatos(entidadId);

            if (entidadId.HasValue)
            {
                var resultado = (IvaDto)_ivaServicio.Obtener(entidadId.Value);

                if (resultado == null)
                {
                    MessageBox.Show("Ocurrio un error al obtener el registro seleccionado");
                    Close();
                }

                txt_Descripcion.Text = resultado.Descripcion;
                nud_Porcentaje.Value = resultado.Porcentaje;

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
            return !string.IsNullOrEmpty(txt_Descripcion.Text);
        }

        //TO DO:
        //public override bool VerificarSiExiste(long? id = null)
        //{
        //    return _ivaServicio.VerificarSiExiste(txt_Descripcion.Text, id);
        //}

        public override void EjecutarComandoNuevo()
        {
            var nuevoRegistro = new IvaDto();
            nuevoRegistro.Descripcion = txt_Descripcion.Text;
            nuevoRegistro.Porcentaje = nud_Porcentaje.Value;
            nuevoRegistro.Eliminado = false;

            _ivaServicio.Insertar(nuevoRegistro);
        }

        public override void EjecutarComandoModificar()
        {
            var modificarRegistro = new IvaDto();
            modificarRegistro.Id = EntidadId.Value;
            modificarRegistro.Descripcion = txt_Descripcion.Text;
            modificarRegistro.Porcentaje = nud_Porcentaje.Value;
            modificarRegistro.Eliminado = false;

            _ivaServicio.Modificar(modificarRegistro);
        }

        public override void EjecutarComandoEliminar()
        {
            _ivaServicio.Eliminar(EntidadId.Value);
        }

        public override void LimpiarControles(object obj, bool tieneValorAsociado = false)
        {
            base.LimpiarControles(obj);

            txt_Descripcion.Focus();
        }
    }
}