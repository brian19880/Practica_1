using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Identidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Generar_Matriz_Click(object sender, EventArgs e)
        {
            var sb = new System.Text.StringBuilder();
            int contador = 1;

            int[,] a = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                        a[i, j] = 1;
                    else
                        a[i, j] = 0;
                    if (contador < 4)
                    {
                        sb.Append(" " + a[i, j]);
                        //txtBx_Matriz_Identidad.Text = sb.ToString();
                        contador = contador + 1;
                    }
                    else
                    {

                        sb.AppendLine(" " + a[i, j]);
                        txtBx_Matriz_Identidad.Text = sb.ToString() + "\n";
                        contador = 1;
                    }
                }
            }
        }
    }
}
