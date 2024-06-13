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
using CapaEntidad;

namespace ElLimonYSuCausa
{
    public partial class Mantenedor_Empleados : Form
    {
        public Mantenedor_Empleados()
        {
            InitializeComponent();
            listarPersonaTrabajador();
            LLenarCMBTC();
            LLenarCMBTD();
            LLenarCMBTT();
        }
        public void listarPersonaTrabajador()
        {
            dgvPersonaTrabajador.DataSource = logPersonaTrabajador.Instancia.ListarPT();
        }
        private void LLenarCMBTC()
        {
            cmbTipoContrato.DataSource = logTipoContrato.Instancia.ListarTC();
            cmbTipoContrato.DisplayMember = "TipoContrato";
            cmbTipoContrato.ValueMember = "ContratoID";
        }
        private void LLenarCMBTD()
        {
            cmbTipoDocumento.DataSource = logTipoDocumento.Instancia.ListarTD();
            cmbTipoDocumento.DisplayMember = "TipoDocumento";
            cmbTipoDocumento.ValueMember = "DocumentoID";
        }
        private void LLenarCMBTT()
        {
            cmbTipoTrabajador.DataSource = logTipoTrabajador.Instancia.ListarTT();
            cmbTipoTrabajador.DisplayMember = "TipoTrabajador";
            cmbTipoTrabajador.ValueMember = "TipoTrabajadorID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entPersona p = new entPersona
                {
                    NombrePersona = txtNombre.Text,
                    ApellidosPersona = txtApellido.Text,
                    idTipoDocumento = (cmbTipoDocumento.SelectedIndex) + 1,
                    NumeroDocumento = txtnDocumento.Text
                };
                logPersona.Instancia.InsertaPersona(p);
                int idPersona = logObteneridPersona.Instancia.ObtenerPersona();
                entTrabajador t = new entTrabajador
                {
                    idPersona = idPersona,
                    idTipoTrabajador = (cmbTipoTrabajador.SelectedIndex) + 1,
                    idTipoContrato = (cmbTipoContrato.SelectedIndex) + 1,
                    SalarioTrabajador = float.Parse(txtSalario.Text),
                    FechaIngresoTrabajador = dtpFechaIngreso.Value,
                    Usuario = txtUsuario.Text,
                    Contraseña = txtContraseña.Text
                };
                Log_Trabajador.Instancia.InsertaTrabajador(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarDatos();
            listarPersonaTrabajador();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entPersona p = new entPersona
                {
                    idPersona = int.Parse(txtidPersona.Text),
                    NombrePersona = txtNombre.Text,
                    ApellidosPersona = txtApellido.Text,
                    idTipoDocumento = (cmbTipoDocumento.SelectedIndex) + 1,
                    NumeroDocumento = txtnDocumento.Text
                };
                logPersona.Instancia.EditaPersona(p);
                entTrabajador t = new entTrabajador
                {
                    idPersona = int.Parse(txtidPersona.Text),
                    idTipoTrabajador = (cmbTipoTrabajador.SelectedIndex) + 1,
                    idTipoContrato = (cmbTipoContrato.SelectedIndex) + 1,
                    SalarioTrabajador = float.Parse(txtSalario.Text),
                    FechaIngresoTrabajador = dtpFechaIngreso.Value,
                    Usuario = txtUsuario.Text,
                    Contraseña = txtContraseña.Text
                };
                Log_Trabajador.Instancia.EditaTrabajador(t);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarDatos();
            listarPersonaTrabajador();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entPersona p = new entPersona()
                {
                    idPersona = int.Parse(txtidPersona.Text.Trim())
                };
                logPersona.Instancia.EliminarPersona(p);
                entTrabajador t = new entTrabajador()
                {
                    idPersona = int.Parse(txtidPersona.Text.Trim())
                };
                Log_Trabajador.Instancia.EliminarTrabajador(t);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarDatos();
            listarPersonaTrabajador();
        }

        public void LimpiarDatos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtContraseña.Text = "";
            txtnDocumento.Text = "";
            txtSalario.Text = "";
            txtUsuario.Text = "";
            cmbTipoContrato.Text = "";
            cmbTipoDocumento.Text = "";
            cmbTipoTrabajador.Text = "";
        }

        private void dgvPersonaTrabajador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPersonaTrabajador.Rows[e.RowIndex];
            txtidPersona.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtApellido.Text = filaActual.Cells[2].Value.ToString();
            cmbTipoDocumento.SelectedIndex = cmbTipoDocumento.FindStringExact(Convert.ToString(filaActual.Cells[3].Value));
            txtnDocumento.Text = filaActual.Cells[4].Value.ToString();
            cmbTipoTrabajador.SelectedIndex = cmbTipoTrabajador.FindStringExact(Convert.ToString(filaActual.Cells[5].Value));
            cmbTipoContrato.SelectedIndex = cmbTipoContrato.FindStringExact(Convert.ToString(filaActual.Cells[6].Value));
            txtSalario.Text = filaActual.Cells[7].Value.ToString();
            dtpFechaIngreso.Value = Convert.ToDateTime(filaActual.Cells[8].Value);
            txtUsuario.Text = filaActual.Cells[9].Value.ToString();
            txtContraseña.Text = filaActual.Cells[10].Value.ToString();
        }
    }
}
