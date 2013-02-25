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
            // Separar los números en un array
            string[] tFirstToken = text1.Text.Split(' ');
            string[] tSecondToken = text2.Text.Split(' ');
            int[] firstToken = Array.ConvertAll<string, int>(tFirstToken, int.Parse);
            int[] secondToken = Array.ConvertAll<string, int>(tSecondToken, int.Parse);

            // String con el resultado
            string resultado;
            switch (this.tipo)
            {
                case 1:
                    // F = I - V
                    // Sumamos las coordenadas
                    int coord1 = firstToken[0] + secondToken[0];
                    int coord2 = firstToken[1] + secondToken[1];

                    // Damos el resultado
                    resultado = "Coordenadas del punto final: B(" + coord1 + "," + coord2 + ")";                    
                    break;

                case 2:
                    // I = F - V
                    // Sumamos las coordenadas
                    int c1 = firstToken[0] - secondToken[0];
                    int c2 = firstToken[1] - secondToken[1];

                    // Damos el resultado
                    resultado = "Coordenadas del punto inicial: A(" + c1 + "," + c2 + ")";
                    break;

                case 3:
                    // V = F - I
                    // Sumamos las coordenadas
                    int co1 = firstToken[0] - secondToken[0];
                    int co2 = firstToken[1] - secondToken[1];

                    // Damos el resultado
                    resultado = "Componentes del vector: u = (" + co1 + "," + co2 + ")";
                    break;
                default:
                    resultado = "Hubo un error al procesar el problema. Puedes reportar un bug en https://github.com/unrar/solvator/issues. " + 
                        "Código de error: UNKOWN-PROBLEM-NUMBER.";
                    break;

            }

            MessageBox.Show(resultado);
            // Cerramos el InputForm
            this.Close();

        }
    }
}
