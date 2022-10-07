using Dapper;
using PeliculasUniversal.Repository.Entity;
using System.Data.SqlClient;

namespace PeliculasUniversal.Repository
{
    public class GeneroRepository
    {

        public List<GeneroEntity> ListarGeneros ()
        {
            var genero = new List<GeneroEntity>();

            string conection = "Server=.\\sqlexpress;Database=Universal; Trusted_Connection=True; "; // para obtener conexion con la base de datos SQL

            var con = new SqlConnection(conection);
            con.Open();     //abre la conexion a la base de datos

            //var peliculas = con.Query<PeliculasEntity>("select Nombre, IdGenero, Anio FROM Peliculas");

            genero=con.Query<GeneroEntity>("select Id, Descripcion from genero").ToList();

            con.Close(); //cierra la conexion a la base de datos

            return genero;
        }

    }
}
