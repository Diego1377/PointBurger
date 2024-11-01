using PointBurger.Entidades.Dtos;
using PointBurger.Entidades.Entidades;
using System.Data.SqlClient;


namespace PointBurger.Datos.Interfaces
{
    public interface IRepositorioCategorias
    {
        void Agregar(Categoria categoria, SqlConnection conn, SqlTransaction? tran = null);
        void Borrar(int categoriaId, SqlConnection conn, SqlTransaction? tran = null);
        void Editar(Categoria categoria, SqlConnection conn, SqlTransaction? tran = null);
        bool EstaRelacionado(int tipoId, SqlConnection conn, SqlTransaction? tran = null);
        bool Existe(Categoria categoria, SqlConnection conn, SqlTransaction? tran = null);
        List<Categoria> GetLista(SqlConnection conn, SqlTransaction? tran = null);

    }
}
