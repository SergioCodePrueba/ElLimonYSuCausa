using System;
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
