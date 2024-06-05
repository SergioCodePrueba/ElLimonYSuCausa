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
        Interface_Npersonas v1 = new Interface_Npersonas();
        public Terraza()
        {
            InitializeComponent();
        }

        private void btnMesa22_Click(object sender, EventArgs e)
        {
            Interface_Npersonas v1 = new Interface_Npersonas();
            string mesa = "22";
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa01"];
            if (FrmOpen == null)
            {
                v1.num_mesa(mesa);
                v1.Show();
            }
        }

        private void btnMesa23_Click(object sender, EventArgs e)
        {
            Interface_Npersonas v1 = new Interface_Npersonas();
            string mesa = "23";
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa01"];
            if (FrmOpen == null)
            {
                v1.num_mesa(mesa);
                v1.Show();
            }
        }

        private void btnMesa24_Click(object sender, EventArgs e)
        {
            Interface_Npersonas v1 = new Interface_Npersonas();
            string mesa = "24";
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa01"];
            if (FrmOpen == null)
            {
                v1.num_mesa(mesa);
                v1.Show();
            }
        }

        private void btnMesa21_Click(object sender, EventArgs e)
        {
            Interface_Npersonas v1 = new Interface_Npersonas();
            string mesa = "21";
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa01"];
            if (FrmOpen == null)
            {
                v1.num_mesa(mesa);
                v1.Show();
            }
        }

        private void btnMesa20_Click(object sender, EventArgs e)
        {
            Interface_Npersonas v1 = new Interface_Npersonas();
            string mesa = "20";
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa01"];
            if (FrmOpen == null)
            {
                v1.num_mesa(mesa);
                v1.Show();
            }
        }

        private void btnMesa19_Click(object sender, EventArgs e)
        {
            Interface_Npersonas v1 = new Interface_Npersonas();
            string mesa = "19";
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa01"];
            if (FrmOpen == null)
            {
                v1.num_mesa(mesa);
                v1.Show();
            }
        }

        private void btnMesa18_Click(object sender, EventArgs e)
        {
            Interface_Npersonas v1 = new Interface_Npersonas();
            string mesa = "18";
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa01"];
            if (FrmOpen == null)
            {
                v1.num_mesa(mesa);
                v1.Show();
            }
        }

        private void btnMesa17_Click(object sender, EventArgs e)
        {
            Interface_Npersonas v1 = new Interface_Npersonas();
            string mesa = "17";
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa01"];
            if (FrmOpen == null)
            {
                v1.num_mesa(mesa);
                v1.Show();
            }
        }
    }
}
