using PointBurger.Entidades.Dtos;
using PointBurger.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointBurger.Datos.Interfaces
{
    public interface IRepositorioEmpleados
    {
        void Agregar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null);
        void Borrar(int empleadoId, SqlConnection conn, SqlTransaction? tran = null);
        void Editar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null);
        bool Existe(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null);
        int GetCantidad(SqlConnection conn, Func<EmpleadosListDto, bool>? filter = null, SqlTransaction? tran = null);
        Empleado? GetClientePorId(int empleadoID, SqlConnection conn);
        List<EmpleadosListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<EmpleadosListDto, bool>? filter = null, SqlTransaction? tran = null);
    }
}
