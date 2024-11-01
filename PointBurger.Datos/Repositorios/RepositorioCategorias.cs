using PointBurger.Datos.Interfaces;
using PointBurger.Entidades.Entidades;
using Dapper;
using System.Data.SqlClient;
using PointBurger.Entidades.Dtos;
using System.Linq;


namespace PointBurger.Datos.Repositorios
{
    public class RepositorioCategorias : IRepositorioCategorias
    {
        public RepositorioCategorias()
        {

        }

        public void Agregar(Categoria cat, SqlConnection conn, SqlTransaction? tran = null)
        {
            string insertQuery = @"INSERT INTO Categorias (Nombre) 
                    VALUES(@Nombre); SELECT CAST(SCOPE_IDENTITY() as int)";

            var primaryKey = conn.QuerySingle<int>(insertQuery, cat, tran);
            if (primaryKey > 0)
            {

                cat.CategoriaId = primaryKey;
                return;
            }

            throw new Exception("No se pudo agregar la Categoria");
        }

        public void Borrar(int catId, SqlConnection conn, SqlTransaction? tran = null)
        {
            string deleteQuery = @"DELETE FROM Categorias 
                    WHERE CategoriaId=@CatId";
            int registrosAfectados = conn
                .Execute(deleteQuery, new { catId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo borrar la Categoria");
            }
        }

        public void Editar(Categoria categoria, SqlConnection conn, SqlTransaction? tran = null)
        {
            string updateQuery = @"UPDATE Categorias SET Nombre=@Nombre 
                    WHERE CategoriaId=@CategoriaId";

            int registrosAfectados = conn.Execute(updateQuery, categoria, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar la Categoria");
            }
        }

        public bool EstaRelacionado(int tipoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            string selectQuery = @"SELECT COUNT(*) 
                            FROM Productos 
                                WHERE CategoriaId=@TipoId";
            return conn.
                QuerySingle<int>(selectQuery, new { tipoId }) > 0;
        }

        public bool Existe(Categoria categoria, SqlConnection conn, SqlTransaction? tran = null)
        {
            string selectQuery = @"SELECT COUNT(*) FROM Categorias ";
            string finalQuery = string.Empty;
            string conditional = string.Empty;
            if (categoria.CategoriaId == 0)
            {
                conditional = "WHERE Nombre = @Nombre";
            }
            else
            {
                conditional = @"WHERE Nombre = @Nombre
                                AND CategoriaId<>@CategoriaId";
            }
            finalQuery = string.Concat(selectQuery, conditional);
            return conn.QuerySingle<int>(finalQuery, categoria) > 0;
        }

        public List<Categoria> GetLista(SqlConnection conn, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT CategoriaId, Nombre FROM 
                    Categorias ORDER BY Nombre";
            return conn.Query<Categoria>(selectQuery).ToList();
        }
    }
}
