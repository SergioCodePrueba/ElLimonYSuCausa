using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace Capa_Datos
{
    public class datObteneridTrabajador
    {
        #region sigleton
        private static readonly datObteneridTrabajador _instancia = new datObteneridTrabajador();
        public static datObteneridTrabajador Instancia
        {
            get
            {
                return datObteneridTrabajador._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //Listado
        public int ListarOTrabajador(int a)
        {
            SqlCommand cmd = null;
            int idTrabajador = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spObteneridTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cmd.Parameters.AddWithValue("@idPersona", a);
                    idTrabajador = Convert.ToInt32(dr["idTrabajador"]);
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
            return idTrabajador;
        }
        #endregion metodos
    }
}
