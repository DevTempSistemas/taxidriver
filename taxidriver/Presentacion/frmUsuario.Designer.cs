namespace taxidriver.Presentacion
{
    partial class frmUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label cuentaLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label fechaCreacionLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label rolLabel;
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.cuentaTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.fechaCreacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.rolTextBox = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            apellidoLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            cuentaLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            fechaCreacionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(taxidriver.Data.Usuario);
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(39, 29);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 1;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(130, 26);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidoTextBox.TabIndex = 2;
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(39, 55);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(37, 13);
            claveLabel.TabIndex = 3;
            claveLabel.Text = "Clave:";
            // 
            // claveTextBox
            // 
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(130, 52);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(200, 20);
            this.claveTextBox.TabIndex = 4;
            // 
            // cuentaLabel
            // 
            cuentaLabel.AutoSize = true;
            cuentaLabel.Location = new System.Drawing.Point(39, 81);
            cuentaLabel.Name = "cuentaLabel";
            cuentaLabel.Size = new System.Drawing.Size(44, 13);
            cuentaLabel.TabIndex = 5;
            cuentaLabel.Text = "Cuenta:";
            // 
            // cuentaTextBox
            // 
            this.cuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cuenta", true));
            this.cuentaTextBox.Location = new System.Drawing.Point(130, 78);
            this.cuentaTextBox.Name = "cuentaTextBox";
            this.cuentaTextBox.Size = new System.Drawing.Size(200, 20);
            this.cuentaTextBox.TabIndex = 6;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(39, 107);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 7;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(130, 104);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(200, 20);
            this.estadoTextBox.TabIndex = 8;
            // 
            // fechaCreacionLabel
            // 
            fechaCreacionLabel.AutoSize = true;
            fechaCreacionLabel.Location = new System.Drawing.Point(39, 134);
            fechaCreacionLabel.Name = "fechaCreacionLabel";
            fechaCreacionLabel.Size = new System.Drawing.Size(85, 13);
            fechaCreacionLabel.TabIndex = 9;
            fechaCreacionLabel.Text = "Fecha Creacion:";
            // 
            // fechaCreacionDateTimePicker
            // 
            this.fechaCreacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuarioBindingSource, "FechaCreacion", true));
            this.fechaCreacionDateTimePicker.Location = new System.Drawing.Point(130, 130);
            this.fechaCreacionDateTimePicker.Name = "fechaCreacionDateTimePicker";
            this.fechaCreacionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaCreacionDateTimePicker.TabIndex = 10;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(39, 159);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 11;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(130, 156);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 12;
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.Location = new System.Drawing.Point(39, 185);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(26, 13);
            rolLabel.TabIndex = 13;
            rolLabel.Text = "Rol:";
            // 
            // rolTextBox
            // 
            this.rolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Rol", true));
            this.rolTextBox.Location = new System.Drawing.Point(130, 182);
            this.rolTextBox.Name = "rolTextBox";
            this.rolTextBox.Size = new System.Drawing.Size(200, 20);
            this.rolTextBox.TabIndex = 14;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(255, 208);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 254);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(claveLabel);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(cuentaLabel);
            this.Controls.Add(this.cuentaTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(fechaCreacionLabel);
            this.Controls.Add(this.fechaCreacionDateTimePicker);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(rolLabel);
            this.Controls.Add(this.rolTextBox);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox cuentaTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.DateTimePicker fechaCreacionDateTimePicker;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox rolTextBox;
        private System.Windows.Forms.Button btnAceptar;
    }
}