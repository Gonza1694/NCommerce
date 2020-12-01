using IServicios.Persona;
using IServicios.Persona.DTOs;
using PresentacionBase.Formularios;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Core.Cliente
{
    public partial class _00009_Cliente : FormConsultaConDetalle
    {
        private readonly IClienteServicio _clienteServicio;

        public _00009_Cliente(IClienteServicio clienteServicio)
        {
            InitializeComponent();
            _clienteServicio = clienteServicio;
        }

        public override void ActualizarDatos(DataGridView dgv, string cadenaBuscar)
        {
            var resultado = (List<ClienteDto>)_clienteServicio
                .Obtener(typeof(ClienteDto), !string.IsNullOrEmpty(cadenaBuscar) ? cadenaBuscar : string.Empty);

            // Sacamos el Registro de Consumidor Final para que no se pueda operar con el
            dgv.DataSource = resultado.Where(x => x.Dni != Aplicacion.Constantes.Cliente.ConsumidorFinal).ToList();

            base.ActualizarDatos(dgv, cadenaBuscar);
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["ApyNom"].HeaderText = "Apellido y Nombre";
            dgv.Columns["ApyNom"].Visible = true;
            dgv.Columns["ApyNom"].DisplayIndex = 1;

            dgv.Columns["Dni"].Width = 70;
            dgv.Columns["Dni"].HeaderText = "DNI";
            dgv.Columns["Dni"].Visible = true;
            dgv.Columns["Dni"].DisplayIndex = 2;

            dgv.Columns["Telefono"].Width = 100;
            dgv.Columns["Telefono"].HeaderText = "Teléfono";
            dgv.Columns["Telefono"].Visible = true;
            dgv.Columns["Telefono"].DisplayIndex = 3;

            dgv.Columns["EliminadoStr"].Width = 60;
            dgv.Columns["EliminadoStr"].HeaderText = "Eliminado";
            dgv.Columns["EliminadoStr"].Visible = true;
            dgv.Columns["EliminadoStr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["EliminadoStr"].DisplayIndex = 8;
        }

        public override bool EjecutarComando(TipoOperacion operacion, long? id = null)
        {
            var formulario = new _00010_Abm_Cliente(operacion, id);
            formulario.ShowDialog();
            return formulario.RealizoAlgunaOperacion;
        }

        public override void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            base.dgvGrilla_RowEnter(sender, e);

            if (EntidadSeleccionada == null) return;

            var cliente = (ClienteDto)EntidadSeleccionada;

            txt_Dom.Text = cliente.Direccion;
            txt_Prov.Text = cliente.Provincia;
            txt_Dpto.Text = cliente.Departamento;
            txt_Loc.Text = cliente.Localidad;
            txt_Mail.Text = cliente.Mail;
            txt_CondicionIva.Text = cliente.CondicionIva;

            txt_LimCompra.Text = cliente.TieneLimiteCompra ? "SI" : "NO";
            txt_CtaCte.Text = cliente.ActivarCtaCte ? "SI" : "NO";
            txt_MontoMax.Text = cliente.MontoMaximoCtaCte.ToString("C");
        }
    }
}