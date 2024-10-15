using Microsoft.VisualBasic;

namespace SueldoCalculaor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Iniciamos variables
                float horas = float.Parse(textBox2.Text);
                float precioHora = float.Parse(textBox1.Text);
                float total = horas * precioHora;
                DialogResult result = MessageBox.Show("El total a recibir es: $" + total.ToString() + "Resultado");

                if (result == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese valores válidos " );
            }
        }
    }
}
