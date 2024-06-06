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
    public partial class InterfaceMesas : Form
    {
        Inteface_Menu m = new Inteface_Menu();
        public InterfaceMesas()
        {
            InitializeComponent();
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            this.panel_menu.Controls.Add(m);
            this.panel_menu.Tag = m;
            m.Show();

        }
        public string NumeroMesa(string a) => txtnumMesa.Text = a;

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void AbrirForm(object form)
        {
            if (this.panel_Categoria.Controls.Count > 0)
                this.panel_Categoria.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_Categoria.Controls.Add(fh);
            this.panel_Categoria.Tag = fh;
            fh.Show();
        }
    }
}
