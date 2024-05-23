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
    public partial class MenuPrincipal : Form
    {
        Salon salon = new Salon();
        Terraza terraza = new Terraza();
        public MenuPrincipal()
        {
            InitializeComponent();
            salon.MdiParent = this;
            salon.Show();
        }

        private void sALONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terraza.Hide();
            Form FrmOpen = Application.OpenForms["salon"];
            if (FrmOpen == null) {
                salon.MdiParent = this;
                salon.Show();
            }
            
        }

        private void tERRAZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salon.Hide();
            Form FrmOpen = Application.OpenForms["terraza"];
            if (FrmOpen == null)
            {
                terraza.MdiParent = this;
                terraza.Show();
            }
        }
    }
}
