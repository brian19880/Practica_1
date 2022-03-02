using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guardar_en_archivo_txt_variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Tipos_de_Variables_Click(object sender, EventArgs e)
        {
            lbl_Mostrar_tipos_de_variables.Text= "int\n" + "long\n" + "char\n" + "double\n" + "string\n" + "boolean\n";
        }

        private void btn_Guardar_Contenido_Click(object sender, EventArgs e)
        {
            //string[] lines = { "integer\n" + "long\n" + "single\n" + "double\n" + "string\n" + "boolean\n" };
            //System.IO.File.WriteAllLines(@"C:\Users\Brian\source\repos\WindowsFormsApp1\Variables.txt", lines);
            string[] lines = { lbl_Mostrar_tipos_de_variables.Text };
            System.IO.File.WriteAllLines(@"D:\Mis_Practicas\Tarea_05.txt", lines);
            MessageBox.Show("se guardo el contenido");
        }
    }
}
