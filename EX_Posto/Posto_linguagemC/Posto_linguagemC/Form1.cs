using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Posto_linguagemC
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

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double litro, valor, conta;
            litro = Convert.ToDouble(txtlitro.Text);
            valor = Convert.ToDouble(txtvalor.Text);

            char comb;
            comb = Convert.ToChar(txtcomb.Text);

            if (comb = "A") {
                if (litro = 20)
                {
                    conta = (litro * 14.7) / 100;
                    valor = (litro * 4.90) - conta;
                    txtvalor.Text = "O preço final com desconto será de: ", valor;
                }
                else
                {
                    conta = (litro * 24.5) / 100;
                    valor = (litro * 4.90) - conta;
                    txtvalor.Text = "O preço final com desconto será de: ", valor;
                }
            }
            else
            {
                if (litro = 20)
                {
                    conta = (litro * 22) / 100;
                    valor = (litro * 5.50) - conta;
                    txtvalor.Text = "O preço final com desconto será de: ", valor;
                }
                else
                {
                    conta = (litro * 33) / 100;
                    valor = (litro * 5.50) - conta;
                    txtvalor.Text = "O preço final com desconto será de: ", valor;
                }
            }

        }
    }
}
