using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;

namespace ElLimonYSuCausa
{
    public partial class Mantenedor_Empleados : Form
    {
        public Mantenedor_Empleados()
        {
            InitializeComponent();
        }
        public void listarEmpleados() => dgvPersonaTrabajador.DataSource = logPersonaTrabajador.Instancia.ListarPT();

    }
}
