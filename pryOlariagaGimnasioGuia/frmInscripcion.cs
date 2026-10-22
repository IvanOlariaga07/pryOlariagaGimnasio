using System;
using System.Drawing;
using System.Windows.Forms;

namespace pryOlariagaGimnasioGuia
{
    public class frmInscripcion : Form
    {
        private const decimal PRECIO_MUSCULACION = 15000m, PRECIO_FUNCIONAL = 18000m, PRECIO_NATACION = 22000m;
        private const decimal PRECIO_CASILLERO = 3000m, DESCUENTO_ESTUDIANTE = 0.15m, DESCUENTO_MENOR = 0.25m, DESCUENTO_MAYOR = 0.30m;
        private const decimal DESCUENTO_EFECTIVO = 0.10m, RECARGO_3_CUOTAS = 0.10m, RECARGO_6_CUOTAS = 0.20m;
        private const int EDAD_MINIMA = 14, MESES_MINIMOS = 1, MESES_MAXIMOS = 12;

        public struct SOCIO { public string Nombre, Categoria, Plan, Horario, FormaPago; public int Edad, Meses; public decimal Total, ValorCuota; }

        private readonly TextBox txtNombre = new TextBox(), txtEdad = new TextBox(), txtMeses = new TextBox();
        private readonly CheckBox chkEstudiante = new CheckBox(), chkCasillero = new CheckBox();
        private readonly ComboBox cboPlan = new ComboBox(), cboTurno = new ComboBox(), cboCuotas = new ComboBox();
        private readonly RadioButton rbtEfectivo = new RadioButton(), rbtTarjeta = new RadioButton();
        private readonly Button btnCalcular = new Button(), btnLimpiar = new Button();

        public frmInscripcion()
        {
            Text = "Gimnasio Siglo - Inscripción"; StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle; MaximizeBox = false; ClientSize = new Size(470, 360);
            CrearInterfaz(); EstadoInicial(); AcceptButton = btnCalcular;
        }

        private void CrearInterfaz()
        {
            var titulo = new Label { Text = "Gimnasio Siglo - Inscripción", Font = new Font("Segoe UI", 16, FontStyle.Bold), Location = new Point(20, 15), AutoSize = true };
            Controls.Add(titulo);
            var datos = new GroupBox { Text = "Datos personales", Location = new Point(20, 55), Size = new Size(205, 125) };
            Agregar(datos, "Nombre:", txtNombre, 20, 25, 155); Agregar(datos, "Edad:", txtEdad, 20, 58, 55);
            chkEstudiante.Text = "Estudiante"; chkEstudiante.Location = new Point(85, 57); datos.Controls.Add(chkEstudiante); Controls.Add(datos);
            var plan = new GroupBox { Text = "Plan", Location = new Point(240, 55), Size = new Size(210, 125) };
            Agregar(plan, "Plan:", cboPlan, 20, 25, 170); Agregar(plan, "Turno:", cboTurno, 20, 58, 170); Agregar(plan, "Meses:", txtMeses, 20, 91, 55); Controls.Add(plan);
            var pago = new GroupBox { Text = "Forma de pago", Location = new Point(20, 190), Size = new Size(430, 95) };
            rbtEfectivo.Text = "Efectivo"; rbtEfectivo.Location = new Point(20, 25); rbtTarjeta.Text = "Tarjeta"; rbtTarjeta.Location = new Point(105, 25);
            pago.Controls.Add(rbtEfectivo); pago.Controls.Add(rbtTarjeta); Agregar(pago, "Cuotas:", cboCuotas, 205, 22, 70); chkCasillero.Text = "Casillero ($ 3.000/mes)"; chkCasillero.Location = new Point(20, 57); pago.Controls.Add(chkCasillero); Controls.Add(pago);
            btnCalcular.Text = "&Calcular"; btnCalcular.Location = new Point(250, 305); btnCalcular.Size = new Size(95, 30); btnLimpiar.Text = "&Limpiar"; btnLimpiar.Location = new Point(355, 305); btnLimpiar.Size = new Size(95, 30); Controls.Add(btnCalcular); Controls.Add(btnLimpiar);
            cboPlan.Items.AddRange(new object[] { "Musculación", "Funcional", "Natación" }); cboTurno.Items.AddRange(new object[] { "Mañana (7 a 12 h)", "Tarde (14 a 18 h)", "Noche (18 a 23 h)" }); cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            txtNombre.MaxLength = 30; txtEdad.MaxLength = 3; txtMeses.MaxLength = 2; foreach (var c in new ComboBox[] { cboPlan, cboTurno, cboCuotas }) c.DropDownStyle = ComboBoxStyle.DropDownList;
            txtNombre.KeyPress += Nombre_KeyPress; txtEdad.KeyPress += Numero_KeyPress; txtMeses.KeyPress += Numero_KeyPress; txtNombre.TextChanged += Datos_TextChanged; txtEdad.TextChanged += Datos_TextChanged; txtMeses.TextChanged += Datos_TextChanged;
            rbtTarjeta.CheckedChanged += Pago_CheckedChanged; rbtEfectivo.CheckedChanged += Pago_CheckedChanged; btnCalcular.Click += Calcular_Click; btnLimpiar.Click += (s, e) => EstadoInicial();
        }

