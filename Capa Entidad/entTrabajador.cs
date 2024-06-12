using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTrabajador
    {
        public int idTrabajador { get; set; }
        public entPersona idPersona { get; set; }
        public int idTipoTrabajador { get; set; }
        public int idTipoContrato { get; set; }
        public float SalarioTrabajador { get; set; }
        public DateTime FechaIngresoTrabajador { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}
