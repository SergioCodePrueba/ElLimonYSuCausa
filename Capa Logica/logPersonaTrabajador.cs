using Capa_Datos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    class logPersonaTrabajador
    {
        #region sigleton

        private static readonly logPersonaTrabajador _instancia = new logPersonaTrabajador();
        //privado para evitar la instanciación directa
        public static logPersonaTrabajador Instancia
        {
            get
            {
                return logPersonaTrabajador._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listar
        public List<entPersonaTrabajador> ListarPT()
        {
            return datPersonaTrabajador.Instancia.ListarPT();
        }

        #endregion metodos
    }
}
