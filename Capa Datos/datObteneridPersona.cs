using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class datObteneridPersona
    {
        #region sigleton
        private static readonly datObteneridPersona _instancia = new datObteneridPersona();
        public static datObteneridPersona Instancia
        {
            get
            {
                return datObteneridPersona._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //Listado
        public int ListarOP()
        {
            SqlCommand cmd = null;
            int idPersona = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObteneridPersona", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idPersona = Convert.ToInt32(dr["idPersona"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return idPersona;
        }
        #endregion metodos
    }
}
