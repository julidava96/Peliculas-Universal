using Dapper;
using PeliculasUniversal.Repository.Entity;
using System.Data.SqlClient;

namespace PeliculasUniversal.Repository
{
    public class UniversalRepository
    {
        public List<PeliculasEntity> ObtenerPeliculas()
        {
            string conection = "Server=.\\sqlexpress;Database=Universal; Trusted_Connection=True; "; // para obtener conexion con la base de datos SQL

            var con = new SqlConnection(conection);
            con.Open();     //abre la conexion a la base de datos

            var peliculas = con.Query<PeliculasEntity>("select Nombre, IdGenero, Anio FROM Peliculas");

            con.Close(); //cierra la conexion a la base de datos

            return peliculas.ToList();
        }

        public List<ActorEntitycs> ObtenerActor()
        {
            string conection = "Server=.\\sqlexpress;Database=Universal; Trusted_Connection=True; ";

            var con = new SqlConnection(conection);
            con.Open();

            var NombreActor = con.Query<ActorEntitycs>("select NombreYapellido, edad FROM actores");

            con.Close();

            return NombreActor.ToList();

        }

        public List<DirectorEntity> ObtenerDirector()
        {
            string conection = "Server=.\\sqlexpress;Database=Universal; Trusted_Connection=True; ";

            var con = new SqlConnection(conection);
            con.Open();

            var NombreDirector = con.Query<DirectorEntity>("select NombreApellido, edad, PaisOrigen FROM directores");

            con.Close();

            return NombreDirector.ToList();


        }

    }
}