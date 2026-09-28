namespace pryOlariagaGimnasio
{
    partial class frmInscripcion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTItulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.gpbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.gpbPlan = new System.Windows.Forms.GroupBox();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.gpbFormaDePago = new System.Windows.Forms.GroupBox();
            this.gpbFormaPago = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtTarjeta = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gpbDescuento = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbDatosPersonales.SuspendLayout();
            this.gpbPlan.SuspendLayout();
            this.gpbFormaDePago.SuspendLayout();
            this.gpbFormaPago.SuspendLayout();
            this.gpbDescuento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTItulo
            // 
            this.lblTItulo.AutoSize = true;
            this.lblTItulo.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTItulo.Location = new System.Drawing.Point(177, 9);
            this.lblTItulo.Name = "lblTItulo";
            this.lblTItulo.Size = new System.Drawing.Size(203, 62);
            this.lblTItulo.TabIndex = 0;
            this.lblTItulo.Text = "Gimnasio Siglo";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(237, 55);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(77, 16);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Inscripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(37, 67);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 34);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(107, 64);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(24, 20);
            this.txtEdad.TabIndex = 6;
            // 
            // gpbDatosPersonales
            // 
            this.gpbDatosPersonales.Controls.Add(this.txtEdad);
            this.gpbDatosPersonales.Controls.Add(this.txtNombre);
            this.gpbDatosPersonales.Controls.Add(this.lblEdad);
            this.gpbDatosPersonales.Controls.Add(this.lblNombre);
            this.gpbDatosPersonales.Location = new System.Drawing.Point(27, 79);
            this.gpbDatosPersonales.Name = "gpbDatosPersonales";
            this.gpbDatosPersonales.Size = new System.Drawing.Size(228, 134);
            this.gpbDatosPersonales.TabIndex = 8;
            this.gpbDatosPersonales.TabStop = false;
            this.gpbDatosPersonales.Text = "Datos Personales";
            // 
            // gpbPlan
            // 
            this.gpbPlan.Controls.Add(this.txtMeses);
            this.gpbPlan.Controls.Add(this.lblMeses);
            this.gpbPlan.Controls.Add(this.cboTurno);
            this.gpbPlan.Controls.Add(this.lblTurno);
            this.gpbPlan.Controls.Add(this.lblPlan);
            this.gpbPlan.Controls.Add(this.cboPlan);
            this.gpbPlan.Location = new System.Drawing.Point(308, 79);
            this.gpbPlan.Name = "gpbPlan";
            this.gpbPlan.Size = new System.Drawing.Size(233, 134);
            this.gpbPlan.TabIndex = 9;
            this.gpbPlan.TabStop = false;
            this.gpbPlan.Text = "Plan";
            // 
            // cboPlan
            // 
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Items.AddRange(new object[] {
            "Musculacion",
            "Funcional",
            "Natacion"});
            this.cboPlan.Location = new System.Drawing.Point(77, 28);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(121, 21);
            this.cboPlan.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(137, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Estudiante";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(22, 31);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(34, 13);
            this.lblPlan.TabIndex = 1;
            this.lblPlan.Text = "Plan: ";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(15, 62);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(41, 13);
            this.lblTurno.TabIndex = 2;
            this.lblTurno.Text = "Turno: ";
            // 
            // cboTurno
            // 
            this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.cboTurno.Location = new System.Drawing.Point(77, 59);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(121, 21);
            this.cboTurno.TabIndex = 3;
            // 
            // gpbFormaDePago
            // 
            this.gpbFormaDePago.Controls.Add(this.checkBox2);
            this.gpbFormaDePago.Location = new System.Drawing.Point(306, 219);
            this.gpbFormaDePago.Name = "gpbFormaDePago";
            this.gpbFormaDePago.Size = new System.Drawing.Size(235, 63);
            this.gpbFormaDePago.TabIndex = 10;
            this.gpbFormaDePago.TabStop = false;
            this.gpbFormaDePago.Text = "Adicional";
            // 
            // gpbFormaPago
            // 
            this.gpbFormaPago.Controls.Add(this.label1);
            this.gpbFormaPago.Controls.Add(this.comboBox1);
            this.gpbFormaPago.Controls.Add(this.rbtTarjeta);
            this.gpbFormaPago.Controls.Add(this.rbtEfectivo);
            this.gpbFormaPago.Location = new System.Drawing.Point(27, 219);
            this.gpbFormaPago.Name = "gpbFormaPago";
            this.gpbFormaPago.Size = new System.Drawing.Size(228, 63);
            this.gpbFormaPago.TabIndex = 11;
            this.gpbFormaPago.TabStop = false;
            this.gpbFormaPago.Text = " Pago";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(54, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(137, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Casillero ($3.000 / mes)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(15, 94);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(41, 13);
            this.lblMeses.TabIndex = 4;
            this.lblMeses.Text = "Meses:";
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(77, 90);
            this.txtMeses.MaxLength = 2;
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(27, 20);
            this.txtMeses.TabIndex = 5;
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Location = new System.Drawing.Point(40, 9);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbtEfectivo.TabIndex = 0;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            this.rbtTarjeta.AutoSize = true;
            this.rbtTarjeta.Location = new System.Drawing.Point(110, 9);
            this.rbtTarjeta.Name = "rbtTarjeta";
            this.rbtTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rbtTarjeta.TabIndex = 1;
            this.rbtTarjeta.TabStop = true;
            this.rbtTarjeta.Text = "Tarjeta";
            this.rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "3",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(137, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(42, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cantidad de Cuotas: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gpbDescuento
            // 
            this.gpbDescuento.Controls.Add(this.checkBox1);
            this.gpbDescuento.Controls.Add(this.checkBox3);
            this.gpbDescuento.Controls.Add(this.textBox1);
            this.gpbDescuento.Controls.Add(this.label2);
            this.gpbDescuento.Location = new System.Drawing.Point(27, 288);
            this.gpbDescuento.Name = "gpbDescuento";
            this.gpbDescuento.Size = new System.Drawing.Size(228, 134);
            this.gpbDescuento.TabIndex = 14;
            this.gpbDescuento.TabStop = false;
            this.gpbDescuento.Text = "¡Promo!";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(91, 90);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(76, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Estudiante";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 64);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(24, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad: ";
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 458);
            this.Controls.Add(this.gpbDescuento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbFormaPago);
            this.Controls.Add(this.gpbFormaDePago);
            this.Controls.Add(this.gpbPlan);
            this.Controls.Add(this.gpbDatosPersonales);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTItulo);
            this.Name = "frmInscripcion";
            this.Text = "  Gimnasio Siglo - Inscripcion";
            this.gpbDatosPersonales.ResumeLayout(false);
            this.gpbDatosPersonales.PerformLayout();
            this.gpbPlan.ResumeLayout(false);
            this.gpbPlan.PerformLayout();
            this.gpbFormaDePago.ResumeLayout(false);
            this.gpbFormaDePago.PerformLayout();
            this.gpbFormaPago.ResumeLayout(false);
            this.gpbFormaPago.PerformLayout();
            this.gpbDescuento.ResumeLayout(false);
            this.gpbDescuento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTItulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.GroupBox gpbDatosPersonales;
        private System.Windows.Forms.GroupBox gpbPlan;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.GroupBox gpbFormaDePago;
        private System.Windows.Forms.GroupBox gpbFormaPago;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton rbtTarjeta;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gpbDescuento;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

