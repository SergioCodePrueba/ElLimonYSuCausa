using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPersonaTrabajador
    {
        public int idPersona { get; set; }
        public string NombrePersona { get; set; }
        public string ApellidosPersona { get; set; }
        public string Tipo_Documento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Tipo_Trabajador { get; set; }
        public string Tipo_Contrato { get; set; } 
        public float SalarioTrabajador { get; set; }
        public DateTime FechaIngresoTrabajador { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}
