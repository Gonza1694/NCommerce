using Aplicacion.Constantes;
using FontAwesome.Sharp;
using IServicios.Articulo;
using IServicios.Caja;
using IServicios.Configuracion;
using IServicios.Persona;
using Presentacion.Core.Articulo;
using Presentacion.Core.Caja;
using Presentacion.Core.Cliente;
using Presentacion.Core.Comprobantes;
using Presentacion.Core.CondicionIva;
using Presentacion.Core.Configuracion;
using Presentacion.Core.Departamento;
using Presentacion.Core.Deposito;
using Presentacion.Core.Empleado;
using Presentacion.Core.Localidad;
using Presentacion.Core.Provincia;
using Presentacion.Core.Usuario;
using PresentacionBase.Formularios;
using StructureMap;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace CommerceApp
{
    public partial class Principal : Form
    {
        //
        private IconButton currentBtn;

        private Panel leftBorderBtn;
        //

        private readonly IClienteServicio _clienteServicio;
        private readonly IArticuloServicio _articuloServicio;
        private readonly IConfiguracionServicio _ConfiguracionServicio;
        private readonly ICajaServicio _cajaServicio;

        public Principal(IClienteServicio clienteServicio,
            IArticuloServicio articuloServicio,
            IConfiguracionServicio configuracionServicio,
            ICajaServicio cajaServicio)
        {
            InitializeComponent();

            _articuloServicio = articuloServicio;
            _ConfiguracionServicio = configuracionServicio;

            _cajaServicio = cajaServicio;
            _clienteServicio = clienteServicio;

            lblApellido.Text = Identidad.Apellido;
            lblNombre.Text = Identidad.Nombre;

            imgFotoUsuarioLogin.Image = Imagen.ConvertirImagen(Identidad.Foto);

            Perfil();

            //
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(8, 76);
            panel_lateral.Controls.Add(leftBorderBtn);
            //
        }

        #region PERFILES

        private void Perfil()
        {
            if (Identidad.EsAdmin)
            {
                PerfilAdmin();
            }
            else //coregir
            {
                PerfilEmleado();
            }
        }

        private void PerfilEmleado()
        {
            //btn panel laterla
            btn_venta.Enabled = true;
            btn_articulos.Enabled = true;
            btn_cliente.Enabled = true;
            btn_caja.Enabled = true;
            //toolstrip menu
            administraciónToolStripMenuItem.Enabled = true;
            cajaToolStripMenuItem.Enabled = true;
            proveedorToolStripMenuItem.Enabled = true;
        }

        private void PerfilAdmin()
        {
            if (Identidad.EsAdmin)
            {
                //imagen login
                imgFotoUsuarioLogin.Image = Imagen.ImagenUsuarioPorDefecto;

                //btn panel laterla
                btn_venta.Enabled = false;
                btn_articulos.Enabled = false;
                btn_cliente.Enabled = false;
                btn_caja.Enabled = false;

                //toolstrip menu
                administraciónToolStripMenuItem.Enabled = false;
                cajaToolStripMenuItem.Enabled = false;
                proveedorToolStripMenuItem.Enabled = false;
            }
        }

        #endregion PERFILES

        #region ESTILOS BOTONES

        private void ActivarBtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarBtn();
                //btn
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 150, 36);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;

                //boton borde izquierdo

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DesactivarBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        #endregion ESTILOS BOTONES

        // ======== ARTICULO =========//

        #region ARTICULO

        private void consultaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00017_Articulo>(sender);
        }

        private void nuevoArticuuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAbmArticulo = new _00018_Abm_Articulo(TipoOperacion.Nuevo);
            formAbmArticulo.ShowDialog();
        }

        #endregion ARTICULO

        #region ACTUALIZAR PRECIO

        private void actualizarPreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00031_ActualizarPrecios>(sender);
        }

        #endregion ACTUALIZAR PRECIO

        #region BAJA DE ARTICULO

        private void consultaToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00029_BajaDeArticulos>(sender);
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAbmBajaArticulo = new _00030_Abm_BajaArticulos(TipoOperacion.Nuevo);
            formAbmBajaArticulo.ShowDialog();
        }

        #endregion BAJA DE ARTICULO

        #region LISTA DE PRECIO

        private void consultaToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00032_ListaPrecio>(sender);
        }

        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var formAbmListaPrecio = new _00033_Abm_ListaPrecio(TipoOperacion.Nuevo);
            formAbmListaPrecio.ShowDialog();
        }

        #endregion LISTA DE PRECIO

        #region MARCA

        private void consultaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00021_Marca>(sender);
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var formAbmMarca = new _00022_Abm_Marca(TipoOperacion.Nuevo);
            formAbmMarca.ShowDialog();
        }

        #endregion MARCA

        #region MOTIVO DE BAJA

        private void consultaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00027_MotivoBaja>(sender);
        }

        private void nuevaToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            var formAbmMotivoBaja = new _00028_Abm_MotivoBaja(TipoOperacion.Nuevo);
            formAbmMotivoBaja.ShowDialog();
        }

        #endregion MOTIVO DE BAJA

        #region IVA

        private void consultaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00025_Iva>(sender);
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formAbmIva = new _00026_Abm_Iva(TipoOperacion.Nuevo);
            formAbmIva.ShowDialog();
        }

        #endregion IVA

        #region RUBRO

        private void consultaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00019_Rubro>(sender);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAbmRubro = new _00020_Abm_Rubro(TipoOperacion.Nuevo);
            formAbmRubro.ShowDialog();
        }

        #endregion RUBRO

        #region UNIDAD DE MEDIDA

        private void consultaToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00023_UnidadDeMedida>(sender);
        }

        private void nuevaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formAbmUnidadMedida = new _00024_Abm_UnidadDeMedida(TipoOperacion.Nuevo);
            formAbmUnidadMedida.ShowDialog();
        }

        #endregion UNIDAD DE MEDIDA

        //======= CLIENTE ==========//

        #region CLIENTE

        private void consultaToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00009_Cliente>(sender);
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAbmCliente = new _00010_Abm_Cliente(TipoOperacion.Nuevo);
            formAbmCliente.ShowDialog();
        }

        #endregion CLIENTE

        //======= CAJA==========//

        //======= PROVEEDOR ==========//

        //======== ADMINISTRACION =========//

        #region EMPLEADO

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00007_Empleado>(sender);
        }

        private void nuevoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var formAbmEmpleado = new _00008_Abm_Empleado(TipoOperacion.Nuevo);
            formAbmEmpleado.ShowDialog();
        }

        #endregion EMPLEADO

        #region PROVINCIA

        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00001_Provincia>(sender);
        }

        private void nnuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAbmProvincia = new _00002_Abm_Provincia(TipoOperacion.Nuevo);
            formAbmProvincia.ShowDialog();
        }

        #endregion PROVINCIA

        #region LOCALIDAD

        private void consultaToolStripMenuItem11_Click_1(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00005_Localidad>(sender);
        }

        private void nuevoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAbmLocalidad = new _00006_AbmLocalidad(TipoOperacion.Nuevo);
            formAbmLocalidad.ShowDialog();
        }

        #endregion LOCALIDAD

        #region DEPARTAMENTO

        private void consultaToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00003_Departamento>(sender);
        }

        private void nuevoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var formAbmDepartamento = new _00004_Abm_Departamento(TipoOperacion.Nuevo);
            formAbmDepartamento.ShowDialog();
        }

        #endregion DEPARTAMENTO

        #region CONDICION IVA

        private void consultaToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00013_CondicionIva>(sender);
        }

        private void nuevaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var formAbmCondicionIva = new _00014_Abm_CondicionIva(TipoOperacion.Nuevo);
            formAbmCondicionIva.ShowDialog();
        }

        #endregion CONDICION IVA

        #region DEPOSITO

        private void consultaToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_000055_Deposito>(sender);
        }

        private void nuevaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var formAbmDeposito = new _000054_Abm_Deposito(TipoOperacion.Nuevo);
            formAbmDeposito.ShowDialog();
        }

        #endregion DEPOSITO

        #region PUESTO DE TRABAJO

        private void consultaToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00051_PuestoTrabajo>(sender);
        }

        private void nuevoToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var formAbmPuestoTrabajo = new _00052_Abm_PuestoTrabajo(TipoOperacion.Nuevo);
            formAbmPuestoTrabajo.ShowDialog();
        }

        #endregion PUESTO DE TRABAJO

        #region USUARIOS

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00011_Usuario>(sender);
        }

        #endregion USUARIOS

        //======= SISTEMA ==========//

        #region CONFIGURACION

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00012_Configuracion>(sender);
        }

        #endregion CONFIGURACION

        //=================//

        private void timer_FechaHora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToShortTimeString();
            lbl_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        public virtual void InstanciarFormDentro<Formulario>(object sender) where Formulario : Form
        {
            ActivarBtn(sender, Color.WhiteSmoke);

            var formu = CrearFormu<Formulario>();

            InstanciarFormu(formu);

        }

        private void InstanciarFormu<Formulario>(Formulario formu) where Formulario : Form
        {
            if (formu == null)
            {
                formu = ObjectFactory.GetInstance<Formulario>();
                formu.TopLevel = false;
                flp_contenedor.Controls.Add(formu);
                formu.Dock = DockStyle.Fill;
                formu.Show();
                formu.BringToFront();
            }
            else
            {
                formu.BringToFront();
            }
        }

        private Formulario CrearFormu<Formulario>() where Formulario : Form
        {
            var formu = flp_contenedor.Controls.OfType<Formulario>().FirstOrDefault();
            return formu;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Identidad.Limpiar();

            lblNombre.Text = string.Empty;
            lblApellido.Text = string.Empty;
            imgFotoUsuarioLogin.Image = null;
            imgFotoUsuarioLogin.Visible = false;

            var fLogin = ObjectFactory.GetInstance<Login>();
            fLogin.ShowDialog();

            if (fLogin.PuedeIngresar)
            {
                imgFotoUsuarioLogin.Visible = true;
                lblApellido.Text = $"{Identidad.Apellido}";
                lblNombre.Text = $"{Identidad.Nombre}";
                imgFotoUsuarioLogin.Image = Imagen.ConvertirImagen(Identidad.Foto);
                Perfil();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00050_Venta>(sender);
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00009_Cliente>(sender);
        }

        private void btn_articulos_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00017_Articulo>(sender);
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00053_Compra>(sender);
        }

        private void btn_caja_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00038_Caja>(sender);
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            InstanciarFormDentro<_00012_Configuracion>(sender);
        }

        #region ARRASTRAR

        //ARRASTRAR
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion ARRASTRAR
    }
}