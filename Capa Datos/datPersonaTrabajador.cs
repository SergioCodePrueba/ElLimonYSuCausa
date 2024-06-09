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
                    PT.NombrePersona = dr["dbo.Persona.NombresPersona"].ToString();
                    PT.ApellidosPersona = dr["dbo.Persona.ApellidosPersona"].ToString();
                    PT.Tipo_Documento = dr["dbo.TipoDocumento.Descripcion"].ToString();
                    PT.NumeroDocumento = dr["dbo.Persona.NumeroDocumento"].ToString();
                    PT.Tipo_Trabajador = dr["dbo.TipoTrabajador.Descripcion"].ToString();
                    PT.Tipo_Contrato= dr["dbo.TipoContrato.Descripcion"].ToString();
                    PT.SalarioTrabajador = Convert.ToSingle(dr["dbo.Trabajador.SalarioTrabajador"]);
                    PT.FechaIngresoTrabajador = Convert.ToDateTime(dr["dbo.Trabajador.FechaIngresoTrabajador"]);
                    PT.Usuario = dr["dbo.Trabajador.Usuario"].ToString();
                    PT.Contraseña = dr["dbo.Trabajador.Contraseña"].ToString();
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
