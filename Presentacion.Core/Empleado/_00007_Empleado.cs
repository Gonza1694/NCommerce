using IServicios.Persona;
using IServicios.Persona.DTOs;
using PresentacionBase.Formularios;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.Core.Empleado
{
    public partial class _00007_Empleado : FormConsulta
    {
        private readonly IEmpleadoServicio _empleadoServicio;

        public _00007_Empleado(IEmpleadoServicio empleadoServicio)
        {
            InitializeComponent();

            _empleadoServicio = empleadoServicio;
        }

        public override void ActualizarDatos(DataGridView dgv, string cadenaBuscar)
        {
            dgv.DataSource = (List<EmpleadoDto>)_empleadoServicio
                .Obtener(typeof(EmpleadoDto), !string.IsNullOrEmpty(cadenaBuscar) ? cadenaBuscar : string.Empty);

            FormatearGrilla(dgv);
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["Legajo"].Width = 100;
            dgv.Columns["Legajo"].HeaderText = "Legajo";
            dgv.Columns["Legajo"].Visible = true;

            dgv.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["ApyNom"].HeaderText = "Apellido y Nombre";
            dgv.Columns["ApyNom"].Visible = true;

            dgv.Columns["Dni"].Width = 100;
            dgv.Columns["Dni"].HeaderText = "DNI";
            dgv.Columns["Dni"].Visible = true;

            dgv.Columns["Telefono"].Width = 120;
            dgv.Columns["Telefono"].HeaderText = "Teléfono";
            dgv.Columns["Telefono"].Visible = true;

            dgv.Columns["Mail"].Width = 250;
            dgv.Columns["Mail"].HeaderText = "E-Mail";
            dgv.Columns["Mail"].Visible = true;

            dgv.Columns["EliminadoStr"].Width = 100;
            dgv.Columns["EliminadoStr"].HeaderText = "Eliminado";
            dgv.Columns["EliminadoStr"].Visible = true;
        }

        public override bool EjecutarComando(TipoOperacion operacion, long? id = null)
        {
            var formulario = new _00008_Abm_Empleado(operacion, id);
            formulario.ShowDialog();
            return formulario.RealizoAlgunaOperacion;
        }
    }
}