using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOlariagaGimnasio
{
    public partial class frmInscripcion : Form
    {

        const decimal PRECIO_MUSCULACION = 15000;
        const decimal PRECIO_FUNCIONAL = 18000;
        const decimal PRECIO_NATACION = 20000;
        const int EDAD_MINIMA = 14;
        const decimal DESCUENTO_ESTUDIANTE = 0.15m;
        const decimal DESCUENTO_MENOR = 0.25m;
        const decimal DESCUENTO_MAYOR = 0.30m;
        const decimal RECARGO_3CUOTAS = 0.10m;
        const decimal RECARGO_6CUOTAS = 0.20m;
        const decimal PRECIO_CASILLERO = 3000;
        


        public frmInscripcion()
        {
            InitializeComponent();
        }


        private void EstadoInicial()
        {

            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;




        }





        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);
            //validacion de datos
            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("Debe tener al menos 14 años para inscribirse.", "Edad insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.", "Rango inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //calculo del precio base
            decimal precioMensual = 0m;
            string planSeleccionado = cboPlan.SelectedItem.ToString();

            switch (planSeleccionado)
            {
                case "Musculación":
                    precioMensual = PRECIO_MUSCULACION; // Precio: 15000
                    break;

                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL; // Precio: 18000
                    break;

                case "Natación":
                    precioMensual = PRECIO_NATACION; // Precio: 22000
                    break;

                default:
                    MessageBox.Show("Seleccione un plan válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            //Horario segun el turno
            string horario = "";
            int turnoSeleccionado = cboTurno.SelectedIndex;

            switch (turnoSeleccionado)
            {
                case 0: // Mañana
                    horario = "Mañana (7 a 12 h)";
                    break;

                case 1: // Tarde
                    horario = "Tarde (14 a 18 h)";
                    break;

                case 2: // Noche
                    horario = "Noche (18 a 23 h)";
                    break;

                default:
                    horario = "No especificado";
                    break;
            }

            if (chkCasillero.Checked)
            {
                precioMensual += PRECIO_CASILLERO;
            }
            decimal subtotal = precioMensual * meses; //subtotal base (plan + casillero)


            if (edad < 18 )
            {
                subtotal *= 0.75m; // Aplicar descuento del 25% para menores de 18 años
            }

        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;

            }


            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {


            btnCalcular.Enabled = !string.IsNullOrWhiteSpace(txtNombre.Text)
                                 && !string.IsNullOrWhiteSpace(txtEdad.Text)
                                 && !string.IsNullOrWhiteSpace(txtMeses.Text);
        }
    }
}
