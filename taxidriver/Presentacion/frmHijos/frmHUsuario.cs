using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxidriver.Presentacion.frmHijos
{
    public partial class frmHUsuario : frmPadres.frmPGestionar
    {
        public frmHUsuario()
        {
            InitializeComponent();
        }

        private void BunifuTileButton2_Click(object sender, EventArgs e)
        {
            frmUsuario AddUser = new frmUsuario();
            AddUser.ShowDialog();
        }
    }
}
