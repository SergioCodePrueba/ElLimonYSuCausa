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
        Mantenedo_Platos mp = new Mantenedo_Platos();
        Mantenedor_Empleados me = new Mantenedor_Empleados();
        Interface_Llevar l = new Interface_Llevar();
        public MenuPrincipal()
        {
            InitializeComponent();
            salon.MdiParent = this;
            salon.Show();
        }

        private void sALONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terraza.Hide();
            mp.Hide();
            me.Hide();
            l.Hide();
            Form FrmOpen = Application.OpenForms["salon"];
            if (FrmOpen == null) {
                salon.MdiParent = this;
                salon.Show();
            }
            
        }

        private void tERRAZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salon.Hide();
            me.Hide();
            mp.Hide();
            l.Hide();
            Form FrmOpen = Application.OpenForms["terraza"];
            if (FrmOpen == null)
            {
                terraza.MdiParent = this;
                terraza.Show();
            }
        }

        private void pLATOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terraza.Hide();
            salon.Hide();
            me.Hide();
            l.Hide();
            Form FrmOpen = Application.OpenForms["Platos"];
            if (FrmOpen == null)
            {
                mp.MdiParent = this;
                mp.Show();
            }
        }

        private void eMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terraza.Hide();
            salon.Hide();
            mp.Hide();
            l.Hide();
            Form FrmOpen = Application.OpenForms["Platos"];
            if (FrmOpen == null)
            {
                me.MdiParent = this;
                me.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lLEVARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terraza.Hide();
            salon.Hide();
            mp.Hide();
            me.Hide();
            Form FrmOpen = Application.OpenForms["Platos"];
            if (FrmOpen == null)
            {
                l.MdiParent = this;
                l.Show();
            }
        }
    }
}
