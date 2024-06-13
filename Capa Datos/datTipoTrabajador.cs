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
    public class datTipoTrabajador
    {
        #region sigleton
        private static readonly datTipoTrabajador _instancia = new datTipoTrabajador();
        public static datTipoTrabajador Instancia
        {
            get
            {
                return datTipoTrabajador._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //Listado
        public List<entTipoTrabajador> ListarTT()
        {
            SqlCommand cmd = null;
            List<entTipoTrabajador> lista = new List<entTipoTrabajador>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipoTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoTrabajador TT = new entTipoTrabajador();
                    TT.TipoTrabajadorID = Convert.ToInt32(dr["idTipoTrabajador"]);
                    TT.TipoTrabajador = dr["Descripcion"].ToString();
                    lista.Add(TT);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        #endregion metodos
    }
}
