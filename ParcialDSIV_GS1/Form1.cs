using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialDSIV_GS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MostrarPanel(pnlBienvenida);
            pbPortada.Image = Properties.Resources.math;
        }
        // Estado del juego 
        private string jugadorNombre = "";
        private string colorFavorito = "";
        private string animalElegido = "";
        private bool modoDificil = false;

        private int energiaMax = 100;
        private int energiaActual = 100;

        private int rondaActual = 1;            
        private int intentosRestantes = 3;      
        private int num1, num2;

        private const int TOTAL_RONDAS = 5;
        private const int INTENTOS_POR_OP = 3;
        private const int PENALIZACION = 25;

        private Random rng = new Random();


        
        private void MostrarPanel(Panel destino)
        {
            pnlRegistro.Visible = false;
            pnlJuego.Visible = false;
            pnlReto.Visible = false;
            pnlFinal.Visible = false;
            
            if (destino == pnlFinal)
                this.Size = new Size(900, 450);
            else if (destino == pnlBienvenida)
                this.Size = new Size(1100, 720);
            else
                this.Size = new Size(800, 600);
            destino.Visible = true;
            destino.BringToFront();
        }


        // Eventos de Bienvenida 
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            MostrarPanel(pnlRegistro);
            txtNombre.Focus();
        }

        // Registro Juego
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (!ValidarRegistro()) return;
            InicializarJuego();
            MostrarPanel(pnlJuego);
            GenerarOperacion();
            ActualizarCabeceraOperacion();
            txtRespuesta.Focus();
        }

        private bool ValidarRegistro()
        {
            jugadorNombre = (txtNombre.Text ?? "").Trim();
            if (string.IsNullOrEmpty(jugadorNombre))
            {
                MessageBox.Show("Ingrese el nombre del jugador.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (cboColorFavorito.SelectedIndex < 0 || cboColorFavorito.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un color favorito.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboColorFavorito.Focus();
                return false;
            }
            colorFavorito = cboColorFavorito.SelectedItem.ToString();

            if (!rdbEnergiaAlta.Checked && !rdbEnergiaMedia.Checked && !rdbEnergiaBaja.Checked)
            {
                MessageBox.Show("Seleccione un nivel de energía inicial.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rdbEnergiaAlta.Focus();
                return false;
            }

            modoDificil = chkModoDificil.Checked;

            if (rdbEnergiaAlta.Checked) energiaMax = 100;
            else if (rdbEnergiaMedia.Checked) energiaMax = 50;
            else energiaMax = 25;

            energiaActual = energiaMax;
            return true;
        }

        private void InicializarJuego()
        {
            pgbEnergia.Minimum = 0;
            pgbEnergia.Maximum = energiaMax;
            pgbEnergia.Value = energiaMax;

            rondaActual = 1;
            intentosRestantes = INTENTOS_POR_OP;
            lblIntentos.Text = $"Intentos restantes: {intentosRestantes}";
        }

       // Lógica de operaciones
        private void GenerarOperacion()
        {
            int a = modoDificil ? 2 : 1;
            int b = modoDificil ? 12 : 9;

            num1 = rng.Next(a, b + 1);
            num2 = rng.Next(a, b + 1);

            lblNum1.Text = num1.ToString();
            lblSigno.Text = modoDificil ? "×" : "+";
            lblNum2.Text = num2.ToString();

            intentosRestantes = INTENTOS_POR_OP;
            lblIntentos.Text = $"Intentos restantes: {intentosRestantes}";
            txtRespuesta.Clear();
        }

        private void ActualizarCabeceraOperacion()
        {
            lblOperacionTitulo.Text = $"Ronda {rondaActual} de {TOTAL_RONDAS}";
        }

        private int ResultadoEsperado()
        {
            return modoDificil ? (num1 * num2) : (num1 + num2);
        }

        private void PenalizarEnergia()
        {
            energiaActual = Math.Max(0, energiaActual - PENALIZACION);
            pgbEnergia.Value = Math.Min(energiaActual, pgbEnergia.Maximum);

            if (energiaActual == 0)
            {
                MessageBox.Show("Game Over: te quedaste sin energía.", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IrAReto();
            }
        }

        // Eventos del Juego 
        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse((txtRespuesta.Text ?? "").Trim(), out int respuesta))
            {
                MessageBox.Show("Ingrese un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRespuesta.Focus();
                txtRespuesta.SelectAll();
                return;
            }

            int esperado = ResultadoEsperado();
            if (respuesta == esperado)
            {
                MessageBox.Show("¡Correcto!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (rondaActual < TOTAL_RONDAS)
                {
                    rondaActual++;
                    ActualizarCabeceraOperacion();
                    GenerarOperacion();
                    txtRespuesta.Focus();
                }
                else
                {
                    IrAReto();
                }
            }
            else
            {
                MessageBox.Show("Incorrecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentosRestantes--;
                lblIntentos.Text = $"Intentos restantes: {intentosRestantes}";
                PenalizarEnergia();
                if (energiaActual == 0) return; // ya se navegó al reto

                if (intentosRestantes <= 0)
                {
                    if (rondaActual < TOTAL_RONDAS)
                    {
                        rondaActual++;
                        ActualizarCabeceraOperacion();
                        GenerarOperacion();
                        txtRespuesta.Focus();
                    }
                    else
                    {
                        IrAReto();
                    }
                }
                else
                {
                    txtRespuesta.SelectAll();
                    txtRespuesta.Focus();
                }
            }
        }



        //  Navegación a Reto
        private void IrAReto()
        {
            lstAnimales.ClearSelected();
            lblResultadoReto.Text = "—";
            MostrarPanel(pnlReto);
            lstAnimales.Focus();
        }

        // Eventos del Reto
        private async void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (lstAnimales.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un animal.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lstAnimales.Focus();
                return;
            }

            animalElegido = lstAnimales.SelectedItem.ToString();
            string compacto = animalElegido.Replace(" ", "");
            string mensajeAnimal = compacto.Length > 5 ? "Ese animal es poderoso" : "Ese animal es ágil";
            lblResultadoReto.Text = mensajeAnimal;

            
            // Llenar panel final
            lblFinalJugador.Text = $"Jugador: {jugadorNombre}";
            lblFinalAnimal.Text = $"Animal: {animalElegido}";
            lblFinalMensaje.Text = $"Mensaje: {mensajeAnimal}";
            lblFinalColor.Text = $"Color favorito: {colorFavorito}";
            if (colorFavorito.ToLower() == "rojo")
                lblFinalColor.ForeColor = Color.Red;
            else if (colorFavorito.ToLower() == "azul")
                lblFinalColor.ForeColor = Color.Blue;
            else if (colorFavorito.ToLower() == "verde")
                lblFinalColor.ForeColor = Color.Green;
            else if (colorFavorito.ToLower() == "amarillo")
                lblFinalColor.ForeColor = Color.Goldenrod;
            else
                lblFinalColor.ForeColor = Color.Black;
            lblFinalEnergia.Text = $"Energía final: {energiaActual}/{energiaMax}";
            lblMensajeDivertido.Text = energiaActual == energiaMax ? $"Cálculos completados. Sistema detecta un genio llamado {jugadorNombre}." :
                                        energiaActual >= energiaMax / 2 ? "Aunque tu energía bajó, tu espíritu de jugador sigue al 100%" : "Error 404: Energía agotada, pero estilo intacto";
            if (animalElegido.ToLower().Equals("perro"))
                pbAnimal.Image = Properties.Resources.perros;
            else if (animalElegido.ToLower().Contains("gato"))
                pbAnimal.Image = Properties.Resources.gatos;
            else if (animalElegido.ToLower().Contains("ratón"))
                pbAnimal.Image = Properties.Resources.ratones;
            else if (animalElegido.ToLower().Contains("elefante"))
                pbAnimal.Image = Properties.Resources.elefantes;
            else if (animalElegido.ToLower().Contains("león"))
                pbAnimal.Image = Properties.Resources.leones;

            Task.Delay(2000).Wait(); // Esperar 2 segundos para que el usuario vea el mensaje

            MostrarPanel(pnlFinal);
        }

        private void lstAnimales_DoubleClick(object sender, EventArgs e)
        {
            if (lstAnimales.SelectedItem != null)
                btnSeleccionar.PerformClick();
        }

        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {

            jugadorNombre = "";
            colorFavorito = "";
            animalElegido = "";
            modoDificil = false;
            energiaMax = 100;
            energiaActual = 100;
            rondaActual = 1;


            txtNombre.Clear();
            rdbEnergiaAlta.Checked = true;
            rdbEnergiaMedia.Checked = false;
            rdbEnergiaBaja.Checked = false;
            chkModoDificil.Checked = false;
            if (cboColorFavorito.Items.Count > 0) cboColorFavorito.SelectedIndex = 0;

            MostrarPanel(pnlBienvenida);
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enter para continuar desde registro
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnContinuar.PerformClick();
            }
        }



    }
}
