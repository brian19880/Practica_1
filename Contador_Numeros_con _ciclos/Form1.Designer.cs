
namespace Contador_Numeros_con__ciclos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Contador_con_While = new System.Windows.Forms.Button();
            this.txtBx_Tamano_Numeros = new System.Windows.Forms.TextBox();
            this.lbl_Tamano_Numeros = new System.Windows.Forms.Label();
            this.txtBx_Resultado = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_Contador_Con_For = new System.Windows.Forms.Button();
            this.btn_Contador_Con_do_While = new System.Windows.Forms.Button();
            this.btn_Limpiar_Pantalla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Contador_con_While
            // 
            this.btn_Contador_con_While.Location = new System.Drawing.Point(86, 150);
            this.btn_Contador_con_While.Name = "btn_Contador_con_While";
            this.btn_Contador_con_While.Size = new System.Drawing.Size(188, 67);
            this.btn_Contador_con_While.TabIndex = 0;
            this.btn_Contador_con_While.Text = "Contador_con_While";
            this.btn_Contador_con_While.UseVisualStyleBackColor = true;
            this.btn_Contador_con_While.Click += new System.EventHandler(this.btn_Contador_con_While_Click);
            // 
            // txtBx_Tamano_Numeros
            // 
            this.txtBx_Tamano_Numeros.Location = new System.Drawing.Point(359, 47);
            this.txtBx_Tamano_Numeros.Name = "txtBx_Tamano_Numeros";
            this.txtBx_Tamano_Numeros.Size = new System.Drawing.Size(197, 27);
            this.txtBx_Tamano_Numeros.TabIndex = 1;
            // 
            // lbl_Tamano_Numeros
            // 
            this.lbl_Tamano_Numeros.AutoSize = true;
            this.lbl_Tamano_Numeros.Location = new System.Drawing.Point(35, 50);
            this.lbl_Tamano_Numeros.Name = "lbl_Tamano_Numeros";
            this.lbl_Tamano_Numeros.Size = new System.Drawing.Size(309, 20);
            this.lbl_Tamano_Numeros.TabIndex = 2;
            this.lbl_Tamano_Numeros.Text = "Digite_El_tamano_del_Contador_de_Numeros";
            // 
            // txtBx_Resultado
            // 
            this.txtBx_Resultado.Location = new System.Drawing.Point(444, 234);
            this.txtBx_Resultado.Name = "txtBx_Resultado";
            this.txtBx_Resultado.Size = new System.Drawing.Size(290, 27);
            this.txtBx_Resultado.TabIndex = 3;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(359, 234);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(75, 20);
            this.lbl_Resultado.TabIndex = 4;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // btn_Contador_Con_For
            // 
            this.btn_Contador_Con_For.Location = new System.Drawing.Point(86, 234);
            this.btn_Contador_Con_For.Name = "btn_Contador_Con_For";
            this.btn_Contador_Con_For.Size = new System.Drawing.Size(188, 60);
            this.btn_Contador_Con_For.TabIndex = 5;
            this.btn_Contador_Con_For.Text = "Contador_Con_For";
            this.btn_Contador_Con_For.UseVisualStyleBackColor = true;
            this.btn_Contador_Con_For.Click += new System.EventHandler(this.btn_Contador_Con_For_Click);
            // 
            // btn_Contador_Con_do_While
            // 
            this.btn_Contador_Con_do_While.Location = new System.Drawing.Point(86, 314);
            this.btn_Contador_Con_do_While.Name = "btn_Contador_Con_do_While";
            this.btn_Contador_Con_do_While.Size = new System.Drawing.Size(188, 61);
            this.btn_Contador_Con_do_While.TabIndex = 6;
            this.btn_Contador_Con_do_While.Text = "Contador_Con_do_While";
            this.btn_Contador_Con_do_While.UseVisualStyleBackColor = true;
            this.btn_Contador_Con_do_While.Click += new System.EventHandler(this.btn_Contador_Con_do_While_Click);
            // 
            // btn_Limpiar_Pantalla
            // 
            this.btn_Limpiar_Pantalla.Location = new System.Drawing.Point(462, 330);
            this.btn_Limpiar_Pantalla.Name = "btn_Limpiar_Pantalla";
            this.btn_Limpiar_Pantalla.Size = new System.Drawing.Size(202, 54);
            this.btn_Limpiar_Pantalla.TabIndex = 7;
            this.btn_Limpiar_Pantalla.Text = "Limpiar_Pantalla";
            this.btn_Limpiar_Pantalla.UseVisualStyleBackColor = true;
            this.btn_Limpiar_Pantalla.Click += new System.EventHandler(this.btn_Limpiar_Pantalla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Limpiar_Pantalla);
            this.Controls.Add(this.btn_Contador_Con_do_While);
            this.Controls.Add(this.btn_Contador_Con_For);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txtBx_Resultado);
            this.Controls.Add(this.lbl_Tamano_Numeros);
            this.Controls.Add(this.txtBx_Tamano_Numeros);
            this.Controls.Add(this.btn_Contador_con_While);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Contador_con_While;
        private System.Windows.Forms.TextBox txtBx_Tamano_Numeros;
        private System.Windows.Forms.Label lbl_Tamano_Numeros;
        private System.Windows.Forms.TextBox txtBx_Resultado;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_Contador_Con_For;
        private System.Windows.Forms.Button btn_Contador_Con_do_While;
        private System.Windows.Forms.Button btn_Limpiar_Pantalla;
    }
}

