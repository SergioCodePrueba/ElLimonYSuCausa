using Capa_Datos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Log_Platos
    {
        #region sigleton

        private static readonly Log_Platos _instancia = new Log_Platos();
        //privado para evitar la instanciación directa
        public static Log_Platos Instancia
        {
            get
            {
                return Log_Platos._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listar
        public List<entPlatos> ListarPlato()
        {
            return datPlatos.Instancia.ListarPlato();
        }

        ///inserta
        public void InsertarPlato(entPlatos pla)
        {
            datPlatos.Instancia.InsertarPlato(pla);
        }

        //edita
        public void EditarPlato(entPlatos pla)
        {
            datPlatos.Instancia.EditarPlato(pla);
        }
        public void EliminarPlatos(entPlatos pla)
        {
            datPlatos.Instancia.EliminarPlatos(pla);
        }
        #endregion metodos
    }
}
