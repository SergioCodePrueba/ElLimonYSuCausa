using Capa_Datos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class logObteneridPersona
    {
        #region sigleton

        private static readonly logObteneridPersona _instancia = new logObteneridPersona();
        //privado para evitar la instanciación directa
        public static logObteneridPersona Instancia
        {
            get
            {
                return logObteneridPersona._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listar
        public int ObtenerPersona()
        {
            return datObteneridPersona.Instancia.ListarOP();
        }
        #endregion metodos
    }
}
