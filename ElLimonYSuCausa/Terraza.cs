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
    public partial class Terraza : Form
    {
        public Terraza()
        {
            InitializeComponent();
        }

        private void btnMesa22_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa22"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("22");
                v1.Show();
            }
        }

        private void btnMesa23_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa23"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("23");
                v1.Show();
            }
        }

        private void btnMesa24_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa24"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("24");
                v1.Show();
            }
        }

        private void btnMesa21_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa21"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("21");
                v1.Show();
            }
        }

        private void btnMesa20_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa20"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("20");
                v1.Show();
            }
        }

        private void btnMesa19_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa19"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("19");
                v1.Show();
            }
        }

        private void btnMesa18_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa18"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("18");
                v1.Show();
            }
        }

        private void btnMesa17_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa17"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("17");
                v1.Show();
            }
        }
    }
}
