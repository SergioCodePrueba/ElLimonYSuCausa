using Capa_Datos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class logTipoDocumento
    {
        #region sigleton

        private static readonly logTipoDocumento _instancia = new logTipoDocumento();
        //privado para evitar la instanciación directa
        public static logTipoDocumento Instancia
        {
            get
            {
                return logTipoDocumento._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listar
        public List<entTipoDocumento> ListarTD()
        {
            return datTipoDocumento.Instancia.ListarTD();
        }
        #endregion metodos
    }
}
