
namespace Mostrar_Variables
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
            this.btn_Mostrar_Variables = new System.Windows.Forms.Button();
            this.lbl_Mostrar_Variables = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Mostrar_Variables
            // 
            this.btn_Mostrar_Variables.Location = new System.Drawing.Point(100, 66);
            this.btn_Mostrar_Variables.Name = "btn_Mostrar_Variables";
            this.btn_Mostrar_Variables.Size = new System.Drawing.Size(171, 70);
            this.btn_Mostrar_Variables.TabIndex = 0;
            this.btn_Mostrar_Variables.Text = "Mostrar_Variables";
            this.btn_Mostrar_Variables.UseVisualStyleBackColor = true;
            this.btn_Mostrar_Variables.Click += new System.EventHandler(this.btn_Mostrar_Variables_Click);
            // 
            // lbl_Mostrar_Variables
            // 
            this.lbl_Mostrar_Variables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Mostrar_Variables.Location = new System.Drawing.Point(370, 66);
            this.lbl_Mostrar_Variables.Name = "lbl_Mostrar_Variables";
            this.lbl_Mostrar_Variables.Size = new System.Drawing.Size(315, 223);
            this.lbl_Mostrar_Variables.TabIndex = 1;
            this.lbl_Mostrar_Variables.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Mostrar_Variables);
            this.Controls.Add(this.btn_Mostrar_Variables);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Mostrar_Variables;
        private System.Windows.Forms.Label lbl_Mostrar_Variables;
    }
}

