using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    class Entidad_Platos
    {
        public int idProducto { get; set; } //Plato
        public int idTipoProducto { get; set; } //Categoria
        public string NombreProducto { get; set; }
        public float PrecioProducto { get; set; }
    }
}
