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

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa1"];
            if (FrmOpen == null)

                v1.Show();
        }
    }
    }
}
