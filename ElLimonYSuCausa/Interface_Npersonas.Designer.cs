
namespace ElLimonYSuCausa
{
    partial class Interface_Npersonas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_npersonas = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_nummesa = new System.Windows.Forms.Label();
            this.txt_nm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Personas";
            // 
            // txt_npersonas
            // 
            this.txt_npersonas.Location = new System.Drawing.Point(28, 44);
            this.txt_npersonas.Name = "txt_npersonas";
            this.txt_npersonas.Size = new System.Drawing.Size(263, 20);
            this.txt_npersonas.TabIndex = 1;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(12, 90);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(128, 90);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Borrar.TabIndex = 3;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(242, 90);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 4;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_nummesa
            // 
            this.txt_nummesa.AutoSize = true;
            this.txt_nummesa.Location = new System.Drawing.Point(271, 9);
            this.txt_nummesa.Name = "txt_nummesa";
            this.txt_nummesa.Size = new System.Drawing.Size(0, 13);
            this.txt_nummesa.TabIndex = 5;
            // 
            // txt_nm
            // 
            this.txt_nm.Location = new System.Drawing.Point(296, 6);
            this.txt_nm.Name = "txt_nm";
            this.txt_nm.Size = new System.Drawing.Size(21, 20);
            this.txt_nm.TabIndex = 6;
            // 
            // Interface_Npersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 156);
            this.Controls.Add(this.txt_nm);
            this.Controls.Add(this.txt_nummesa);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.txt_npersonas);
            this.Controls.Add(this.label1);
            this.Name = "Interface_Npersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface_Npersonas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_npersonas;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label txt_nummesa;
        private System.Windows.Forms.TextBox txt_nm;
    }
}