using IServicios.Iva;
using PresentacionBase.Formularios;
using System.Windows.Forms;

namespace Presentacion.Core.Articulo
{
    public partial class _00025_Iva : FormConsulta
    {
        private readonly IIvaServicio _ivaServicio;

        public _00025_Iva(IIvaServicio ivaServicio)
        {
            InitializeComponent();

            _ivaServicio = ivaServicio;
        }

        public override void ActualizarDatos(DataGridView dgv, string cadenaBuscar)
        {
            // Codigo agregado por Nosotros
            dgv.DataSource = _ivaServicio.Obtener(cadenaBuscar, true);

            // Codigo del PAPA
            base.ActualizarDatos(dgv, cadenaBuscar);
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["Descripcion"].Visible = true;
            dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Descripcion"].HeaderText = @"Descripción";

            dgv.Columns["EliminadoStr"].Visible = true;
            dgv.Columns["EliminadoStr"].Width = 100;
            dgv.Columns["EliminadoStr"].HeaderText = "Eliminado";
            dgv.Columns["EliminadoStr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public override bool EjecutarComando(TipoOperacion tipoOperacion, long? id = null)
        {
            var formulario = new _00026_Abm_Iva(tipoOperacion, id);

            formulario.ShowDialog();

            return formulario.RealizoAlgunaOperacion;
        }
    }
}