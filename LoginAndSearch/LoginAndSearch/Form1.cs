using System.Windows.Forms;

namespace LoginAndSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Poder enlazar a la pagina del cide   
            BackColor = ColorTranslator.FromHtml("#EDEADE");
            label1.ForeColor = ColorTranslator.FromHtml("#1D9031");
            label2.ForeColor = ColorTranslator.FromHtml("#1D9031");
            button1.ForeColor = ColorTranslator.FromHtml("#1D9031");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // contraseña correcta
            string user = "admin";
            string passwordAdmin = "xxxxxx";
            if (textBox1.Text.Contains(user) && textBox2.Text.Contains(passwordAdmin))
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show(" Contraseña incorrectar ");
            }

        }
    }
}
