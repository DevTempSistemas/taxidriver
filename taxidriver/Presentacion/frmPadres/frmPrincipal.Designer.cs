namespace taxidriver.Presentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.PanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.PanelEncabezado = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.PanelMenuVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTipoPasajero = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxrecorrer = new System.Windows.Forms.PictureBox();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnChofer = new System.Windows.Forms.Button();
            this.btnEventual = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnPasajero = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnServicios = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PanelEncabezado.SuspendLayout();
            this.PanelMenuVertical.SuspendLayout();
            this.PanelTipoPasajero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxrecorrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.LightYellow;
            this.PanelPrincipal.ColumnCount = 1;
            this.PanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(250, 30);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.RowCount = 1;
            this.PanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 620F));
            this.PanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 620F));
            this.PanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 620F));
            this.PanelPrincipal.Size = new System.Drawing.Size(850, 620);
            this.PanelPrincipal.TabIndex = 14;
            // 
            // PanelEncabezado
            // 
            this.PanelEncabezado.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.PanelEncabezado.Controls.Add(this.btnRestaurar);
            this.PanelEncabezado.Controls.Add(this.btnMinimizar);
            this.PanelEncabezado.Controls.Add(this.btnCerrar);
            this.PanelEncabezado.Controls.Add(this.btnMaximizar);
            this.PanelEncabezado.Controls.Add(this.pbxrecorrer);
            this.PanelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEncabezado.Location = new System.Drawing.Point(250, 0);
            this.PanelEncabezado.Name = "PanelEncabezado";
            this.PanelEncabezado.Size = new System.Drawing.Size(850, 30);
            this.PanelEncabezado.TabIndex = 13;
            this.PanelEncabezado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelEncabezado_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnMaximizar.Location = new System.Drawing.Point(798, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.TabIndex = 50;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // PanelMenuVertical
            // 
            this.PanelMenuVertical.BackColor = System.Drawing.Color.Gold;
            this.PanelMenuVertical.Controls.Add(this.btnUsuarios);
            this.PanelMenuVertical.Controls.Add(this.btnVehiculos);
            this.PanelMenuVertical.Controls.Add(this.btnChofer);
            this.PanelMenuVertical.Controls.Add(this.label1);
            this.PanelMenuVertical.Controls.Add(this.PanelTipoPasajero);
            this.PanelMenuVertical.Controls.Add(this.btnPasajero);
            this.PanelMenuVertical.Controls.Add(this.btnCerrarSesion);
            this.PanelMenuVertical.Controls.Add(this.pictureBox4);
            this.PanelMenuVertical.Controls.Add(this.btnServicios);
            this.PanelMenuVertical.Controls.Add(this.pictureBox3);
            this.PanelMenuVertical.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuVertical.Name = "PanelMenuVertical";
            this.PanelMenuVertical.Size = new System.Drawing.Size(250, 650);
            this.PanelMenuVertical.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "RADIO\r\nTAXI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelTipoPasajero
            // 
            this.PanelTipoPasajero.BackColor = System.Drawing.Color.Gold;
            this.PanelTipoPasajero.Controls.Add(this.btnEventual);
            this.PanelTipoPasajero.Controls.Add(this.btnCliente);
            this.PanelTipoPasajero.Location = new System.Drawing.Point(0, 209);
            this.PanelTipoPasajero.Name = "PanelTipoPasajero";
            this.PanelTipoPasajero.Size = new System.Drawing.Size(250, 80);
            this.PanelTipoPasajero.TabIndex = 11;
            this.PanelTipoPasajero.Visible = false;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.BackgroundImage")));
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnRestaurar.Location = new System.Drawing.Point(796, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.TabIndex = 51;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnMinimizar.Location = new System.Drawing.Point(772, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.TabIndex = 50;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnCerrar.Location = new System.Drawing.Point(822, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 50;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // pbxrecorrer
            // 
            this.pbxrecorrer.BackColor = System.Drawing.Color.Transparent;
            this.pbxrecorrer.Image = ((System.Drawing.Image)(resources.GetObject("pbxrecorrer.Image")));
            this.pbxrecorrer.Location = new System.Drawing.Point(0, 0);
            this.pbxrecorrer.Name = "pbxrecorrer";
            this.pbxrecorrer.Size = new System.Drawing.Size(39, 30);
            this.pbxrecorrer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxrecorrer.TabIndex = 0;
            this.pbxrecorrer.TabStop = false;
            this.pbxrecorrer.Click += new System.EventHandler(this.Pbxrecorrer_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 381);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(244, 43);
            this.btnUsuarios.TabIndex = 13;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.FlatAppearance.BorderSize = 0;
            this.btnVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculos.ForeColor = System.Drawing.Color.Black;
            this.btnVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculos.Image")));
            this.btnVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.Location = new System.Drawing.Point(3, 338);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(244, 43);
            this.btnVehiculos.TabIndex = 12;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.BtnVehiculos_Click);
            // 
            // btnChofer
            // 
            this.btnChofer.FlatAppearance.BorderSize = 0;
            this.btnChofer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChofer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChofer.ForeColor = System.Drawing.Color.Black;
            this.btnChofer.Image = ((System.Drawing.Image)(resources.GetObject("btnChofer.Image")));
            this.btnChofer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChofer.Location = new System.Drawing.Point(3, 295);
            this.btnChofer.Name = "btnChofer";
            this.btnChofer.Size = new System.Drawing.Size(244, 43);
            this.btnChofer.TabIndex = 8;
            this.btnChofer.Text = "Chofer";
            this.btnChofer.UseVisualStyleBackColor = true;
            this.btnChofer.Click += new System.EventHandler(this.BtnChofer_Click);
            // 
            // btnEventual
            // 
            this.btnEventual.FlatAppearance.BorderSize = 0;
            this.btnEventual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnEventual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventual.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventual.ForeColor = System.Drawing.Color.Black;
            this.btnEventual.Image = ((System.Drawing.Image)(resources.GetObject("btnEventual.Image")));
            this.btnEventual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventual.Location = new System.Drawing.Point(53, 5);
            this.btnEventual.Name = "btnEventual";
            this.btnEventual.Size = new System.Drawing.Size(147, 32);
            this.btnEventual.TabIndex = 11;
            this.btnEventual.Text = "Eventual";
            this.btnEventual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEventual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEventual.UseVisualStyleBackColor = true;
            this.btnEventual.Click += new System.EventHandler(this.BtnEventual_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(53, 43);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(147, 32);
            this.btnCliente.TabIndex = 10;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // btnPasajero
            // 
            this.btnPasajero.FlatAppearance.BorderSize = 0;
            this.btnPasajero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasajero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasajero.ForeColor = System.Drawing.Color.Black;
            this.btnPasajero.Image = ((System.Drawing.Image)(resources.GetObject("btnPasajero.Image")));
            this.btnPasajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasajero.Location = new System.Drawing.Point(3, 170);
            this.btnPasajero.Name = "btnPasajero";
            this.btnPasajero.Size = new System.Drawing.Size(244, 43);
            this.btnPasajero.TabIndex = 7;
            this.btnPasajero.Text = "Pasajero";
            this.btnPasajero.UseVisualStyleBackColor = true;
            this.btnPasajero.Click += new System.EventHandler(this.BtnPasajero_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 430);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(244, 43);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cambiar usuario";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 84);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(250, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // btnServicios
            // 
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.Color.Black;
            this.btnServicios.Image = ((System.Drawing.Image)(resources.GetObject("btnServicios.Image")));
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Location = new System.Drawing.Point(3, 120);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(244, 43);
            this.btnServicios.TabIndex = 2;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.BtnServicios_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelEncabezado);
            this.Controls.Add(this.PanelMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PanelEncabezado.ResumeLayout(false);
            this.PanelMenuVertical.ResumeLayout(false);
            this.PanelMenuVertical.PerformLayout();
            this.PanelTipoPasajero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxrecorrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel PanelPrincipal;
        public System.Windows.Forms.Panel PanelEncabezado;
        public System.Windows.Forms.Button btnRestaurar;
        public System.Windows.Forms.Button btnMinimizar;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Button btnMaximizar;
        public System.Windows.Forms.PictureBox pbxrecorrer;
        public System.Windows.Forms.Panel PanelMenuVertical;
        public System.Windows.Forms.Button btnUsuarios;
        public System.Windows.Forms.Button btnVehiculos;
        public System.Windows.Forms.Button btnChofer;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel PanelTipoPasajero;
        public System.Windows.Forms.Button btnEventual;
        public System.Windows.Forms.Button btnCliente;
        public System.Windows.Forms.Button btnPasajero;
        public System.Windows.Forms.Button btnCerrarSesion;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Button btnServicios;
        public System.Windows.Forms.PictureBox pictureBox3;
    }
}