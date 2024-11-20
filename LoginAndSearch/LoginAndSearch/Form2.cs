using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndSearch
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml("#EDEADE");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            listBox1.BackColor = ColorTranslator.FromHtml("#EDEADE");
            label1.ForeColor = ColorTranslator.FromHtml("#1D9031");
            label2.ForeColor = ColorTranslator.FromHtml("#1D9031");
            List<String> nombresLista = new List<string>()
            {
                "pepe",
                "joselu",
                "miguel"
            };
            foreach (string nombre in nombresLista)
            {
                listBox1.Items.Add(nombre);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nombreBuscado = textBox1.Text.Trim(); // Eliminar espacios al inicio y al final

            if (string.IsNullOrEmpty(nombreBuscado))
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }

            int index = FindMyStringInList(nombreBuscado);

            if (index != -1)
            {
                Form3 form3 = new Form3(nombreBuscado);

                form3.Show();
            }
            else
            {
                MessageBox.Show("Name not found. Please try again.");
            }
        }

        private int FindMyStringInList(string nombre)
        {
            // Buscar en listBox1 si el nombre existe
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string listaDeNombres = listBox1.Items[i].ToString();
                if (listaDeNombres.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return i; // Devuelve el índice si el nombre es encontrado
                }
            }
            return -1; // Si el nombre no es encontrado
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var (nombre, apellido) = Prompt.ShowDialog("Add Name and Last Name");
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido))
            {
                string nombreCompleto = $"{nombre} {apellido}";
                listBox1.Items.Add(nombreCompleto);
            }
            else
            {
                MessageBox.Show("Both Name and Last Name are required.");
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public static class Prompt
        {
            public static (string Nombre, string Apellido) ShowDialog(string caption)
            {
                Form prompt = new Form()
                {
                    Width = 400,
                    Height = 250,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label nameLabel = new Label() { Left = 20, Top = 20, Text = "Name:", Width = 100 };
                TextBox nameBox = new TextBox() { Left = 120, Top = 20, Width = 250 };

                Label lastNameLabel = new Label() { Left = 20, Top = 60, Text = "Last Name:", Width = 100 };
                TextBox lastNameBox = new TextBox() { Left = 120, Top = 60, Width = 250 };

                Button confirmation = new Button() { Text = "OK", Left = 150, Width = 100, Top = 120, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(nameLabel);
                prompt.Controls.Add(nameBox);
                prompt.Controls.Add(lastNameLabel);
                prompt.Controls.Add(lastNameBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                if (prompt.ShowDialog() == DialogResult.OK)
                {
                    return (nameBox.Text, lastNameBox.Text);
                }
                return (string.Empty, string.Empty);
            }
        }

    }
}
