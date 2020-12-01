using IServicios.Seguridad;
using System;
using System.Windows.Forms;

namespace Presentacion.Core.Comprobantes.Clases
{
    public partial class AutorizacionListaPrecio : Form
    {
        private readonly ISeguridadServicio _seguridad;

        private bool _tienePermiso;
        public bool PermisoAutorizado => _tienePermiso;

        public AutorizacionListaPrecio(ISeguridadServicio seguridad)
        {
            InitializeComponent();

            _seguridad = seguridad;
            _tienePermiso = false;
        }

        private void btnVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txt_pass.PasswordChar = Char.MinValue;
        }

        private void btnVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txt_pass.PasswordChar = Char.Parse("*");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                _tienePermiso = _seguridad.VerificarAcceso(txt_user.Text, txt_pass.Text);

                if (_tienePermiso)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El usuario o el Password son Icorrectos");
                    txt_pass.Clear();
                    txt_pass.Focus();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                txt_pass.Clear();
                txt_pass.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _tienePermiso = false;
            Close();
        }
    }
}