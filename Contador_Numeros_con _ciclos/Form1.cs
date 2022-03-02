using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador_Numeros_con__ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Contador_con_While_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtBx_Tamano_Numeros.Text);
            int contador = 0;
            var sb = new System.Text.StringBuilder();

           
            while (contador < x)
            {
                sb.AppendLine(contador.ToString());
                contador = contador + 1;
                txtBx_Resultado.Text = sb.ToString();
            }
        }

        private void btn_Contador_Con_For_Click(object sender, EventArgs e)
        {

            int x = int.Parse(txtBx_Tamano_Numeros.Text);
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < x; i++)
            {
                sb.AppendLine(i.ToString());
            }
            txtBx_Resultado.Text = sb.ToString();
        }

        private void btn_Contador_Con_do_While_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtBx_Tamano_Numeros.Text);
            int contador = 0;
            var sb = new System.Text.StringBuilder();

            do
            {
                sb.AppendLine(contador.ToString());
                contador = contador + 1;
                txtBx_Resultado.Text = sb.ToString();
            } while (contador < x);
        }

        private void btn_Limpiar_Pantalla_Click(object sender, EventArgs e)
        {
            txtBx_Resultado.Text= "";
            txtBx_Tamano_Numeros.Text = "";
        }
    }
}
