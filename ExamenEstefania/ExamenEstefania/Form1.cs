using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ExamenEstefania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            // banquet o joranda desacativar habitaciones y numero de dias desactivar
            if (comboBox1.Items.Contains("Banquete") || comboBox1.Items.Contains("Jornada"))
            {
                // Numero de dias 
                textBox3.Visible = false;
                // y si titulo
                label9.Visible = false;

                DialogResult result = MessageBox.Show(
                    "¿Qué tipo de mesa quiere usar?", "Si la opcion es no se elegira mesa cuadrada por consiguiente",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Mesa redonda
                    MessageBox.Show("Has seleccionado mesa redonda.");
                }
                else if (result == DialogResult.No)
                {
                    // Mesa cuadrada
                    MessageBox.Show("Has seleccionado mesa cuadrada.");
                }

            }

            // desactivar mesa y numero de comensales congreso o joranda
            if (comboBox1.Items.Contains("Congreso") || comboBox1.Items.Contains("Jornada"))
            {
                // Numero de comensales
                textBox5.Visible = false;
                label6.Visible = false;
                // Numero de mesas 
                textBox2.Visible = false;
                label8.Visible = false;
                // Tipo de carta 
                comboBox2.Visible = false;
                label7.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userName = textBox1.Text;
            // Num de telefono
            var numeroDeTelefono = textBox4.Text;
            // Num de jornadas
            var numeroDeJornadas = textBox4.Text;
            // Num de personas
            var numeroDePersonas = textBox5.Text;
            // Num de mesas
            var numeroDeMesas = textBox2.Text;


            var regx = new Regex(@"^[a-zA-Z]+$");
            var regxNums = new Regex(@"^[0-9]+$");
            var resultName = regx.Match(userName);
            var resultTel = regx.Match(numeroDeTelefono);
            var resultElRestroDeTextBox = regx.Match(numeroDeTelefono);

            var resultJornadas = regx.Match(numeroDeJornadas);
            var resultPersonas = regx.Match(numeroDePersonas);
            var resultMesas = regx.Match(numeroDeMesas);

            if (!resultName.Success || !resultTel.Success)
            {
                MessageBox.Show("Nombre o numero de telefono invalido caracateres extraños");
                textBox1.Clear();
                textBox2.Clear();
                if (!resultJornadas.Success || !resultPersonas.Success || !resultMesas.Success)
                {
                    MessageBox.Show("Numeros en jornadas, personas o mesas. " +
                                    "Invalido caracateres extraños");
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
                
            }

            MessageBox.Show("Haz hecho una reserva!\n" + " A nombre de " + textBox1.Text
                                    + "\ntu numero de telefono " + textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cerrar = true;
            if (cerrar)
            {
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
