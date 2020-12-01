using Aplicacion.Constantes;
using IServicios.Caja;
using StructureMap;
using System.Windows.Forms;
using PresentacionBase.Formularios;

namespace Presentacion.Core.Caja
{
    public partial class _00038_Caja : FormBase
    {
        private readonly ICajaServicio _cajaServicio;

        public _00038_Caja(ICajaServicio cajaServicio)
        {
            InitializeComponent();
            _cajaServicio = cajaServicio;
        }

        private void btnAbrirCaja_Click(object sender, System.EventArgs e)
        {
            if (!_cajaServicio.VerificarSiEstaAbierta(Identidad.UsuarioId))
            {
                var fAperturaCaja = ObjectFactory.GetInstance<_00039_AperturaCaja>();
                fAperturaCaja.ShowDialog();

                if (fAperturaCaja.RealizoApertura)
                {
                    ActualizarDatos();
                }
            }
            else
            {
                MessageBox.Show($"Ya existe una caja abierta para el usuario {Identidad.Apellido} {Identidad.Nombre}.",
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarDatos()
        {
            dgvGrilla.DataSource = _cajaServicio.Obtener(chk_rangofecha.Checked, dtp_desde.Value, dtp_hasta.Value,
                string.IsNullOrEmpty(txtBuscar.Text) ? txtBuscar.Text : string.Empty);
            FormatearGrilla(dgvGrilla);
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);
            //===================================================//Apertura
            dgv.Columns["UsuarioApertura"].Visible = true;
            dgv.Columns["UsuarioApertura"].Width = 150;
            dgv.Columns["UsuarioApertura"].HeaderText = @"Usuario apertura";
            dgv.Columns["UsuarioApertura"].DisplayIndex = 0;

            dgv.Columns["FechaAperturaStr"].Visible = true;
            dgv.Columns["FechaAperturaStr"].Width = 70;
            dgv.Columns["FechaAperturaStr"].HeaderText = @"Fecha apertura";
            dgv.Columns["FechaAperturaStr"].DisplayIndex = 1;

            dgv.Columns["MontoAperturaStr"].Visible = true;
            dgv.Columns["MontoAperturaStr"].Width = 70;
            dgv.Columns["MontoAperturaStr"].HeaderText = @"Monto apertura";
            dgv.Columns["MontoAperturaStr"].DisplayIndex = 2;

            //===================================================//Cierre

            dgv.Columns["UsuarioCierre"].Visible = true;
            dgv.Columns["UsuarioCierre"].Width = 60;
            dgv.Columns["UsuarioCierre"].HeaderText = @"Usuario cierre";
            dgv.Columns["UsuarioCierre"].DisplayIndex = 3;

            dgv.Columns["FechaCierreStr"].Visible = true;
            dgv.Columns["FechaCierreStr"].Width = 70;
            dgv.Columns["FechaCierreStr"].HeaderText = @"Fecha cierre";
            dgv.Columns["FechaCierreStr"].DisplayIndex = 4;

            dgv.Columns["MontoCierreStr"].Visible = true;
            dgv.Columns["MontoCierreStr"].Width = 70;
            dgv.Columns["MontoCierreStr"].HeaderText = @"Monto cierre";
            dgv.Columns["MontoCierreStr"].DisplayIndex = 5;

            //===================================================//Entrada
            dgv.Columns["TotalEntradaEfectivoStr"].Visible = true;
            dgv.Columns["TotalEntradaEfectivoStr"].Width = 60;
            dgv.Columns["TotalEntradaEfectivoStr"].HeaderText = @"Efectivo Entrada";
            dgv.Columns["TotalEntradaEfectivoStr"].DisplayIndex = 6;

            dgv.Columns["TotalEntradaCtaCteStr"].Visible = true;
            dgv.Columns["TotalEntradaCtaCteStr"].Width = 60;
            dgv.Columns["TotalEntradaCtaCteStr"].HeaderText = @"Cta. Cte. entrada";
            dgv.Columns["TotalEntradaCtaCteStr"].DisplayIndex = 7;

            dgv.Columns["TotalEntradaTarjetaStr"].Visible = true;
            dgv.Columns["TotalEntradaTarjetaStr"].Width = 60;
            dgv.Columns["TotalEntradaTarjetaStr"].HeaderText = @"Tarjeta entrada";
            dgv.Columns["TotalEntradaTarjetaStr"].DisplayIndex = 8;

            dgv.Columns["TotalEntradaChequeStr"].Visible = true;
            dgv.Columns["TotalEntradaChequeStr"].Width = 60;
            dgv.Columns["TotalEntradaChequeStr"].HeaderText = @"Cheque entrada";
            dgv.Columns["TotalEntradaChequeStr"].DisplayIndex = 9;

            //===================================================//Salida
            dgv.Columns["TotalSalidaEfectivoStr"].Visible = true;
            dgv.Columns["TotalSalidaEfectivoStr"].Width = 60;
            dgv.Columns["TotalSalidaEfectivoStr"].HeaderText = @"Efectivo Salida";
            dgv.Columns["TotalSalidaEfectivoStr"].DisplayIndex = 6;

            dgv.Columns["TotalSalidaCtaCteStr"].Visible = true;
            dgv.Columns["TotalSalidaCtaCteStr"].Width = 60;
            dgv.Columns["TotalSalidaCtaCteStr"].HeaderText = @"Cta. Cte. Salida";
            dgv.Columns["TotalSalidaCtaCteStr"].DisplayIndex = 7;

            dgv.Columns["TotalSalidaTarjetaStr"].Visible = true;
            dgv.Columns["TotalSalidaTarjetaStr"].Width = 60;
            dgv.Columns["TotalSalidaTarjetaStr"].HeaderText = @"Tarjeta Salida";
            dgv.Columns["TotalSalidaTarjetaStr"].DisplayIndex = 8;

            dgv.Columns["TotalSalidaChequeStr"].Visible = true;
            dgv.Columns["TotalSalidaChequeStr"].Width = 60;
            dgv.Columns["TotalSalidaChequeStr"].HeaderText = @"Cheque Salida";
            dgv.Columns["TotalSalidaChequeStr"].DisplayIndex = 9;
        }
        private void _00038_Caja_Load(object sender, System.EventArgs e)
        {
            ActualizarDatos();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            ActualizarDatos();
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnCierreCaja_Click(object sender, System.EventArgs e)
        {

        }
    }
}