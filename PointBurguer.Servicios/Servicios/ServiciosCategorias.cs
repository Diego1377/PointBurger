using PointBurger.Datos.Interfaces;
using PointBurger.Datos.Repositorios;
using PointBurger.Entidades.Dtos;
using PointBurger.Entidades.Entidades;
using PointBurguer.Servicios.Interfaces;
using System.Data.SqlClient;

namespace PointBurguer.Servicios.Servicios
{
    public class ServiciosCategorias : IServiciosCategorias
    {
        private readonly IRepositorioCategorias? _repositorio;
        private readonly string? _cadena;
        public ServiciosCategorias(IRepositorioCategorias? repositorio, string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
            _cadena = cadena;
        }
        public bool Existe(Categoria categoria)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(categoria, conn);

            }
        }
        public List<Categoria> GetLista()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn);
            }
        }
        public void Guardar(Categoria categoria)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();

                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (categoria.CategoriaId == 0)
                        {
                            _repositorio!.Agregar(categoria, conn, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(categoria, conn, tran);
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
        public void Borrar(int categoriaId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();

                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(categoriaId, conn, tran);
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

        public bool EstaRelacionado(int categoriaId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.EstaRelacionado(categoriaId, conn);
            }
        }
    }
}
