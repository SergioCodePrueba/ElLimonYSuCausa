using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPlatos
    {
        public int id_Producto { get; set; } //Plato
        public int idTipoProducto { get; set; } //Categoria
        public string Categoria { get; set; }
        public string Nombre_Producto { get; set; }
        public float Precio_Producto { get; set; }
    }
}
