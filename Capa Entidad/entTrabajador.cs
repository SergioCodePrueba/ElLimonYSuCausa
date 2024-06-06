using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    class Entidad_Trabajador
    {
        public int idTrabajador { get; set; }
        public int idPersona { get; set; }
        public int idTipoTrabajador { get; set; }
        public int idTipoContrato { get; set; }
        public float SalarioTrabajador { get; set; }
        public DateTime FechaIngresoTrabajador { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}
