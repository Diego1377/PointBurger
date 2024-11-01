using PointBurger.Entidades.Dtos;
using PointBurger.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PointBurguer.Servicios.Interfaces
{
    public interface IServiciosProductos
    {
        void Borrar(int productoId);
        bool Existe(Producto producto);
        int GetCantidad(Func<ProductosListDto, bool>? filter = null);
        List<ProductosListDto> GetLista(int currenPage, int pageSize, Func<ProductosListDto, bool>? filter = null);
        void Guardar(Producto producto);
        Producto? GetProductoPorId(int productoId);
    }
}
