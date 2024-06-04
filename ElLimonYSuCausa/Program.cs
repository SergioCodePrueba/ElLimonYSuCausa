using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElLimonYSuCausa
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Conexion con = new Conexion();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            con.Conectar();
            Application.Run(new Login());
            
        }
    }
}
