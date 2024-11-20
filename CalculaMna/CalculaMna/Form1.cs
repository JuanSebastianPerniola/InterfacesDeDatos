using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CalculaMna
{
    public partial class Form1 : Form
    {
        private string cronometro;
        private Stopwatch stopwatch;
        private Random random;
        private int numero1A, numero1B, numero2A, numero2B, numero3A, numero3B, numero4A, numero4B;
        private readonly int duracionMinutos = 2;
        private bool juegoTerminado = false;
        public Form1()
        {
            InitializeComponent();
            cronometro = "";
            stopwatch = new Stopwatch();
            random = new Random();
            GenerarNumerosAleatorios();
            timer1.Start();
            stopwatch.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoTranscurrido = stopwatch.Elapsed;
            TimeSpan tiempoRestante = TimeSpan.FromMinutes(duracionMinutos) - tiempoTranscurrido;
            cronometro = String.Format("{0:00}:{1:00}",
                                        tiempoTranscurrido.Minutes,
                                        tiempoTranscurrido.Seconds);

            label1.Text = cronometro;

            if (tiempoRestante <= TimeSpan.FromMinutes(0.1))
            {
                timer1.Stop();
                stopwatch.Stop();
                EndGameTimeEnd();
            }
        }

        private void GenerarNumerosAleatorios()
        {
            numero1A = random.Next(1, 100);
            numero1B = random.Next(1, 100);
            numero2A = random.Next(1, 100);
            numero2B = random.Next(1, 100);
            numero3A = random.Next(1, 100);
            numero3B = random.Next(1, 100);
            numero4A = random.Next(1, 100);
            numero4B = random.Next(1, 100);

            // Muestra los números en los labels correspondientes
            numeroSumA.Text = numero1A.ToString();
            numeroSumB.Text = numero1B.ToString();
            numeroSumC.Text = numero2A.ToString();
            numeroSumD.Text = numero2B.ToString();
            numeroSumE.Text = numero3A.ToString();
            sumNumD.Text = numero3B.ToString();
            sumNumF.Text = numero4A.ToString();
            a.Text = numero4B.ToString();
        }

        private void CheckResult()
        {
            if (juegoTerminado) return;

            // Verifica si hay campos vacíos
            if (string.IsNullOrWhiteSpace(reslSum.Text) ||
                string.IsNullOrWhiteSpace(reslResta.Text) ||
                string.IsNullOrWhiteSpace(reslMulti.Text) ||
                string.IsNullOrWhiteSpace(reslDiv.Text))
            {
                MessageBox.Show("Some fields are empty, so it would not be fair to judge you");
                DialogResult diagoE = MessageBox.Show("Do you wanna play again?", "Play Again", MessageBoxButtons.YesNo);
                if (diagoE == DialogResult.Yes)
                {
                    ReiniciarJuego();
                }
                else
                {
                    MessageBox.Show("Thanks for playing");
                    juegoTerminado = true;
                    this.Close();
                }
                return; // Detener ejecución para evitar que se repita el mensaje
            }

            // Cálculo de resultados
            int resultadoSuma = numero1A + numero1B;
            int resultadoResta = numero2A - numero2B;
            int resultadoMultiplicacion = numero3A * numero3B;
            int resultadoDivision = numero4B != 0 ? numero4A / numero4B : 0;

            List<String> mensajesCorrectos = new List<String>();
            List<String> mensajesIncorrectos = new List<String>();

            // Verifica los resultados ingresados por el usuario
            VerificarResultado(reslSum, resultadoSuma, "plus", mensajesCorrectos, mensajesIncorrectos);
            VerificarResultado(reslResta, resultadoResta, "less", mensajesCorrectos, mensajesIncorrectos);
            VerificarResultado(reslMulti, resultadoMultiplicacion, "multiply", mensajesCorrectos, mensajesIncorrectos);
            VerificarResultado(reslDiv, resultadoDivision, "divide", mensajesCorrectos, mensajesIncorrectos);

            String mensajeFinal = "";

            if (mensajesCorrectos.Count > 0)
            {
                mensajeFinal += "Correct Answers:\n" + string.Join("\n", mensajesCorrectos) + "\n";
            }
            if (mensajesIncorrectos.Count > 0)
            {
                mensajeFinal += "Wrong Answers:\n" + string.Join("\n", mensajesIncorrectos) + "\n";
            }

            MessageBox.Show(mensajeFinal);

            DialogResult diagoR = MessageBox.Show("Do you wanna play again?", "Play Again", MessageBoxButtons.YesNo);
            if (diagoR == DialogResult.Yes)
            {
                ReiniciarJuego();
            }
            else
            {
                MessageBox.Show("Thanks for playing");
                juegoTerminado = true;
                this.Close();
            }
        }


        private void VerificarResultado(TextBox textBox, int resultadoEsperado, string operacion, List<string> mensajesCorrectos, List<string> mensajesIncorrectos)
        {
            if (int.TryParse(textBox.Text, out int resultadoIngresado) && resultadoIngresado == resultadoEsperado)
            {
                mensajesCorrectos.Add($"The {operacion} is correct");
            }
            else
            {
                mensajesCorrectos.Add($"The {operacion} is incorrect");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CheckResult();
        }
        private void ReiniciarJuego()
        {
            reslSum.Clear();
            reslResta.Clear();
            reslMulti.Clear();
            reslDiv.Clear();
            GenerarNumerosAleatorios();
        }
        private void EndGameTimeEnd()
        {
            if (!juegoTerminado)
            {
                juegoTerminado = true;
                reslSum.Enabled = false;
                reslResta.Enabled = false;
                reslMulti.Enabled = false;
                reslDiv.Enabled = false;
                button1.Enabled = false;
                CheckResult();
                MessageBox.Show("Time is over; only the submitted answers will be checked.", "The end of the game");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
