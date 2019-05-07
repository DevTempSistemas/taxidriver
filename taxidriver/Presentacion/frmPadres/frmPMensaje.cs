using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxidriver.Presentacion.frmPadres
{
    public partial class frmPMensaje : Form
    {
        public int var;
        public frmPMensaje(int x)
        {
            InitializeComponent();
            if (x == 1)
            {
                lblMensaje.Text = "¿ESTA SEGURO DE SALIR?";
            }
            if (x == 2)
            {
                lblMensaje.Text = "¿ESTA SEGURO DE \n CAMBIAR USUARIO?";
            }
            var = x;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (var == 1)
            {
                Application.Exit();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PCuadroMensaje_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
