using PointBurger.Datos.Interfaces;
using PointBurger.Entidades.Dtos;
using PointBurger.Entidades.Entidades;
using PointBurguer.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointBurguer.Servicios.Servicios
{
    public class ServiciosEmpleados : IServiciosEmpleados
    {
        private readonly IRepositorioEmpleados? _repositorio;
        private readonly string? _cadena;

        public ServiciosEmpleados(IRepositorioEmpleados? repositorio, string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
            _cadena = cadena;
        }

        public void Borrar(int empleadoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();

                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(empleadoId, conn, tran);
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }

                }
            }
        }


        public bool Existe(Empleado empleado)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(empleado, conn);

            }
        }

        public int GetCantidad(Func<EmpleadosListDto, bool>? filter)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter);
            }
        }

        public Empleado? GetClientePorId(int empleadoID)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                var empleado = _repositorio.GetClientePorId(empleadoID, conn);
                return empleado;
            }
        }

        public List<EmpleadosListDto> GetLista(int currentPage, int pageSize, Func<EmpleadosListDto, bool>? filter = null)
        {
            using(var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, currentPage, pageSize, filter);
            }
        }

        public void Guardar(Empleado empleado)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();

                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (empleado.EmpleadoID == 0)
                        {
                            _repositorio!.Agregar(empleado, conn, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(empleado, conn, tran);
                        }
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }

                }
            }
        }
    }
}
