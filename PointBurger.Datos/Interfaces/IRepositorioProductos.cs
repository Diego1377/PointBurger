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
    public interface IRepositorioProductos
    {
        void Agregar(Producto producto, SqlConnection conn, SqlTransaction? tran = null);
        void Borrar(int productoId, SqlConnection conn, SqlTransaction? tran = null);
        void Editar(Producto producto, SqlConnection conn, SqlTransaction? tran = null);
        bool Existe(Producto producto, SqlConnection conn, SqlTransaction? tran = null);
        List<ProductosListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<ProductosListDto, bool>? filter = null, SqlTransaction? tran = null);
        int GetCantidad(SqlConnection conn, Func<ProductosListDto, bool>? filter = null, SqlTransaction? tran = null);
        int GetProductoIdIfExists(Producto producto, SqlConnection conn, SqlTransaction? tran = null);
        Producto? GetProductoPorId(int productoId, SqlConnection conn, SqlTransaction? tran = null);

    }
}
