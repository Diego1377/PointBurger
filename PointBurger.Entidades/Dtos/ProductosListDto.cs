using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointBurger.Entidades.Dtos
{
    public class ProductosListDto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string NombreCategoria { get; set; } = null!;
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
    }
}
