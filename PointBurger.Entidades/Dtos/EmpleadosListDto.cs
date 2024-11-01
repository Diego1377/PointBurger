using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointBurger.Entidades.Dtos
{
    public class EmpleadosListDto
    {
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public decimal Salario { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNac { get; set; }
        public decimal Comision { get; set; }
    }
}
