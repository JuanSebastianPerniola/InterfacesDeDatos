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
    public partial class Form3 : Form
    {
        public Form3(string nombreBuscado)
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml("#EDEADE");
            label1.ForeColor = ColorTranslator.FromHtml("#1D9031");
            label2.ForeColor = ColorTranslator.FromHtml("#1D9031");
            label1.Text = nombreBuscado;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        // añadir que se vea el nombre de la persona que se busque
    }
}
