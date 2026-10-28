using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        struct SOCIO
        {
            // estructura para un socio (Agrupar datos)
            public string Nombre;
            public int Edad;
            public string Categoria;
            public string Plan;
            public string Horario;
            public int Meses;
            public string FormaPago;
            public decimal Total;
            public decimal ValorCuota;
        }

        private SOCIO[] registros = new SOCIO[10];
        private int cantidadRegistros = 0;


    

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cantidadRegistros == 0)
            {
                MessageBox.Show("Todavía no hay registros para consultar.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder consulta = new StringBuilder();

            for (int i = 0; i < cantidadRegistros; i++)
            {
                SOCIO socio = registros[i];

                consulta.AppendLine($"Registro {i + 1}");
                consulta.AppendLine($"Nombre: {socio.Nombre}");
                consulta.AppendLine($"Edad: {socio.Edad} años ({socio.Categoria})");
                consulta.AppendLine($"Plan: {socio.Plan}");
                consulta.AppendLine($"Turno: {socio.Horario}");
                consulta.AppendLine($"Meses: {socio.Meses}");
                consulta.AppendLine($"Forma de pago: {socio.FormaPago}");
                consulta.AppendLine($"Valor de cuota: {socio.ValorCuota:C2}");
                consulta.AppendLine($"Total: {socio.Total:C2}");
                consulta.AppendLine(new string('-', 35));
            }

            MessageBox.Show(consulta.ToString(), "Registros guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


            // Variable para almacenar el porcentaje de ajuste (descuento o recargo) por forma de pago
            decimal porcentajeAjustePago = 0m;

            if (rbtEfectivo.Checked)
            {
                porcentajeAjustePago = -0.10m; // 10% de descuento por efectivo
            }
            else // Si eligió Tarjeta
            {
                // Convertimos a entero las cuotas seleccionadas (1, 3 o 6)
                int cuotas = int.Parse(cboCuotas.Text);

                if (cuotas == 1)
                {
                    porcentajeAjustePago = 0m; // 1 cuota sin recargo
                }
                else if (cuotas == 3)
                {
                    porcentajeAjustePago = 0.10m; // 3 cuotas +10% de recargo
                }
                else if (cuotas == 6)
                {
                    porcentajeAjustePago = 0.20m; // 6 cuotas +20% de recargo
                }
            }

            // Aplicación del ajuste al total
            decimal total = subtotal * (1 + porcentajeAjustePago);

            //  Operador ternario para la categoría del socio
            string categoria = (edad < 18) ? "Menor" : "Mayor";

            //  Texto de forma de pago
            string textoFormaPago = rbtEfectivo.Checked ? "Efectivo" : $"Tarjeta en {cboCuotas.Text} cuotas";

            //  Valor de la cuota
            int cantidadCuotas = rbtEfectivo.Checked ? 1 : int.Parse(cboCuotas.Text);
            decimal valorCuota = rbtEfectivo.Checked ? total : (total / cantidadCuotas);


            
            // 1. Instanciar y cargar los datos en la variable de estructura
            SOCIO socioActual;
            socioActual.Nombre = txtNombre.Text;
            socioActual.Edad = edad;
            socioActual.Categoria = categoria;         // Obtenido con el ternario
            socioActual.Plan = planSeleccionado;       // Obtenido con el switch
            socioActual.Horario = horario;                   // Obtenido con el switch
            socioActual.Meses = meses;
            socioActual.FormaPago = textoFormaPago;     // Obtenido con el ternario
            socioActual.Total = total;
            socioActual.ValorCuota = valorCuota;       // Obtenido con el ternario

            // Guardar el socio en el arreglo. Si se alcanza la capacidad,
            // se duplica para poder continuar registrando inscripciones.
            if (cantidadRegistros == registros.Length)
            {
                Array.Resize(ref registros, registros.Length * 2);
            }

            registros[cantidadRegistros] = socioActual;
            cantidadRegistros++;

            // Mostrar un resumen de cada inscripción en el ListBox.
            lstRegistro.Items.Add(
                $"Nombre: {socioActual.Nombre} | " +
                $"Edad: {socioActual.Edad} ({socioActual.Categoria}) | " +
                $"Plan: {socioActual.Plan} | " +
                $"Turno: {horario} | " +
                $"Meses: {socioActual.Meses} | " +
                $"{socioActual.FormaPago} | " +
                $"Cuota: {socioActual.ValorCuota:C2} | " +
                $"Total: {socioActual.Total:C2}");

            // 2. Armar la cadena de texto con el formato solicitado
            string resumen = $"Resumen de Inscripción\n" +
                             $"------------------------------------\n" +
                             $"Socio: {socioActual.Nombre}\n" +
                             $"Edad: {socioActual.Edad} años ({socioActual.Categoria})\n" +
                             $"Plan: {socioActual.Plan} ({socioActual.Horario})\n" +
                             $"Duración: {socioActual.Meses} mes(es)\n" +
                             $"Forma de Pago: {socioActual.FormaPago}\n\n" +
                             $"Total a Pagar: {socioActual.Total:C2}\n" +
                             $"Valor por Cuota: {socioActual.ValorCuota:C2}";

            // 3. Mostrar el cuadro de diálogo emergente
            MessageBox.Show(resumen, "Detalle de Liquidación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            // 4. Reiniciar el formulario
            EstadoInicial();
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

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                cboCuotas.Enabled = true;
            }
        }
    }
}
