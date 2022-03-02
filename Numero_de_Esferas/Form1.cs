using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero_de_Esferas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Numero_Esferas_Click(object sender, EventArgs e)
        {
            int esferas = int.Parse(txtBx_Posicion_Esferas.Text);

            esferas = esferas * (esferas + 1) / 2;

            lbl_Resultado_Esferas.Text = esferas.ToString();
        }
    }
}
