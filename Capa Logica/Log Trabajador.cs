using CapaEntidad;
using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Log_Trabajador
    {
        #region sigleton

        private static readonly Log_Trabajador _instancia = new Log_Trabajador();
        //privado para evitar la instanciación directa
        public static Log_Trabajador Instancia
        {
            get
            {
                return Log_Trabajador._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///inserta
        public void InsertaTrabajador(entTrabajador tra)
        {
            datTrabajador.Instancia.InsertarTrabajador(tra);
        }

        //edita
        public void EditaTrabajador(entTrabajador tra)
        {
            datTrabajador.Instancia.EditarTrabajador(tra);
        }
        public void EliminarTrabajador(entTrabajador tra)
        {
            datTrabajador.Instancia.EliminarTrabajador(tra);
        }
        #endregion metodos
    }
}
