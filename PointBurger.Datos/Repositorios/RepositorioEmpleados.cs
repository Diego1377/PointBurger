using Dapper;
using PointBurger.Datos.Interfaces;
using PointBurger.Entidades.Dtos;
using PointBurger.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointBurger.Datos.Repositorios
{
    public class RepositorioEmpleados:IRepositorioEmpleados
    {
        public RepositorioEmpleados()
        {

        }

        public void Agregar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null)
        {
            string insertQuery = @"INSERT INTO Empleados (Nombre, Apellido, Salario, Telefono, FechaNac, Comision) 
                    VALUES(@Nombre, @Apellido, @Salario, @Telefono, @FechaNac, @Comision); 
                    SELECT CAST(SCOPE_IDENTITY() as int)";

            var primaryKey = conn.QuerySingle<int>(insertQuery, empleado, tran);
            if (primaryKey > 0)
            {

                empleado.EmpleadoID = primaryKey;
                return;
            }

            throw new Exception("No se pudo agregar el Empleado");
        }

        public void Borrar(int empleadoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            var deleteQuery = @"DELETE FROM Empleados 
                WHERE EmpleadoID=@EmpleadoID";
            int registrosAfectados = conn
                .Execute(deleteQuery, new { empleadoId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo borrar el empleado");
            }
        }

        public void Editar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null)
        {
            var updateQuery = @"UPDATE Empleados
            SET Nombre=@Nombre,
                Apellido=@Apellido,
                Salario=@Salario,
                Telefono=@Telefono,
                FechaNac=@FechaNac,
                Comision=@Comision
            WHERE EmpleadoId=@EmpleadoId";
            int registrosAfectados = conn.Execute(updateQuery, empleado, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar el empleado");
            }
        }

        

        public bool Existe(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null)
        {
            try
            {
                string selectQuery = @"SELECT COUNT(*) FROM Empleados ";
                string finalQuery = string.Empty;
                string conditional = string.Empty;
                if (empleado.EmpleadoID == 0)
                {
                    conditional = "WHERE Telefono = @Telefono AND Nombre=@Nombre AND Apellido=@Apellido";
                }
                else
                {
                    conditional = @"WHERE Telefono = @Telefono AND Nombre=@Nombre AND Apellido=@Apellido
                            AND EmpleadoId<>@EmpleadoId";
                }
                finalQuery = string.Concat(selectQuery, conditional);
                return conn.QuerySingle<int>(finalQuery, empleado) > 0;

            }
            catch (Exception)
            {

                throw new Exception("No se pudo comprobar si existe el Empleado");
            }
        }

        public int GetCantidad(SqlConnection conn, Func<EmpleadosListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT * FROM Empleados";
            var query = conn.Query<EmpleadosListDto>(selectQuery).ToList();
            if (filter != null)
            {
                query = query.Where(filter).ToList();
            }
            return query.Count;
        }

        public Empleado? GetClientePorId(int empleadoID, SqlConnection conn)
        {
            string selectQuery = @"SELECT EmpleadoId, Nombre, Apellido, Salario, Telefono, FechaNac, Comision
                FROM Empleados 
                WHERE EmpleadoId=@EmpleadoId";
            var empleado = conn.QuerySingleOrDefault<Empleado>(selectQuery, new { @EmpleadoId = empleadoID });

            // Si el empleado no existe, retornamos null
            if (empleado == null)
            {
                return null;
            }
            return empleado;
        }

        public List<EmpleadosListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<EmpleadosListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT EmpleadoId, Nombre, Apellido, Salario, Telefono, FechaNac, Comision FROM 
                    Empleados ORDER BY Nombre";
            var lista = conn.Query<EmpleadosListDto>(selectQuery, transaction: tran).ToList();
            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
