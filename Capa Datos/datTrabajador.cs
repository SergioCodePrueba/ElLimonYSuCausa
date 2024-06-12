using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class datTrabajador
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datTrabajador _instancia = new datTrabajador();
        //privado para evitar la instanciación directa
        public static datTrabajador Instancia
        {
            get
            {
                return datTrabajador._instancia;
            }
        }
        #endregion singleton

        #region metodos
        /////////////////////////InsertaCliente
        public Boolean InsertarTrabajador(entTrabajador Tra)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPersona", Tra.idPersona);
                cmd.Parameters.AddWithValue("@idTipoTrabajador", Tra.idTipoTrabajador);
                cmd.Parameters.AddWithValue("@idTipoContrato", Tra.idTipoContrato);
                cmd.Parameters.AddWithValue("@SalarioTrabajador", Tra.SalarioTrabajador);
                cmd.Parameters.AddWithValue("@FechaIngresoTrabajador", Tra.FechaIngresoTrabajador);
                cmd.Parameters.AddWithValue("@Usuario", Tra.Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Tra.Contraseña);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }


        //////////////////////////////////EditaCliente
        public Boolean EditarTrabajador(entTrabajador Tra)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTrabajador", Tra.idTrabajador);
                cmd.Parameters.AddWithValue("@idTipoTrabajador", Tra.idTipoTrabajador);
                cmd.Parameters.AddWithValue("@idTipoContrato", Tra.idTipoContrato);
                cmd.Parameters.AddWithValue("@SalarioTrabajador", Tra.SalarioTrabajador);
                cmd.Parameters.AddWithValue("@FechaIngresoTrabajador", Tra.FechaIngresoTrabajador);
                cmd.Parameters.AddWithValue("@Usuario", Tra.Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Tra.Contraseña);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        #endregion metodos
    }
}
