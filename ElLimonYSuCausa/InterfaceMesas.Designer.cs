
namespace ElLimonYSuCausa
{
    partial class InterfaceMesas
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
            this.PanelCategorias = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelPlatos = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvListadoMesas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtnumMesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelCategorias
            // 
            this.PanelCategorias.Location = new System.Drawing.Point(12, 31);
            this.PanelCategorias.Name = "PanelCategorias";
            this.PanelCategorias.Size = new System.Drawing.Size(346, 264);
            this.PanelCategorias.TabIndex = 0;
            // 
            // PanelPlatos
            // 
            this.PanelPlatos.Location = new System.Drawing.Point(12, 316);
            this.PanelPlatos.Name = "PanelPlatos";
            this.PanelPlatos.Size = new System.Drawing.Size(346, 283);
            this.PanelPlatos.TabIndex = 1;
            // 
            // dgvListadoMesas
            // 
            this.dgvListadoMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoMesas.Location = new System.Drawing.Point(377, 12);
            this.dgvListadoMesas.Name = "dgvListadoMesas";
            this.dgvListadoMesas.Size = new System.Drawing.Size(420, 283);
            this.dgvListadoMesas.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 81);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 81);
            this.button2.TabIndex = 4;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 81);
            this.button3.TabIndex = 5;
            this.button3.Text = "Anular Uno";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(710, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 81);
            this.button4.TabIndex = 6;
            this.button4.Text = "Anular Todo";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(424, 462);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 81);
            this.button5.TabIndex = 7;
            this.button5.Text = "Cambio Mesas";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtnumMesa
            // 
            this.txtnumMesa.Enabled = false;
            this.txtnumMesa.Location = new System.Drawing.Point(58, 5);
            this.txtnumMesa.Name = "txtnumMesa";
            this.txtnumMesa.Size = new System.Drawing.Size(28, 20);
            this.txtnumMesa.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "MESA:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(539, 462);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 81);
            this.button6.TabIndex = 10;
            this.button6.Text = "Pagar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(649, 462);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 81);
            this.button7.TabIndex = 11;
            this.button7.Text = "Salir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // InterfaceMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 649);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumMesa);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvListadoMesas);
            this.Controls.Add(this.PanelPlatos);
            this.Controls.Add(this.PanelCategorias);
            this.Name = "InterfaceMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfaceMesas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelCategorias;
        private System.Windows.Forms.FlowLayoutPanel PanelPlatos;
        private System.Windows.Forms.DataGridView dgvListadoMesas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtnumMesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}