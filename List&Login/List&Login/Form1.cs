using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace List_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Type of user
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            var userLastName = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dont add base in the enter button
            // It can take to erros 

            var userName = textBox1.Text;
            var userLastName = textBox2.Text;

            var valueText = string.Empty;

            // Verificamos que solo haya letras
            var regx = new Regex(@"^[a-zA-Z]+$");
            var resultName = regx.Match(userName);
            var resultLastName = regx.Match(userLastName);

            // Check if is text
            if (!resultName.Success || !resultLastName.Success)
            {
                MessageBox.Show("Nombre o apellido invalido caracateres extraños");
                textBox1.Clear();
                textBox2.Clear();
            }

            if (comboBox1.Items.Equals("User") )
            {
                textBox4.Text += Environment.NewLine + "\n" + "- " + userName + userLastName
                                    + "\n";
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                textBox3.Text += Environment.NewLine + "- " + userName + userLastName
                                   + "\n";
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var buttonclicked = true;
            if (buttonclicked)
            {
                Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
