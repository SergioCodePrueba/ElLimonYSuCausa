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
    public class datPersonaTrabajador
    {
        #region sigleton
        
        private static readonly datPersonaTrabajador _instancia = new datPersonaTrabajador();
        
        public static datPersonaTrabajador Instancia
        {
            get
            {
                return datPersonaTrabajador._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entPersonaTrabajador> ListarPT()
        {
            SqlCommand cmd = null;
            List<entPersonaTrabajador> lista = new List<entPersonaTrabajador>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaTrabajadorPersona", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPersonaTrabajador PT = new entPersonaTrabajador();
                    PT.idPersona = Convert.ToInt32(dr["idPersona"]);
                    PT.NombrePersona = dr["NombresPersona"].ToString();
                    PT.ApellidosPersona = dr["ApellidosPersona"].ToString();
                    PT.Tipo_Documento = dr["Tipo_Documento"].ToString();
                    PT.NumeroDocumento = dr["NumeroDocumento"].ToString();
                    PT.Tipo_Trabajador = dr["Tipo_Trabajador"].ToString();
                    PT.Tipo_Contrato= dr["Tipo_Contrato"].ToString();
                    PT.SalarioTrabajador = Convert.ToSingle(dr["SalarioTrabajador"]);
                    PT.FechaIngresoTrabajador = Convert.ToDateTime(dr["FechaIngresoTrabajador"]);
                    PT.Usuario = dr["Usuario"].ToString();
                    PT.Contraseña = dr["Contraseña"].ToString();
                    lista.Add(PT);
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
