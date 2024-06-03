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
        Interface_Npersonas v1 = new Interface_Npersonas();
        public Salon()
        {
            InitializeComponent();
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa01"];
            if (FrmOpen == null)
            {
                v1.Show();
            }
        }

        private void btnMesa15_Click(object sender, EventArgs e)
        {
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa15"];
            if (FrmOpen == null)
            {
                v1.Show();
            }
        }

        private void btnMesa14_Click(object sender, EventArgs e)
        {
            
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa14"];
            if (FrmOpen == null)
            {
              
                v1.Show();
            }
        }

        private void btnMesa13_Click(object sender, EventArgs e)
        {
            
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa13"];
            if (FrmOpen == null)
            {
                
                v1.Show();
            }
        }

        private void btnMesa12_Click(object sender, EventArgs e)
        {
            
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa12"];
            if (FrmOpen == null)
            {
                
                v1.Show();
            }
        }

        private void btnMesa11_Click(object sender, EventArgs e)
        {
            
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa11"];
            if (FrmOpen == null)
            {
                
                v1.Show();
            }
        }

        private void btnMesa10_Click(object sender, EventArgs e)
        {
          
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa10"];
            if (FrmOpen == null)
            {
                
                v1.Show();
            }
        }

        private void btnMesa9_Click(object sender, EventArgs e)
        {
            
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa09"];
            if (FrmOpen == null)
            {
                
                v1.Show();
            }
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
          
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa08"];
            if (FrmOpen == null)
            {
               
                v1.Show();
            }
        }

        private void btnMesa7_Click(object sender, EventArgs e)
        {
            
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa07"];
            if (FrmOpen == null)
            {
                
                v1.Show();
            }
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa06"];
            if (FrmOpen == null)
            {
                
                v1.Show();
            }
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
           
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa05"];
            if (FrmOpen == null)
            {
                
                v1.Show();
            }
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
          
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa04"];
            if (FrmOpen == null)
            {
                
                v1.Show();
            }
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
           
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa03"];
            if (FrmOpen == null)
            {
                
                v1.Show();
            }
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa02"];
            if (FrmOpen == null)
            {
                
                v1.Show();
            }
        }

        private void btnMesa16_Click(object sender, EventArgs e)
        {
           
            v1.Hide();
            Form FrmOpen = Application.OpenForms["Mesa16"];
            if (FrmOpen == null)
            {
               
                v1.Show();
            }
        }
    }
}
