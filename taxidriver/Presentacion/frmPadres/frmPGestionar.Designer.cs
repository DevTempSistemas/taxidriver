namespace taxidriver.Presentacion.frmPadres
{
    partial class frmPGestionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPGestionar));
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pbxImagenBusqueda = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuTileButton();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(135, 158);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(615, 26);
            this.txtBusqueda.TabIndex = 13;
            // 
            // pbxImagenBusqueda
            // 
            this.pbxImagenBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("pbxImagenBusqueda.Image")));
            this.pbxImagenBusqueda.Location = new System.Drawing.Point(82, 150);
            this.pbxImagenBusqueda.Name = "pbxImagenBusqueda";
            this.pbxImagenBusqueda.Size = new System.Drawing.Size(47, 46);
            this.pbxImagenBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenBusqueda.TabIndex = 14;
            this.pbxImagenBusqueda.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBorrar.color = System.Drawing.SystemColors.Control;
            this.btnBorrar.colorActive = System.Drawing.Color.Wheat;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImagePosition = 5;
            this.btnBorrar.ImageZoom = 65;
            this.btnBorrar.LabelPosition = 34;
            this.btnBorrar.LabelText = "BORRAR";
            this.btnBorrar.Location = new System.Drawing.Point(290, 468);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(73, 88);
            this.btnBorrar.TabIndex = 22;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.color = System.Drawing.SystemColors.Control;
            this.btnNuevo.colorActive = System.Drawing.Color.Wheat;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImagePosition = 5;
            this.btnNuevo.ImageZoom = 65;
            this.btnNuevo.LabelPosition = 34;
            this.btnNuevo.LabelText = "NUEVO";
            this.btnNuevo.Location = new System.Drawing.Point(455, 468);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(73, 88);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.color = System.Drawing.SystemColors.Control;
            this.btnEditar.colorActive = System.Drawing.Color.Wheat;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImagePosition = 5;
            this.btnEditar.ImageZoom = 65;
            this.btnEditar.LabelPosition = 34;
            this.btnEditar.LabelText = "EDITAR";
            this.btnEditar.Location = new System.Drawing.Point(113, 468);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 88);
            this.btnEditar.TabIndex = 20;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(82, 202);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(668, 241);
            this.dgvGrilla.TabIndex = 23;
            // 
            // frmPGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(840, 600);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.pbxImagenBusqueda);
            this.Name = "frmPGestionar";
            this.Text = "frmPGestionar";
            this.Controls.SetChildIndex(this.pbxImagenBusqueda, 0);
            this.Controls.SetChildIndex(this.txtBusqueda, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            this.Controls.SetChildIndex(this.dgvGrilla, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtBusqueda;
        public System.Windows.Forms.PictureBox pbxImagenBusqueda;
        public Bunifu.Framework.UI.BunifuTileButton btnBorrar;
        public Bunifu.Framework.UI.BunifuTileButton btnNuevo;
        public Bunifu.Framework.UI.BunifuTileButton btnEditar;
        public System.Windows.Forms.DataGridView dgvGrilla;
    }
}