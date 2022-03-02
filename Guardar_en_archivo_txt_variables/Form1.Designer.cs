
namespace Guardar_en_archivo_txt_variables
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
            this.btn_Mostrar_Tipos_de_Variables = new System.Windows.Forms.Button();
            this.lbl_Mostrar_tipos_de_variables = new System.Windows.Forms.Label();
            this.btn_Guardar_Contenido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Mostrar_Tipos_de_Variables
            // 
            this.btn_Mostrar_Tipos_de_Variables.Location = new System.Drawing.Point(78, 110);
            this.btn_Mostrar_Tipos_de_Variables.Name = "btn_Mostrar_Tipos_de_Variables";
            this.btn_Mostrar_Tipos_de_Variables.Size = new System.Drawing.Size(144, 73);
            this.btn_Mostrar_Tipos_de_Variables.TabIndex = 0;
            this.btn_Mostrar_Tipos_de_Variables.Text = "Mostrar_Tipos_de_Variables";
            this.btn_Mostrar_Tipos_de_Variables.UseVisualStyleBackColor = true;
            this.btn_Mostrar_Tipos_de_Variables.Click += new System.EventHandler(this.btn_Mostrar_Tipos_de_Variables_Click);
            // 
            // lbl_Mostrar_tipos_de_variables
            // 
            this.lbl_Mostrar_tipos_de_variables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Mostrar_tipos_de_variables.Location = new System.Drawing.Point(356, 78);
            this.lbl_Mostrar_tipos_de_variables.Name = "lbl_Mostrar_tipos_de_variables";
            this.lbl_Mostrar_tipos_de_variables.Size = new System.Drawing.Size(256, 149);
            this.lbl_Mostrar_tipos_de_variables.TabIndex = 1;
            this.lbl_Mostrar_tipos_de_variables.Text = "label1";
            // 
            // btn_Guardar_Contenido
            // 
            this.btn_Guardar_Contenido.Location = new System.Drawing.Point(246, 269);
            this.btn_Guardar_Contenido.Name = "btn_Guardar_Contenido";
            this.btn_Guardar_Contenido.Size = new System.Drawing.Size(198, 64);
            this.btn_Guardar_Contenido.TabIndex = 2;
            this.btn_Guardar_Contenido.Text = "Guardar_Contenido";
            this.btn_Guardar_Contenido.UseVisualStyleBackColor = true;
            this.btn_Guardar_Contenido.Click += new System.EventHandler(this.btn_Guardar_Contenido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Guardar_Contenido);
            this.Controls.Add(this.lbl_Mostrar_tipos_de_variables);
            this.Controls.Add(this.btn_Mostrar_Tipos_de_Variables);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Mostrar_Tipos_de_Variables;
        private System.Windows.Forms.Label lbl_Mostrar_tipos_de_variables;
        private System.Windows.Forms.Button btn_Guardar_Contenido;
    }
}

