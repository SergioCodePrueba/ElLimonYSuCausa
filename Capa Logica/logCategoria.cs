using Capa_Datos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class logCategoria
    {
        #region sigleton

        private static readonly logCategoria _instancia = new logCategoria();
        //privado para evitar la instanciación directa
        public static logCategoria Instancia
        {
            get
            {
                return logCategoria._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listar
        public List<entCategoria> ListarCategoria()
        {
            return datCategoria.Instancia.ListarCategoria();
        }
        #endregion metodos
    }
}
