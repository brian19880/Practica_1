
namespace Matriz_Identidad
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
            this.btn_Generar_Matriz = new System.Windows.Forms.Button();
            this.txtBx_Matriz_Identidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Generar_Matriz
            // 
            this.btn_Generar_Matriz.Location = new System.Drawing.Point(101, 118);
            this.btn_Generar_Matriz.Name = "btn_Generar_Matriz";
            this.btn_Generar_Matriz.Size = new System.Drawing.Size(183, 84);
            this.btn_Generar_Matriz.TabIndex = 0;
            this.btn_Generar_Matriz.Text = "Generar_Matriz";
            this.btn_Generar_Matriz.UseVisualStyleBackColor = true;
            this.btn_Generar_Matriz.Click += new System.EventHandler(this.btn_Generar_Matriz_Click);
            // 
            // txtBx_Matriz_Identidad
            // 
            this.txtBx_Matriz_Identidad.Location = new System.Drawing.Point(391, 88);
            this.txtBx_Matriz_Identidad.Multiline = true;
            this.txtBx_Matriz_Identidad.Name = "txtBx_Matriz_Identidad";
            this.txtBx_Matriz_Identidad.Size = new System.Drawing.Size(256, 151);
            this.txtBx_Matriz_Identidad.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBx_Matriz_Identidad);
            this.Controls.Add(this.btn_Generar_Matriz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Generar_Matriz;
        private System.Windows.Forms.TextBox txtBx_Matriz_Identidad;
    }
}

