using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class logObtenerTrabajador
    {
        #region sigleton

        private static readonly logObtenerTrabajador _instancia = new logObtenerTrabajador();

        public static logObtenerTrabajador Instancia
        {
            get
            {
                return logObtenerTrabajador._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public int ListarOTrabajador(int a) => datObteneridTrabajador.Instancia.ListarOTrabajador(a);
        #endregion metodos
    }
}
