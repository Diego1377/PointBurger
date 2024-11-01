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
    public class RepositorioProductos:IRepositorioProductos
    {
        public RepositorioProductos()
        {

        }

        public void Agregar(Producto producto, SqlConnection conn, SqlTransaction? tran = null)
        {
            string insertQuery = @"INSERT INTO Productos (Nombre, Descripcion, 
                                                            CategoriaId, 
                                                            PrecioCosto, PrecioVenta, 
                                                            Stock)
                                    VALUES (@Nombre, @Descripcion, 
                                                            @CategoriaId, 
                                                            @PrecioCosto, @PrecioVenta, 
                                                            @Stock);
                                    SELECT CAST(SCOPE_IDENTITY() AS INT)";
            var primaryKey = conn.QuerySingle<int>(insertQuery, producto, tran);
            if (primaryKey > 0)
            {

                producto.ProductoId = primaryKey;
                return;
            }

            throw new Exception("No se pudo agregar el Producto");
        }

        public void Borrar(int productoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            var deleteQuery = @"DELETE FROM Productos 
                WHERE ProductoID=@ProductoID";
            int registrosAfectados = conn
                .Execute(deleteQuery, new { productoId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo borrar el Producto");
            }
        }

        public void Editar(Producto producto, SqlConnection conn, SqlTransaction? tran = null)
        {
            string updateQuery = @"UPDATE Productos SET 
                                         Nombre=@Nombre, 
                                         Descripcion=@Descripcion, 
                                         CategoriaId = @CategoriaId, 
                                         PrecioCosto = @PrecioCosto, 
                                         PrecioVenta=@PrecioVenta, 
                                         Stock = @Stock
                                        WHERE ProductoId = @ProductoId";
            int registrosAfectados = conn.Execute(updateQuery, producto, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar el Producto");
            }

        }

        public bool EstaRelacionado(int tipoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Producto producto, SqlConnection conn, SqlTransaction? tran = null)
        {
            try
            {
                string selectQuery = @"SELECT COUNT(*) FROM Productos ";
                string finalQuery = string.Empty;
                string conditional = string.Empty;
                if (producto.ProductoId == 0)
                {
                    conditional = "WHERE Nombre=@Nombre";
                }
                else
                {
                    conditional = @"WHERE Nombre=@Nombre
                            AND ProductoId<>@ProductoId";
                }
                finalQuery = string.Concat(selectQuery, conditional);
                return conn.QuerySingle<int>(finalQuery, producto) > 0;

            }
            catch (Exception)
            {

                throw new Exception("No se pudo comprobar si existe el Producto");
            }
        }

        public int GetCantidad(SqlConnection conn, Func<ProductosListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT * FROM Productos";
            var query = conn.Query<ProductosListDto>(selectQuery).ToList();
            if (filter != null)
            {
                query = query.Where(filter).ToList();
            }
            return query.Count;
        }

        public List<ProductosListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<ProductosListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT
	                        C.Nombre AS NombreCategoria,
	                        P.Nombre,
	                        P.PrecioCosto,
	                        P.PrecioVenta,
	                        P.Stock	
                            FROM PRODUCTOS P
                            INNER JOIN Categorias C ON P.CategoriaId=C.CategoriaId 
                            ORDER BY NombreCategoria";
            var lista = conn.Query<ProductosListDto>(selectQuery, transaction: tran).ToList();
            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }


        public int GetProductoIdIfExists(Producto producto, SqlConnection conn, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT ProductoId FROM Productos
                                WHERE Nombre = @Nombre";
            return conn.ExecuteScalar<int>(selectQuery, producto, tran);
        }

        public Producto? GetProductoPorId(int productoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            var query = @"SELECT * FROM Productos
                                WHERE ProductoId = @ProductoId";
            return conn.QuerySingleOrDefault<Producto>(query, new { ProductoId = productoId }, tran);
        }
    }
}
