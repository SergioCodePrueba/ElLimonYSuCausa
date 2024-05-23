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
    public partial class Salon : Form
    {
        
        public Salon()
        {
            InitializeComponent();
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa1"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("1");
                v1.Show();
            }
        }

        private void btnMesa15_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa15"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("15");
                v1.Show();
            }
        }

        private void btnMesa14_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa14"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("14");
                v1.Show();
            }
        }

        private void btnMesa13_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa13"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("13");
                v1.Show();
            }
        }

        private void btnMesa12_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa13"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("13");
                v1.Show();
            }
        }

        private void btnMesa11_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa11"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("11");
                v1.Show();
            }
        }

        private void btnMesa10_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa10"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("10");
                v1.Show();
            }
        }

        private void btnMesa9_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa09"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("09");
                v1.Show();
            }
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa08"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("08");
                v1.Show();
            }
        }

        private void btnMesa7_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa07"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("07");
                v1.Show();
            }
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa06"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("06");
                v1.Show();
            }
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa05"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("05");
                v1.Show();
            }
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa04"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("04");
                v1.Show();
            }
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa03"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("03");
                v1.Show();
            }
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa02"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("02");
                v1.Show();
            }
        }

        private void btnMesa16_Click(object sender, EventArgs e)
        {
            InterfaceMesas v1 = new InterfaceMesas();
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa16"];
            if (FrmOpen == null)
            {
                v1.NumeroMesa("16");
                v1.Show();
            }
        }
    }
}
