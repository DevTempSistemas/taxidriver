namespace taxidriver.Presentacion.frmHijos
{
    partial class frmHUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Size = new System.Drawing.Size(655, 26);
            // 
            // bunifuTileButton2
            // 
            this.btnNuevo.Click += new System.EventHandler(this.BunifuTileButton2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(280, 18);
            this.label1.Size = new System.Drawing.Size(395, 36);
            this.label1.Text = "GESTION DE USUARIOS";
            // 
            // frmHUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(840, 600);
            this.Name = "frmHUsuario";
            this.Text = "frmHUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}