        private static void Agregar(Control contenedor, string texto, Control control, int x, int y, int ancho)
        { var l = new Label { Text = texto, Location = new Point(x, y + 3), AutoSize = true }; control.Location = new Point(x + 58, y); control.Width = ancho - 58; contenedor.Controls.Add(l); contenedor.Controls.Add(control); }
        private void EstadoInicial() { txtNombre.Clear(); txtEdad.Clear(); txtMeses.Text = "1"; cboPlan.SelectedIndex = 0; cboTurno.SelectedIndex = 0; chkEstudiante.Checked = false; chkCasillero.Checked = false; rbtEfectivo.Checked = true; cboCuotas.SelectedIndex = -1; cboCuotas.Enabled = false; btnCalcular.Enabled = false; txtNombre.Focus(); }
        private void Nombre_KeyPress(object s, KeyPressEventArgs e) { if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back) e.Handled = true; else if (char.IsLower(e.KeyChar)) e.KeyChar = char.ToUpper(e.KeyChar); }
        private void Numero_KeyPress(object s, KeyPressEventArgs e) { if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true; }
        private void Datos_TextChanged(object s, EventArgs e) { btnCalcular.Enabled = !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtEdad.Text) && !string.IsNullOrWhiteSpace(txtMeses.Text); }
        private void Pago_CheckedChanged(object s, EventArgs e) { cboCuotas.Enabled = rbtTarjeta.Checked; if (rbtTarjeta.Checked && cboCuotas.SelectedIndex < 0) cboCuotas.SelectedIndex = 0; if (rbtEfectivo.Checked) cboCuotas.SelectedIndex = -1; }

        private void Calcular_Click(object s, EventArgs e)
        {
            int edad = int.Parse(txtEdad.Text), meses = int.Parse(txtMeses.Text); if (edad < EDAD_MINIMA) { MessageBox.Show("Debe tener al menos 14 años.", "Edad insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (meses < MESES_MINIMOS || meses > MESES_MAXIMOS) { MessageBox.Show("Los meses deben estar entre 1 y 12.", "Rango inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            decimal precioMensual; string plan = cboPlan.SelectedItem.ToString(); switch (plan) { case "Musculación": precioMensual = PRECIO_MUSCULACION; break; case "Funcional": precioMensual = PRECIO_FUNCIONAL; break; case "Natación": precioMensual = PRECIO_NATACION; break; default: return; }
            string horario; switch (cboTurno.SelectedIndex) { case 0: horario = "Mañana (7 a 12 h)"; break; case 1: horario = "Tarde (14 a 18 h)"; break; default: horario = "Noche (18 a 23 h)"; break; }
            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO; decimal subtotal = precioMensual * meses; decimal descuento = edad < 18 ? DESCUENTO_MENOR : (edad >= 65 ? DESCUENTO_MAYOR : (chkEstudiante.Checked ? DESCUENTO_ESTUDIANTE : 0m)); subtotal *= 1m - descuento;
            decimal ajuste = rbtEfectivo.Checked ? -DESCUENTO_EFECTIVO : (cboCuotas.Text == "3" ? RECARGO_3_CUOTAS : (cboCuotas.Text == "6" ? RECARGO_6_CUOTAS : 0m)); decimal total = subtotal * (1m + ajuste); int cuotas = rbtEfectivo.Checked ? 1 : int.Parse(cboCuotas.Text);
            SOCIO socio = new SOCIO { Nombre = txtNombre.Text, Edad = edad, Categoria = edad < 18 ? "Menor" : "Mayor", Plan = plan, Horario = horario, Meses = meses, FormaPago = rbtEfectivo.Checked ? "Efectivo" : "Tarjeta en " + cuotas + " cuotas", Total = total, ValorCuota = total / cuotas };
            MessageBox.Show("Socio: " + socio.Nombre + "\nEdad: " + socio.Edad + " años (" + socio.Categoria + ")\nPlan: " + socio.Plan + " - " + socio.Horario + "\nMeses: " + socio.Meses + "\nPago: " + socio.FormaPago + "\nTotal: " + socio.Total.ToString("C2") + "\nValor cuota: " + socio.ValorCuota.ToString("C2"), "Detalle de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information); EstadoInicial();
        }
    }
}
