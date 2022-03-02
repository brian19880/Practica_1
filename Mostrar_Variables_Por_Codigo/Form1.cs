using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mostrar_Variables_Por_Codigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Variables_Codigo_Click(object sender, EventArgs e)
        {
            lbl_Variables_por_Codigo.Text = typeof(int).ToString() + "\n" + typeof(string).ToString() + "\n" + typeof(bool).ToString()
                + "\n" + typeof(double).ToString() + "\n" + typeof(char).ToString() + "\n" + typeof(long).ToString();
        }
    }
}
