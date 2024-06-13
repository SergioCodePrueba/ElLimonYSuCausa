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
    public class datTipoContrato
    {
        #region sigleton
        private static readonly datTipoContrato _instancia = new datTipoContrato();
        public static datTipoContrato Instancia
        {
            get
            {
                return datTipoContrato._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //Listado
        public List<entTipoContrato> ListarTC()
        {
            SqlCommand cmd = null;
            List<entTipoContrato> lista = new List<entTipoContrato>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipoContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoContrato TC = new entTipoContrato();
                    TC.ContratoID = Convert.ToInt32(dr["idTipoContrato"]);
                    TC.TipoContrato = dr["Descripcion"].ToString();
                    lista.Add(TC);
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
