using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElLimonYSuCausa
{
    public partial class Interface_Npersonas : Form
    {
        public Interface_Npersonas()
        {
            InitializeComponent();
        }

        public string num_mesa(string a) => txt_nm.Text = a;
        
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa1"];
            if (FrmOpen == null)
                v1.NumeroMesa(txt_nm.Text);
                this.Hide();
                v1.Show();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
 }
