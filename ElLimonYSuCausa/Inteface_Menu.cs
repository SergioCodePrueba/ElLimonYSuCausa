﻿using System;
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
    public partial class Inteface_Menu : Form
    {
        
        public Inteface_Menu()
        {
            InitializeComponent();
        }

        private void btn_Flameados_Click(object sender, EventArgs e)
        {
            InterfaceMesas n = new InterfaceMesas();
            n.AbrirForm(new Interface_Flameados());
        }
    }
}
