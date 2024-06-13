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
            LLenarCMBCategoria();
        }
        public void listarPlatos()
        {
            dgvPlatos.DataSource = Log_Platos.Instancia.ListarPlato();
        }
        private void LLenarCMBCategoria()
        {
            cmbCategoria.DataSource = logCategoria.Instancia.ListarCategoria();
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.ValueMember = "CategoriaID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entPlatos p = new entPlatos();
                p.Nombre_Producto = txtNombreProducto.Text;
                p.idTipoProducto = (cmbCategoria.SelectedIndex) + 1;
                p.Precio_Producto = Convert.ToSingle(txtPrecio.Text);
                Log_Platos.Instancia.InsertarPlato(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarPlatos();
        }

        private void dgvPlatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPlatos.Rows[e.RowIndex]; //
            txtidPlato.Text = filaActual.Cells[0].Value.ToString();
            txtNombreProducto.Text = filaActual.Cells[3].Value.ToString();
            cmbCategoria.SelectedIndex = (Convert.ToInt32(filaActual.Cells[1].Value)) - 1;
            txtPrecio.Text = filaActual.Cells[4].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entPlatos p = new entPlatos();
                p.id_Producto = Convert.ToInt32(txtidPlato.Text);
                p.Nombre_Producto = txtNombreProducto.Text;
                p.idTipoProducto = (cmbCategoria.SelectedIndex) + 1;
                p.Precio_Producto = Convert.ToSingle(txtPrecio.Text);
                Log_Platos.Instancia.EditarPlato(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarPlatos();
        }
    }
}
