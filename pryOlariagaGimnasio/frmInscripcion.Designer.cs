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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcion));
            this.lblTItulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.gpbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.chkEstudiante = new System.Windows.Forms.CheckBox();
            this.gpbPlan = new System.Windows.Forms.GroupBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.gpbFormaDePago = new System.Windows.Forms.GroupBox();
            this.chkCasillero = new System.Windows.Forms.CheckBox();
            this.gpbFormaPago = new System.Windows.Forms.GroupBox();
            this.lblCantidadCuotas = new System.Windows.Forms.Label();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.rbtTarjeta = new System.Windows.Forms.RadioButton();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpbDescuento = new System.Windows.Forms.GroupBox();
            this.lblDescuento3 = new System.Windows.Forms.Label();
            this.lblDescuento2 = new System.Windows.Forms.Label();
            this.lblDescuento1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbDatosPersonales.SuspendLayout();
            this.gpbPlan.SuspendLayout();
            this.gpbFormaDePago.SuspendLayout();
            this.gpbFormaPago.SuspendLayout();
            this.gpbDescuento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTItulo
            // 
            this.lblTItulo.AutoSize = true;
            this.lblTItulo.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTItulo.Location = new System.Drawing.Point(31, 9);
            this.lblTItulo.Name = "lblTItulo";
            this.lblTItulo.Size = new System.Drawing.Size(203, 62);
            this.lblTItulo.TabIndex = 0;
            this.lblTItulo.Text = "Gimnasio Siglo";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(88, 55);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(77, 16);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Inscripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(49, 70);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 37);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(81, 67);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(24, 20);
            this.txtEdad.TabIndex = 1;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // gpbDatosPersonales
            // 
            this.gpbDatosPersonales.Controls.Add(this.chkEstudiante);
            this.gpbDatosPersonales.Controls.Add(this.txtEdad);
            this.gpbDatosPersonales.Controls.Add(this.txtNombre);
            this.gpbDatosPersonales.Controls.Add(this.lblEdad);
            this.gpbDatosPersonales.Controls.Add(this.lblNombre);
            this.gpbDatosPersonales.Location = new System.Drawing.Point(27, 79);
            this.gpbDatosPersonales.Name = "gpbDatosPersonales";
            this.gpbDatosPersonales.Size = new System.Drawing.Size(228, 134);
            this.gpbDatosPersonales.TabIndex = 0;
            this.gpbDatosPersonales.TabStop = false;
            this.gpbDatosPersonales.Text = "Datos Personales";
            // 
            // chkEstudiante
            // 
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.Location = new System.Drawing.Point(52, 94);
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.Size = new System.Drawing.Size(76, 17);
            this.chkEstudiante.TabIndex = 4;
            this.chkEstudiante.Text = "Estudiante";
            this.chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // gpbPlan
            // 
            this.gpbPlan.Controls.Add(this.txtMeses);
            this.gpbPlan.Controls.Add(this.lblMeses);
            this.gpbPlan.Controls.Add(this.cboTurno);
            this.gpbPlan.Controls.Add(this.lblTurno);
            this.gpbPlan.Controls.Add(this.lblPlan);
            this.gpbPlan.Controls.Add(this.cboPlan);
            this.gpbPlan.Location = new System.Drawing.Point(300, 138);
            this.gpbPlan.Name = "gpbPlan";
            this.gpbPlan.Size = new System.Drawing.Size(233, 134);
            this.gpbPlan.TabIndex = 2;
            this.gpbPlan.TabStop = false;
            this.gpbPlan.Text = "Plan";
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(77, 90);
            this.txtMeses.MaxLength = 2;
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(27, 20);
            this.txtMeses.TabIndex = 3;
            this.txtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeses_KeyPress);
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
            this.cboTurno.TabIndex = 2;
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
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(22, 31);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(34, 13);
            this.lblPlan.TabIndex = 1;
            this.lblPlan.Text = "Plan: ";
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
            // gpbFormaDePago
            // 
            this.gpbFormaDePago.Controls.Add(this.chkCasillero);
            this.gpbFormaDePago.Location = new System.Drawing.Point(300, 288);
            this.gpbFormaDePago.Name = "gpbFormaDePago";
            this.gpbFormaDePago.Size = new System.Drawing.Size(235, 63);
            this.gpbFormaDePago.TabIndex = 3;
            this.gpbFormaDePago.TabStop = false;
            this.gpbFormaDePago.Text = "Adicional";
            // 
            // chkCasillero
            // 
            this.chkCasillero.AutoSize = true;
            this.chkCasillero.Location = new System.Drawing.Point(54, 19);
            this.chkCasillero.Name = "chkCasillero";
            this.chkCasillero.Size = new System.Drawing.Size(137, 17);
            this.chkCasillero.TabIndex = 0;
            this.chkCasillero.Text = "Casillero ($3.000 / mes)";
            this.chkCasillero.UseVisualStyleBackColor = true;
            // 
            // gpbFormaPago
            // 
            this.gpbFormaPago.Controls.Add(this.lblCantidadCuotas);
            this.gpbFormaPago.Controls.Add(this.cboCuotas);
            this.gpbFormaPago.Controls.Add(this.rbtTarjeta);
            this.gpbFormaPago.Controls.Add(this.rbtEfectivo);
            this.gpbFormaPago.Location = new System.Drawing.Point(27, 219);
            this.gpbFormaPago.Name = "gpbFormaPago";
            this.gpbFormaPago.Size = new System.Drawing.Size(228, 63);
            this.gpbFormaPago.TabIndex = 4;
            this.gpbFormaPago.TabStop = false;
            this.gpbFormaPago.Text = " Pago";
            // 
            // lblCantidadCuotas
            // 
            this.lblCantidadCuotas.AutoSize = true;
            this.lblCantidadCuotas.Location = new System.Drawing.Point(25, 39);
            this.lblCantidadCuotas.Name = "lblCantidadCuotas";
            this.lblCantidadCuotas.Size = new System.Drawing.Size(106, 13);
            this.lblCantidadCuotas.TabIndex = 12;
            this.lblCantidadCuotas.Text = "Cantidad de Cuotas: ";
            // 
            // cboCuotas
            // 
            this.cboCuotas.FormattingEnabled = true;
            this.cboCuotas.Items.AddRange(new object[] {
            "1",
            "3",
            "6"});
            this.cboCuotas.Location = new System.Drawing.Point(137, 36);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(42, 21);
            this.cboCuotas.TabIndex = 2;
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
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(300, 371);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(403, 371);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpbDescuento
            // 
            this.gpbDescuento.Controls.Add(this.lblDescuento3);
            this.gpbDescuento.Controls.Add(this.lblDescuento2);
            this.gpbDescuento.Controls.Add(this.lblDescuento1);
            this.gpbDescuento.Location = new System.Drawing.Point(27, 288);
            this.gpbDescuento.Name = "gpbDescuento";
            this.gpbDescuento.Size = new System.Drawing.Size(228, 134);
            this.gpbDescuento.TabIndex = 5;
            this.gpbDescuento.TabStop = false;
            this.gpbDescuento.Text = "¡Promo!";
            // 
            // lblDescuento3
            // 
            this.lblDescuento3.AutoSize = true;
            this.lblDescuento3.Location = new System.Drawing.Point(25, 38);
            this.lblDescuento3.Name = "lblDescuento3";
            this.lblDescuento3.Size = new System.Drawing.Size(146, 13);
            this.lblDescuento3.TabIndex = 2;
            this.lblDescuento3.Text = "- Si sos Estudiante (15% OFF)";
            // 
            // lblDescuento2
            // 
            this.lblDescuento2.AutoSize = true;
            this.lblDescuento2.Location = new System.Drawing.Point(25, 93);
            this.lblDescuento2.Name = "lblDescuento2";
            this.lblDescuento2.Size = new System.Drawing.Size(134, 13);
            this.lblDescuento2.TabIndex = 1;
            this.lblDescuento2.Text = "- 65 años o mas (30% OFF)";
            // 
            // lblDescuento1
            // 
            this.lblDescuento1.AutoSize = true;
            this.lblDescuento1.Location = new System.Drawing.Point(25, 67);
            this.lblDescuento1.Name = "lblDescuento1";
            this.lblDescuento1.Size = new System.Drawing.Size(162, 13);
            this.lblDescuento1.TabIndex = 0;
            this.lblDescuento1.Text = "- Menores de 18 años (25% OFF)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmInscripcion
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbDescuento);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbFormaPago);
            this.Controls.Add(this.gpbFormaDePago);
            this.Controls.Add(this.gpbPlan);
            this.Controls.Add(this.gpbDatosPersonales);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTItulo);
            this.Name = "frmInscripcion";
            this.Text = "  Gimnasio Siglo - Inscripcion";
            this.Load += new System.EventHandler(this.frmInscripcion_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.GroupBox gpbFormaDePago;
        private System.Windows.Forms.GroupBox gpbFormaPago;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.CheckBox chkCasillero;
        private System.Windows.Forms.RadioButton rbtTarjeta;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.Label lblCantidadCuotas;
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpbDescuento;
        private System.Windows.Forms.Label lblDescuento3;
        private System.Windows.Forms.Label lblDescuento2;
        private System.Windows.Forms.Label lblDescuento1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkEstudiante;
    }
}

