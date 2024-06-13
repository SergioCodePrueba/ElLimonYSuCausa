using CapaEntidad;
using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Logica
{
    public class logPersona
    {
        #region sigleton
        
        private static readonly logPersona _instancia = new logPersona();
        //privado para evitar la instanciación directa
        public static logPersona Instancia
        {
            get
            {
                return logPersona._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///inserta
        public void InsertaPersona(entPersona per)
        {
            datPersona.Instancia.InsertarPersona(per);
        }

        //edita
        public void EditaPersona(entPersona per)
        {
            datPersona.Instancia.EditarPersona(per);
        }
        public void EliminarPersona(entPersona per)
        {
            datPersona.Instancia.EliminarPersona(per);
        }
        #endregion metodos
    }

}
