using System;
using IServicios.Configuracion;
using System.Windows.Forms;
using Aplicacion.Constantes;
using IServicios.Caja;

namespace Presentacion.Core.Caja
{
    public partial class _00039_AperturaCaja : Form
    {
        private readonly IConfiguracionServicio _configuracionServicio;
        private readonly ICajaServicio _cajaServicio;
        public bool RealizoApertura { get; set; }

        public _00039_AperturaCaja(IConfiguracionServicio configuracionServicio, ICajaServicio cajaServicio)
        {
            InitializeComponent();
            _configuracionServicio = configuracionServicio;
            _cajaServicio = cajaServicio;
        }

        private void _00039_AperturaCaja_Load(object sender, System.EventArgs e)
        {
            var config = _configuracionServicio.Obtener();
            if (config==null)
            {
                MessageBox.Show(("Por favor debe cargar la configuracion del sistema"));
                Close();
            }

            if (config.IngresoManualCajaInicial)
            {
                nudMonto.Value = 0m;
                nudMonto.Select(0,nudMonto.Text.Length);
                nudMonto.Focus();
            }
            else
            {
                var montoAnterior = _cajaServicio.ObtenerUltimoMontoDeCierre(Identidad.UsuarioId);

                nudMonto.Value = montoAnterior;
                nudMonto.Select(0, nudMonto.Text.Length);
                nudMonto.Focus();
            }
        }

        private void btnEjecutar_Click(object sender, System.EventArgs e)
        {
            try
            {
                _cajaServicio.Abrir(Identidad.UsuarioId, nudMonto.Value);

                RealizoApertura = true;

                MessageBox.Show("La caja se abrio correctamente");
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            nudMonto.Value = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            RealizoApertura = false;
            Close();
        }
    }
}