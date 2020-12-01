using IServicios.BajaArticulo;
using IServicios.MotivoBaja;
using PresentacionBase.Formularios;
using StructureMap;
using System.Drawing;
using System.Windows.Forms;
using static Aplicacion.Constantes.Imagen;

namespace Presentacion.Core.Articulo
{
    public partial class _00030_Abm_BajaArticulos : FormAbm
    {
        private readonly IBajaArticuloServicio _bajaArticuloServicio;
        private readonly IMotivoBajaServicio _motivoBajaServicio;
        private long articuloId;

        public _00030_Abm_BajaArticulos(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            _bajaArticuloServicio = ObjectFactory.GetInstance<IBajaArticuloServicio>();
            _motivoBajaServicio = ObjectFactory.GetInstance<IMotivoBajaServicio>();

            imgFotoArticulo.Image = ImagenProductoPorDefecto;

            PoblarComboBox(cmbMotivoBaja,
                _motivoBajaServicio.Obtener(string.Empty),
                "Descripcion",
                "Id");
        }

        public override void CargarDatos(long? entidadId)
        {
            if (entidadId.HasValue)
            {
                var resultado = _bajaArticuloServicio.Obtener(entidadId.Value);

                if (resultado == null)
                {
                    MessageBox.Show("Ocurrió un problema al obtener la baja de articulos", "Atención");
                    Close();
                }
            }
            else
            {
                LimpiarControles(this);
            }
        }

        private void btnBuscarArticulo_Click(object sender, System.EventArgs e)
        {
            var lookUpArticulo = ObjectFactory.GetInstance<ArticuloLookUp>();
            lookUpArticulo.ShowDialog();

            if (lookUpArticulo.ArticuloSeleccionado == null) return;

            articuloId = lookUpArticulo.ArticuloSeleccionado.Id;
            txtArticulo.Text = lookUpArticulo.ArticuloSeleccionado.Descripcion;
            nudStockActual.Value = lookUpArticulo.ArticuloSeleccionado.StockActual;
        }

        private void btnNuevoMotivoBaja_Click(object sender, System.EventArgs e)
        {
            var fNuevoMotivoBaja = new _00028_Abm_MotivoBaja(TipoOperacion.Nuevo);
            fNuevoMotivoBaja.ShowDialog();
            if (fNuevoMotivoBaja.RealizoAlgunaOperacion)
            {
                PoblarComboBox(cmbMotivoBaja, _motivoBajaServicio.Obtener(string.Empty), "Descripcion", "Id");
            }
        }

        private void btnAgregarImagen_Click(object sender, System.EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imgFotoArticulo.Image = string.IsNullOrEmpty(openFile.FileName)
                    ? ImagenProductoPorDefecto
                    : Image.FromFile(openFile.FileName);
            }
            else
            {
                imgFotoArticulo.Image = ImagenProductoPorDefecto;
            }
        }
    }
}