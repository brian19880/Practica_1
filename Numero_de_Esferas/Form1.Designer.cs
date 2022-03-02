
namespace Numero_de_Esferas
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
            this.txtBx_Posicion_Esferas = new System.Windows.Forms.TextBox();
            this.btn_Calcular_Numero_Esferas = new System.Windows.Forms.Button();
            this.lbl_Posicion_Esferas = new System.Windows.Forms.Label();
            this.lbl_Resultado_Esferas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBx_Posicion_Esferas
            // 
            this.txtBx_Posicion_Esferas.Location = new System.Drawing.Point(292, 68);
            this.txtBx_Posicion_Esferas.Name = "txtBx_Posicion_Esferas";
            this.txtBx_Posicion_Esferas.Size = new System.Drawing.Size(125, 27);
            this.txtBx_Posicion_Esferas.TabIndex = 0;
            // 
            // btn_Calcular_Numero_Esferas
            // 
            this.btn_Calcular_Numero_Esferas.Location = new System.Drawing.Point(292, 155);
            this.btn_Calcular_Numero_Esferas.Name = "btn_Calcular_Numero_Esferas";
            this.btn_Calcular_Numero_Esferas.Size = new System.Drawing.Size(143, 76);
            this.btn_Calcular_Numero_Esferas.TabIndex = 1;
            this.btn_Calcular_Numero_Esferas.Text = "Calcular_Numero_Esferas";
            this.btn_Calcular_Numero_Esferas.UseVisualStyleBackColor = true;
            this.btn_Calcular_Numero_Esferas.Click += new System.EventHandler(this.btn_Calcular_Numero_Esferas_Click);
            // 
            // lbl_Posicion_Esferas
            // 
            this.lbl_Posicion_Esferas.AutoSize = true;
            this.lbl_Posicion_Esferas.Location = new System.Drawing.Point(210, 45);
            this.lbl_Posicion_Esferas.Name = "lbl_Posicion_Esferas";
            this.lbl_Posicion_Esferas.Size = new System.Drawing.Size(306, 20);
            this.lbl_Posicion_Esferas.TabIndex = 2;
            this.lbl_Posicion_Esferas.Text = "Ingrese el numero de la posicion de la esfera";
            // 
            // lbl_Resultado_Esferas
            // 
            this.lbl_Resultado_Esferas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Resultado_Esferas.Location = new System.Drawing.Point(293, 282);
            this.lbl_Resultado_Esferas.Name = "lbl_Resultado_Esferas";
            this.lbl_Resultado_Esferas.Size = new System.Drawing.Size(142, 65);
            this.lbl_Resultado_Esferas.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Resultado_Esferas);
            this.Controls.Add(this.lbl_Posicion_Esferas);
            this.Controls.Add(this.btn_Calcular_Numero_Esferas);
            this.Controls.Add(this.txtBx_Posicion_Esferas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_Posicion_Esferas;
        private System.Windows.Forms.Button btn_Calcular_Numero_Esferas;
        private System.Windows.Forms.Label lbl_Posicion_Esferas;
        private System.Windows.Forms.Label lbl_Resultado_Esferas;
    }
}

