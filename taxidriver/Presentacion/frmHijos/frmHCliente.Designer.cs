namespace taxidriver.Presentacion.frmHijos
{
    partial class frmHCliente
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
            this.btnResgistrarServicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Size = new System.Drawing.Size(655, 26);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(297, 18);
            this.label1.Size = new System.Drawing.Size(387, 36);
            this.label1.Text = "GESTION DE CLIENTES";
            // 
            // btnResgistrarServicio
            // 
            this.btnResgistrarServicio.Location = new System.Drawing.Point(628, 507);
            this.btnResgistrarServicio.Name = "btnResgistrarServicio";
            this.btnResgistrarServicio.Size = new System.Drawing.Size(131, 42);
            this.btnResgistrarServicio.TabIndex = 17;
            this.btnResgistrarServicio.Text = "REGISTRAR SERVICIO";
            this.btnResgistrarServicio.UseVisualStyleBackColor = true;
            this.btnResgistrarServicio.Click += new System.EventHandler(this.BtnResgistrarServicio_Click);
            // 
            // frmHCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(840, 600);
            this.Controls.Add(this.btnResgistrarServicio);
            this.Name = "frmHCliente";
            this.Text = "frmHCliente";
            this.Load += new System.EventHandler(this.FrmHCliente_Load);
            this.Controls.SetChildIndex(this.btnResgistrarServicio, 0);
            this.Controls.SetChildIndex(this.pbxImagenBusqueda, 0);
            this.Controls.SetChildIndex(this.txtBusqueda, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResgistrarServicio;
    }
}