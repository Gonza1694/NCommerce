using IServicios.Deposito;
using PresentacionBase.Formularios;
using System.Windows.Forms;

namespace Presentacion.Core.Deposito
{
    public partial class _000055_Deposito : FormConsulta
    {
        private readonly IDepositoSevicio _depositoSevicio;

        public _000055_Deposito(IDepositoSevicio depositoSevicio)
        {
            InitializeComponent();
            _depositoSevicio = depositoSevicio;
        }

        public override void ActualizarDatos(DataGridView dgv, string cadenaBuscar)
        {
            dgv.DataSource = _depositoSevicio.Obtener(cadenaBuscar, true);

            base.ActualizarDatos(dgv, cadenaBuscar);
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["Descripcion"].Visible = true;
            dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Descripcion"].HeaderText = "Descripcion";
            dgv.Columns["Descripcion"].DisplayIndex = 0;

            dgv.Columns["Ubicacion"].Visible = true;
            dgv.Columns["Ubicacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Ubicacion"].HeaderText = "Ubicacion";
            dgv.Columns["Ubicacion"].DisplayIndex = 1;

            dgv.Columns["EliminadoStr"].Visible = true;
            dgv.Columns["EliminadoStr"].Width = 100;
            dgv.Columns["EliminadoStr"].HeaderText = "Eliminado";
            dgv.Columns["EliminadoStr"].DisplayIndex = 2;
        }

        public override bool EjecutarComando(TipoOperacion tipoOperacion, long? id = null)
        {
            var form = new _000054_Abm_Deposito(tipoOperacion, id);
            form.ShowDialog();
            return form.RealizoAlgunaOperacion;
        }
    }
}