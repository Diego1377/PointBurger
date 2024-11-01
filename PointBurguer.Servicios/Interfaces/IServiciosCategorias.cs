using PointBurger.Entidades.Dtos;
using PointBurger.Entidades.Entidades;

namespace PointBurguer.Servicios.Interfaces
{
    public interface IServiciosCategorias
    {
        void Borrar(int categoriaId);
        bool EstaRelacionado(int categoriaId);
        bool Existe(Categoria categoria);
        List<Categoria> GetLista();
        void Guardar(Categoria categoria);
    }
}
