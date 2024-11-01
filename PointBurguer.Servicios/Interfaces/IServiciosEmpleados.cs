using PointBurger.Entidades.Dtos;
using PointBurger.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointBurguer.Servicios.Interfaces
{
    public interface IServiciosEmpleados
    {
        void Borrar(int empleadoId);
        bool Existe(Empleado empleado);
        int GetCantidad(Func<EmpleadosListDto, bool>? filter);
        Empleado? GetClientePorId(int empleadoID);
        List<EmpleadosListDto> GetLista(int currentPage, int pageSize, Func<EmpleadosListDto, bool>? filter = null);
        void Guardar(Empleado empleado);
    }
}
