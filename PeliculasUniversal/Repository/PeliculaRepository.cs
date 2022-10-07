using Dapper;
using PeliculasUniversal.Repository.Entity;
using System.Data.SqlClient;

namespace PeliculasUniversal.Repository
{
    public class PeliculaRepository
    {
        public void InsertarPelicula(PeliculasEntity peliculas)
        {
            string conection = "Server=.\\sqlexpress;Database=Universal; Trusted_Connection=True; "; // para obtener conexion con la base de datos SQL

            var con = new SqlConnection(conection);
            con.Open();     //abre la conexion a la base de datos

            //var peliculas = con.Query<PeliculasEntity>("select Nombre, IdGenero, Anio FROM Peliculas");

            con.Execute("insert into peliculas(Nombre, Anio, IdGenero, IdDirector, IdActores) values (@Nombre, @Anio, @IdGenero, @IdDirector, @IdActor)", peliculas);

            con.Close(); //cierra la conexion a la base de datos

        }


    }
}
