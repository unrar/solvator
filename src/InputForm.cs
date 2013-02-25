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
    public partial class InputForm : Form
    {
        private String lab1, lab2;
        private int tipo;

        /// <summary>
        /// Inicializa el formulario
        /// </summary>
        /// <param name="l1t">Texto de la primera etiqueta</param>
        /// <param name="l2t">Texto de la segunda etiqueta</param>
        /// <param name="tipo">Tipo de operación. 1 = F?; 2 = I?; 3 = V?</param>
        public InputForm(String l1t, String l2t, int tipo)
        {
            this.lab1 = l1t;
            this.lab2 = l2t;
            this.tipo = tipo;
            InitializeComponent();
            label1.Text = this.lab1;
            label2.Text = this.lab2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (this.tipo)
            {
                case 1:
                    // F = I - V
                    // Separamos los números en un array
                    string[] titokens = text1.Text.Split(' ');
                    string[] tvtokens = text2.Text.Split(' ');
                    int[] itokens = Array.ConvertAll<string, int>(titokens, int.Parse);
                    int[] vtokens = Array.ConvertAll<string, int>(tvtokens, int.Parse);

                    // Sumamos las coordenadas
                    int coord1 = itokens[0] + vtokens[0];
                    int coord2 = itokens[1] + vtokens[1];

                    // Damos el resultado
                    MessageBox.Show("Coordenadas del punto final: B(" + coord1 + "," + coord2 + ")");
                    this.Close();
                    
                    break;
                case 2:
                    // I = F - V
                    // Separamos los números en un array
                    string[] ttokensFinal = text1.Text.Split(' ');
                    string[] ttokensVector = text2.Text.Split(' ');
                    int[] tokensFinal = Array.ConvertAll<string, int>(ttokensFinal, int.Parse);
                    int[] tokensVector = Array.ConvertAll<string, int>(ttokensVector, int.Parse);

                    // Sumamos las coordenadas
                    int c1 = tokensFinal[0] - tokensVector[0];
                    int c2 = tokensFinal[1] - tokensVector[1];

                    // Damos el resultado
                    MessageBox.Show("Coordenadas del punto inicial: A(" + c1 + "," + c2 + ")");
                    this.Close();
                    break;
                case 3:
                    // V = F - I
                    // Separamos los números en un array
                    string[] ttFinal = text1.Text.Split(' ');
                    string[] ttInicial = text2.Text.Split(' ');
                    int[] tFinal = Array.ConvertAll<string, int>(ttFinal, int.Parse);
                    int[] tInicial = Array.ConvertAll<string, int>(ttInicial, int.Parse);

                    // Sumamos las coordenadas
                    int co1 = tFinal[0] - tInicial[0];
                    int co2 = tFinal[1] - tInicial[1];

                    // Damos el resultado
                    MessageBox.Show("Componentes del vector: u = (" + co1 + "," + co2 + ")");
                    this.Close();
                    break;
            }

        }
    }
}
