using Capa_Datos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class logTipoTrabajador
    {
        #region sigleton

        private static readonly logTipoTrabajador _instancia = new logTipoTrabajador();
        //privado para evitar la instanciación directa
        public static logTipoTrabajador Instancia
        {
            get
            {
                return logTipoTrabajador._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listar
        public List<entTipoTrabajador> ListarTT()
        {
            return datTipoTrabajador.Instancia.ListarTT();
        }
        #endregion metodos
    }
}
