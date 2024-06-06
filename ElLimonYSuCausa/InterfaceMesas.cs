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
        public InterfaceMesas()
        {
            InitializeComponent();
        }
        public string NumeroMesa(string a) => txtnumMesa.Text = a;

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
