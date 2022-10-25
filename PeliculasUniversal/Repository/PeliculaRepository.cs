using Dapper;
using PeliculasUniversal.Repository.Entity;
using System.Data.SqlClient;

namespace PeliculasUniversal.Repository
{
    public class PeliculaRepository
    {
        private readonly SqlConnection conection;
        public PeliculaRepository(SqlConnection conection)
        {
            this.conection = conection;

        }
        public void InsertarPelicula(PeliculasEntity peliculas)
        {

            conection.Open();     //abre la conexion a la base de datos

            //var peliculas = con.Query<PeliculasEntity>("select Nombre, IdGenero, Anio FROM Peliculas");

            conection.Execute("insert into peliculas(Nombre, Anio, IdGenero, IdDirector, IdActores) values (@Nombre, @Anio, @IdGenero, @IdDirector, @IdActor)", peliculas);

            conection.Close(); //cierra la conexion a la base de datos

        }


    }
}
