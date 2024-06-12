using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace Capa_Datos
{
    public class datPersona
    {
        
        #region sigleton
        private static readonly datPersona _instancia = new datPersona();
        
        public static datPersona Instancia
        {
            get
            {
                return datPersona._instancia;
            }
        }
        #endregion singleton
        #region metodos
        /////////////////////////InsertaCliente
        public Boolean InsertarPersona(entPersona per)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaPersona", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombrePersona", per.NombrePersona);
                cmd.Parameters.AddWithValue("@ApellidosPersona", per.ApellidosPersona);
                cmd.Parameters.AddWithValue("@idTipoDocumento", per.idTipoDocumento);
                cmd.Parameters.AddWithValue("@NumeroDocumento", per.NumeroDocumento);
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
        public Boolean EditarPersona(entPersona per)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaPersona", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPersona", per.idPersona);
                cmd.Parameters.AddWithValue("@NombrePersona", per.NombrePersona);
                cmd.Parameters.AddWithValue("@ApellidosPersona", per.ApellidosPersona);
                cmd.Parameters.AddWithValue("@idTipoDocumento", per.idTipoDocumento);
                cmd.Parameters.AddWithValue("@NumeroDocumento", per.NumeroDocumento);
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
