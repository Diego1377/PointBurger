using PointBurger.Datos.Interfaces;
using PointBurger.Datos.Repositorios;
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
    public class ServiciosProductos : IServiciosProductos
    {
        private readonly IRepositorioProductos? _repositorio;
        private readonly string? _cadena;

        public ServiciosProductos(IRepositorioProductos? repositorio, string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
            _cadena = cadena;
        }

        public void Borrar(int productoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();

                using ( var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(productoId, conn, tran);
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

        public bool Existe(Producto producto)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(producto, conn);

            }
        }

        public int GetCantidad(Func<ProductosListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter);
            }
        }

        public List<ProductosListDto> GetLista(int currentPage, int pageSize, Func<ProductosListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, currentPage, pageSize, filter);
            }
        }


        public Producto? GetProductoPorId(int productoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                var producto = _repositorio!.GetProductoPorId(productoId, conn);
                return producto;
            }
        }

        public void Guardar(Producto producto)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();

                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (producto.ProductoId == 0)
                        {
                            _repositorio!.Agregar(producto, conn, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(producto, conn, tran);
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
