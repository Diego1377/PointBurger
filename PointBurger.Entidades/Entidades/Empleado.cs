﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointBurger.Entidades.Entidades
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int Salario { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNac { get; set; }
        public int Comision { get; set; }
    
    }
}
