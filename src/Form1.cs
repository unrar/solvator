using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solvator
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

        private void button1_Click(object sender, EventArgs e)
        {
            InputForm finalForm = new InputForm("Punto Inicial", "Componentes Vector", 1);
            finalForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputForm inicialForm = new InputForm("Punto final", "Componentes Vector", 2);
            inicialForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputForm vectorForm = new InputForm("Punto final", "Punto inicial", 3);
            vectorForm.Show();
        }
    }
}
