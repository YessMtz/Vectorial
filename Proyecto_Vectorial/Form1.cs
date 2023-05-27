using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Vectorial
{
    public partial class Gradiente : Form
    {
        public Gradiente()
        {
            
            InitializeComponent();
        }

        int indice, variable, potencia, ans;

       

        //BOTON DE DEFINICION CUANDO DAS CLIC SALE UNA CAJA DE TEXTO
        private void Definicion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GRADIENTE: Es una generalizacion multivariable, a comparacion de la derivada que se aplican con funciones de una sola variable.El gradiente lo hace con varias variables.");
        }
        
        //CALCULO EL VALOR MAXIMO DE CAMBIO DE POTENCIAL EN EL PUNTO
        private void CalValMax_Click(object sender, EventArgs e)
        {
            indice = 2;
            variable = int.Parse(ansBoX.Text);
            ansBoX.Clear();
        }

        //BOTON DE LIMPIAR
        private void button3_Click(object sender, EventArgs e)
        {
            indice = 3;
            variable = int.Parse(ansBoX.Text);
            ansBoX.Clear();
        }

        //boton borrar
        private void borrar_Click(object sender, EventArgs e)
        {
            ansBoX.Clear();
        }

        //calculo de gradiente
        private void CalGrad_Click(object sender, EventArgs e)
        {
            indice = 1;
            variable = int.Parse(ansBoX.Text);
            ansBoX.Clear();

        }

        //BOTON DE SALIR
        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void resultado_Click(object sender, EventArgs e)
        {

               potencia = int.Parse(ansBoX.Text);
                

                switch (indice)
                {
                    case 1:
                        ans = potencia * variable;
                        ansBoX.Text = ans.ToString();

                        break;

                    case 2:
                    ans = potencia * variable;
                    ansBoX.Text = ans.ToString();
                    break;

                    case 3:
                        ans = 0;
                        ansBoX.Text = ans.ToString();
                    break;

                    default:
                        break;
                }


            
        }

    }
}
