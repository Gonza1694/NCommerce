using IServicios.PuestoTrabajo;
using IServicioss.PuestoTrabajo.DTOs;
using PresentacionBase.Formularios;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.Core.Comprobantes
{
    public partial class _00051_PuestoTrabajo : FormConsulta
    {
        private readonly IPuestoTrabajoServicio _puestoTrabajoServicio;

        public _00051_PuestoTrabajo(IPuestoTrabajoServicio puestoTrabajoServicio)
        {
            InitializeComponent();
            _puestoTrabajoServicio = puestoTrabajoServicio;
        }

        public override void ActualizarDatos(DataGridView dgv, string cadenaBuscar)
        {
            dgv.DataSource = (List<PuestoTrabajooDto>)_puestoTrabajoServicio.Obtener(cadenaBuscar);

            base.ActualizarDatos(dgv, cadenaBuscar);
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["Codigo"].Visible = true;
            dgv.Columns["Codigo"].Width = 100;
            dgv.Columns["Codigo"].HeaderText = "Código";

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
            var form = new _00052_Abm_PuestoTrabajo(tipoOperacion, id);
            form.ShowDialog();
            return form.RealizoAlgunaOperacion;
        }
    }
}