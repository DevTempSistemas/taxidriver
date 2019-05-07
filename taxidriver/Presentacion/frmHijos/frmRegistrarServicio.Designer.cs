namespace taxidriver.Presentacion.frmHijos
{
    partial class frmHRegistrarServicio
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxTipoServicio = new System.Windows.Forms.GroupBox();
            this.rbtnContrato = new System.Windows.Forms.RadioButton();
            this.rbtnEncomienda = new System.Windows.Forms.RadioButton();
            this.rbtnPorTramo = new System.Windows.Forms.RadioButton();
            this.rbtnPorPagar = new System.Windows.Forms.RadioButton();
            this.gbxDatosPasajero = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxTipoServicio.SuspendLayout();
            this.gbxDatosPasajero.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(258, 19);
            this.label1.Size = new System.Drawing.Size(494, 36);
            this.label1.Text = "REGISTRACION DE SERVICIO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(595, 265);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 28);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.button1.Location = new System.Drawing.Point(595, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 36);
            this.button1.TabIndex = 26;
            this.button1.Text = "REGISTRAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbxTipoServicio
            // 
            this.gbxTipoServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbxTipoServicio.Controls.Add(this.rbtnContrato);
            this.gbxTipoServicio.Controls.Add(this.rbtnEncomienda);
            this.gbxTipoServicio.Controls.Add(this.rbtnPorTramo);
            this.gbxTipoServicio.Controls.Add(this.rbtnPorPagar);
            this.gbxTipoServicio.Location = new System.Drawing.Point(365, 161);
            this.gbxTipoServicio.Name = "gbxTipoServicio";
            this.gbxTipoServicio.Size = new System.Drawing.Size(179, 132);
            this.gbxTipoServicio.TabIndex = 25;
            this.gbxTipoServicio.TabStop = false;
            this.gbxTipoServicio.Text = "SELECCIONE UN SERVICIO";
            // 
            // rbtnContrato
            // 
            this.rbtnContrato.AutoSize = true;
            this.rbtnContrato.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.rbtnContrato.Location = new System.Drawing.Point(28, 94);
            this.rbtnContrato.Name = "rbtnContrato";
            this.rbtnContrato.Size = new System.Drawing.Size(77, 21);
            this.rbtnContrato.TabIndex = 20;
            this.rbtnContrato.TabStop = true;
            this.rbtnContrato.Text = "Contrato";
            this.rbtnContrato.UseVisualStyleBackColor = true;
            // 
            // rbtnEncomienda
            // 
            this.rbtnEncomienda.AutoSize = true;
            this.rbtnEncomienda.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.rbtnEncomienda.Location = new System.Drawing.Point(28, 72);
            this.rbtnEncomienda.Name = "rbtnEncomienda";
            this.rbtnEncomienda.Size = new System.Drawing.Size(97, 21);
            this.rbtnEncomienda.TabIndex = 19;
            this.rbtnEncomienda.TabStop = true;
            this.rbtnEncomienda.Text = "Encomienda";
            this.rbtnEncomienda.UseVisualStyleBackColor = true;
            // 
            // rbtnPorTramo
            // 
            this.rbtnPorTramo.AutoSize = true;
            this.rbtnPorTramo.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.rbtnPorTramo.Location = new System.Drawing.Point(28, 49);
            this.rbtnPorTramo.Name = "rbtnPorTramo";
            this.rbtnPorTramo.Size = new System.Drawing.Size(85, 21);
            this.rbtnPorTramo.TabIndex = 18;
            this.rbtnPorTramo.TabStop = true;
            this.rbtnPorTramo.Text = "Por tramo";
            this.rbtnPorTramo.UseVisualStyleBackColor = true;
            // 
            // rbtnPorPagar
            // 
            this.rbtnPorPagar.AutoSize = true;
            this.rbtnPorPagar.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.rbtnPorPagar.Location = new System.Drawing.Point(28, 26);
            this.rbtnPorPagar.Name = "rbtnPorPagar";
            this.rbtnPorPagar.Size = new System.Drawing.Size(85, 21);
            this.rbtnPorPagar.TabIndex = 17;
            this.rbtnPorPagar.TabStop = true;
            this.rbtnPorPagar.Text = "Por pagar";
            this.rbtnPorPagar.UseVisualStyleBackColor = true;
            // 
            // gbxDatosPasajero
            // 
            this.gbxDatosPasajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbxDatosPasajero.Controls.Add(this.textBox3);
            this.gbxDatosPasajero.Controls.Add(this.label2);
            this.gbxDatosPasajero.Controls.Add(this.label4);
            this.gbxDatosPasajero.Controls.Add(this.textBox1);
            this.gbxDatosPasajero.Controls.Add(this.textBox2);
            this.gbxDatosPasajero.Controls.Add(this.label3);
            this.gbxDatosPasajero.Location = new System.Drawing.Point(49, 157);
            this.gbxDatosPasajero.Name = "gbxDatosPasajero";
            this.gbxDatosPasajero.Size = new System.Drawing.Size(286, 136);
            this.gbxDatosPasajero.TabIndex = 24;
            this.gbxDatosPasajero.TabStop = false;
            this.gbxDatosPasajero.Text = "DATOS DEL PASAJERO";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(137, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 25);
            this.textBox3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "IDENTIFICACION :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "APELLIDOS:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(137, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 25);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(137, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 25);
            this.textBox2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "NOMBRES:";
            // 
            // frmHRegistrarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxTipoServicio);
            this.Controls.Add(this.gbxDatosPasajero);
            this.Name = "frmHRegistrarServicio";
            this.Text = "frmHRegistrarServicio";
            this.Controls.SetChildIndex(this.gbxDatosPasajero, 0);
            this.Controls.SetChildIndex(this.gbxTipoServicio, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.gbxTipoServicio.ResumeLayout(false);
            this.gbxTipoServicio.PerformLayout();
            this.gbxDatosPasajero.ResumeLayout(false);
            this.gbxDatosPasajero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbxTipoServicio;
        private System.Windows.Forms.RadioButton rbtnContrato;
        private System.Windows.Forms.RadioButton rbtnEncomienda;
        private System.Windows.Forms.RadioButton rbtnPorTramo;
        private System.Windows.Forms.RadioButton rbtnPorPagar;
        private System.Windows.Forms.GroupBox gbxDatosPasajero;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}