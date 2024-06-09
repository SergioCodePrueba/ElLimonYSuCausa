using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using Capa_Logica;

namespace ElLimonYSuCausa
{
    public partial class Mantenedo_Platos : Form
    {
        public Mantenedo_Platos()
        {
            InitializeComponent();
            listarPlatos();
        }
        public void listarPlatos()
        {
            dgvPlatos.DataSource = Log_Platos.Instancia.ListarPlato();
        }


    }
}
