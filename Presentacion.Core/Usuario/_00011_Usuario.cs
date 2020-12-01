using IServicios.Usuario;
using IServicios.Usuario.DTOs;
using PresentacionBase.Formularios;
using System;
using System.Windows.Forms;

namespace Presentacion.Core.Usuario
{
    public partial class _00011_Usuario : FormBase
    {
        private readonly IUsuarioServicio _usuarioServicio;
        private UsuarioDto _usuarioDto;

        public _00011_Usuario(IUsuarioServicio usuarioServicio)
        {
            InitializeComponent();

            _usuarioServicio = usuarioServicio;
            _usuarioDto = null;
        }

        private void _00011_Usuario_Load(object sender, System.EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }

        private void ActualizarDatos(string cadenaBuscar)
        {
            dgvGrilla.DataSource =
                _usuarioServicio.Obtener(!string.IsNullOrEmpty(cadenaBuscar) ? cadenaBuscar : string.Empty);

            FormatearGrilla(dgvGrilla);
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["ApyNomEmpleado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["ApyNomEmpleado"].HeaderText = "Apellido y Nombre";
            dgv.Columns["ApyNomEmpleado"].Visible = true;

            dgv.Columns["NombreUsuario"].Width = 150;
            dgv.Columns["NombreUsuario"].HeaderText = "Usuario";
            dgv.Columns["NombreUsuario"].Visible = true;

            dgv.Columns["EstaBloqueadoStr"].Width = 100;
            dgv.Columns["EstaBloqueadoStr"].HeaderText = "Bloqueado";
            dgv.Columns["EstaBloqueadoStr"].Visible = true;

            dgv.Columns["EliminadoStr"].Width = 100;
            dgv.Columns["EliminadoStr"].HeaderText = "Eliminado";
            dgv.Columns["EliminadoStr"].Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(txtBuscar.Text);
        }

        private void txtBuscar_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.RowCount <= 0)
            {
                _usuarioDto = null;
                return;
            }

            _usuarioDto = (UsuarioDto)dgvGrilla.Rows[e.RowIndex].DataBoundItem;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (_usuarioDto == null)
            {
                MessageBox.Show("Por favor seleccione un empleado");
                return;
            }

            try
            {
                if (_usuarioDto.NombreUsuario == "NO ASIGNADO")
                {
                    _usuarioServicio.Crear(_usuarioDto.EmpleadoId, _usuarioDto.ApellidoEmpleado, _usuarioDto.NombreEmpleado);

                    ActualizarDatos(string.Empty);

                    MessageBox.Show("El usuario se creo correctamente");
                }
                else
                {
                    MessageBox.Show("El empleado ya tiene un usuario Asignado");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al crear el Usuario");
            }
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            if (_usuarioDto == null)
            {
                MessageBox.Show("Por favor seleccione un usuario");
                return;
            }

            try
            {
                _usuarioServicio.Bloquear(_usuarioDto.Id);

                txtBuscar.Clear();
                txtBuscar.Focus();

                ActualizarDatos(string.Empty);

                MessageBox.Show($"El usurio {_usuarioDto.NombreUsuario} se bloqueo/desbloqueo correctamente");
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al Bloquear/Desbloquear el Usuario");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (_usuarioDto == null)
            {
                MessageBox.Show("Por favor seleccione un usuario");
                return;
            }

            try
            {
                _usuarioServicio.ResetPassword(_usuarioDto.Id);

                txtBuscar.Clear();
                txtBuscar.Focus();

                ActualizarDatos(string.Empty);

                MessageBox.Show($"La contraseña del usuario {_usuarioDto.NombreUsuario} fue reinicio correctamente");
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al reiniciar la contraseña del Usuario");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }
    }
}