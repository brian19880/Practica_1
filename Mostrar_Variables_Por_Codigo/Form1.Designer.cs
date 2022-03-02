
namespace Mostrar_Variables_Por_Codigo
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
            this.btn_Mostrar_Variables_Codigo = new System.Windows.Forms.Button();
            this.lbl_Variables_por_Codigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Mostrar_Variables_Codigo
            // 
            this.btn_Mostrar_Variables_Codigo.Location = new System.Drawing.Point(75, 113);
            this.btn_Mostrar_Variables_Codigo.Name = "btn_Mostrar_Variables_Codigo";
            this.btn_Mostrar_Variables_Codigo.Size = new System.Drawing.Size(230, 114);
            this.btn_Mostrar_Variables_Codigo.TabIndex = 0;
            this.btn_Mostrar_Variables_Codigo.Text = "Mostrar_Variables_Por_Codigo";
            this.btn_Mostrar_Variables_Codigo.UseVisualStyleBackColor = true;
            this.btn_Mostrar_Variables_Codigo.Click += new System.EventHandler(this.btn_Mostrar_Variables_Codigo_Click);
            // 
            // lbl_Variables_por_Codigo
            // 
            this.lbl_Variables_por_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Variables_por_Codigo.Location = new System.Drawing.Point(374, 113);
            this.lbl_Variables_por_Codigo.Name = "lbl_Variables_por_Codigo";
            this.lbl_Variables_por_Codigo.Size = new System.Drawing.Size(289, 212);
            this.lbl_Variables_por_Codigo.TabIndex = 1;
            this.lbl_Variables_por_Codigo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Variables_por_Codigo);
            this.Controls.Add(this.btn_Mostrar_Variables_Codigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Mostrar_Variables_Codigo;
        private System.Windows.Forms.Label lbl_Variables_por_Codigo;
    }
}

