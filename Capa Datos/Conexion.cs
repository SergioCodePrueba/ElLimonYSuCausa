using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class Conexion
    {
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        public SqlConnection Conectar()
        {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data Source=.; Initial Catalog = Limon_Y_Su_Causa;" +//"User ID=Sergio_SA; Password=1234";
                                "Integrated Security=true";
                return cn;
        }

    }
}
