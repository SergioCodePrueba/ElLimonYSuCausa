using Capa_Datos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class logTipoContrato
    {
        #region sigleton

        private static readonly logTipoContrato _instancia = new logTipoContrato();
        //privado para evitar la instanciación directa
        public static logTipoContrato Instancia
        {
            get
            {
                return logTipoContrato._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listar
        public List<entTipoContrato> ListarTC()
        {
            return datTipoContrato.Instancia.ListarTC();
        }
        #endregion metodos
    }
}
