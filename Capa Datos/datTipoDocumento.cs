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
    public class datTipoDocumento
    {
        #region sigleton
        private static readonly datTipoDocumento _instancia = new datTipoDocumento();
        public static datTipoDocumento Instancia
        {
            get
            {
                return datTipoDocumento._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //Listado
        public List<entTipoDocumento> ListarTD()
        {
            SqlCommand cmd = null;
            List<entTipoDocumento> lista = new List<entTipoDocumento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipoDocumento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoDocumento TD = new entTipoDocumento();
                    TD.DocumentoID = Convert.ToInt32(dr["idTipoDocumento"]);
                    TD.TipoDocumento = dr["Descripcion"].ToString();
                    lista.Add(TD);
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
