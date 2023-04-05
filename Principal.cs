using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortearNumeroMegaSena
{
    public partial class FrmMegaSena : Form
    {
        public FrmMegaSena()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Sorteio();
        }

        private void Sorteio()
        {
            Random Sorteio = new Random();
            int sorteado;
            int[] verificar = new int[70];// esse 70 poderia ser qualquer numero desde que nao seja menor que o numero do array

            string resultado = "";
            for (int i = 0; i < 6; i++)
            {
            inicio: // goto 
                sorteado = Sorteio.Next(0, 61);

                for (int x = 0; x < 6; x++)//nesse caso usa o x pq o i ja esta sendo usado. usa-se apenas uma letra pra declarar uma variavel dentro da estrutura do for
                {
                    if (verificar[x] == sorteado)
                    {
                        goto inicio;//referencia para voltar para o inicio
                    }
                }


                resultado = resultado + " " + sorteado;
                lblResultado.Text = resultado;
                verificar[i] = sorteado;
            }

        }
    }
}
