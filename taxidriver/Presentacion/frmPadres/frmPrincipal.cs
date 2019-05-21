using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace taxidriver.Presentacion
{
    public partial class frmPrincipal : Form
    {
        int _idUsuarioLogueado;
        public frmPrincipal(int pIdUser)
        {
            InitializeComponent();
            
            PanelMenuVertical.Width = 250;
            _idUsuarioLogueado = pIdUser;  // si es v=2 es operador y v=1 es administrador
            //SituarBotones(220, 50);
            if (_idUsuarioLogueado == 1)
            {
                MenuAdministrador(120);
                
            }
            else
            {
                btnUsuarios.Visible = false;
                PanelTipoPasajero.Height = 0;
                SituarBotones(220);
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Funcion que permite abrir un formulario dentro del panel
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(fh);
            this.PanelPrincipal.Tag = fh;
            fh.Show();
        }
        private void MenuAdministrador(int y)
        {
            btnChofer.Location = new Point(3, y);
            btnVehiculos.Location = new Point(3, y = y + 50);
            btnUsuarios.Location = new Point(3, y = y + 50);
            btnCerrarSesion.Location = new Point(3, y = y + 50);

            btnServicios.Visible = false;
            btnPasajero.Visible = false;
            PanelTipoPasajero.Visible = false;
        }
        //procedimiento que permite situar los botones del menu vertical
        private void SituarBotones(int y)
        {
            btnChofer.Location = new Point(3, y);
            btnVehiculos.Location = new Point(3, y = y + 50);
            btnCerrarSesion.Location = new Point(3, y = y + 50);
        }
        
        private void BtnServicios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Presentacion.frmHijos.frmHChofer());
        }

        private void BtnPasajero_Click(object sender, EventArgs e)
        {
            if (PanelTipoPasajero.Height == 80)
            {
                PanelTipoPasajero.Height = 0;
                //btnCerrarSesion.Location = new Point(3, 220);
                SituarBotones(220);
                PanelTipoPasajero.Visible = true;
            }
            else
            {
                PanelTipoPasajero.Height = 80;
                //PanelTipoPasajero.Visible = false;
                SituarBotones(290);
            }
        }

        private void BtnEventual_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Presentacion.frmHijos.frmHEventual());
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Presentacion.frmHijos.frmHCliente());
        }

        private void BtnChofer_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Presentacion.frmHijos.frmHChofer());
        }

        private void BtnVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Presentacion.frmHijos.frmHVehiculos());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Presentacion.frmHijos.frmHUsuario());
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            //VISTA.frmPMensaje frmMess = new VISTA.frmPMensaje(2);
            //frmMess.ShowDialog();
            frmLogin frm = new frmLogin();
            this.Close();
            frm.Show();
        }

        private void Pbxrecorrer_Click(object sender, EventArgs e)
        {
            if (PanelMenuVertical.Width == 250)
                PanelMenuVertical.Width = 70;
            else
                PanelMenuVertical.Width = 250;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmPadres.frmInicio());
        }

        private void PanelEncabezado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
