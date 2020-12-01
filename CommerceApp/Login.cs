using Aplicacion.Constantes;
using IServicios.Seguridad;
using PresentacionBase.Formularios;
using System;
using System.Windows.Forms;

namespace CommerceApp
{
    public partial class Login : FormBase
    {
        private readonly ISeguridadServicio _seguridad;
        public bool PuedeIngresar { get; private set; }

        public Login(ISeguridadServicio seguridad)
        {
            InitializeComponent();
            _seguridad = seguridad;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioAdmin.Usuario == txt_user.Text
                    && UsuarioAdmin.Password == txt_password.Text)
                {

                    Identidad.Apellido = "Admin";
                    Identidad.EsAdmin = true;
                    PuedeIngresar = true;
                    this.Close();
                    return;
                }

                var puedeAcceder = _seguridad.VerificarAcceso(txt_user.Text, txt_password.Text);

                if (puedeAcceder)
                {
                    var usuarioLogin = _seguridad.ObtenerUsuarioLogin(txt_user.Text);

                    if (usuarioLogin == null)
                        throw new Exception("Ocurrio un error al obtener el Usuario");

                    if (usuarioLogin.EstaBloqueado)
                    {
                        MessageBox.Show($"El usuario {usuarioLogin.ApyNomEmpleado} esta BLOQUEADO", "Atención",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        txt_user.Clear();
                        txt_password.Clear();
                        return;
                    }

                    Identidad.EmpleadoId = usuarioLogin.EmpleadoId;
                    Identidad.Nombre = usuarioLogin.NombreEmpleado;
                    Identidad.Apellido = usuarioLogin.ApellidoEmpleado;
                    Identidad.Foto = usuarioLogin.FotoEmpleado;
                    // ================================================ //
                    Identidad.UsuarioId = usuarioLogin.Id;
                    Identidad.Usuario = usuarioLogin.NombreUsuario;
                    // ================================================ //
                    PuedeIngresar = puedeAcceder;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("El usuario o el Password son Icorrectos");
                    txt_password.Clear();
                    txt_password.Focus();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                txt_password.Clear();
                txt_password.Focus();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PB_ojo_cerrado_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
            {
                txt_password.PasswordChar = '\0';
                PB_ojo_abierto.BringToFront();
            }
        }

        private void PB_ojo_abierto_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '\0')
            {
                PB_ojo_cerrado.BringToFront();
                txt_password.PasswordChar = '*';
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "Usuario";
            }
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "Usuario")
            {
                txt_user.Text = "";
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Contraseña" && txt_password.Focused)
            {
                txt_password.Text = "";
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "" && !txt_password.Focused)
            {
                txt_password.Text = "Contraseña";
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_ingresar.PerformClick();
            }
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_ingresar.PerformClick();
            }
        }
    }
}