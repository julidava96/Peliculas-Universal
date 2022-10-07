using Dapper;
using PeliculasUniversal.Models;
using PeliculasUniversal.Repository;
using PeliculasUniversal.Repository.Entity;
using System.Data.SqlClient;

namespace PeliculasUniversal.Services
{
    public class PeliculasService
    {
        public List <PeliculasEntity> ObtenerPeliculas()
        {

            UniversalRepository repository = new UniversalRepository();
           List <PeliculasEntity> result = repository.ObtenerPeliculas();
            return result;   
        }

        public void AgregarPelicula(PeliculaViewModel pelicula)
        {
            PeliculasEntity peliculaEntity = new PeliculasEntity()
            {
                Nombre = pelicula.Nombre,
                Anio = pelicula.Anio,
                IdActor = pelicula.IdActor,
                IdDirector = pelicula.IdDirector,
                IdGenero = pelicula.IdGenero        
            };

            PeliculaRepository peliculaRepository = new PeliculaRepository();
            peliculaRepository.InsertarPelicula(peliculaEntity);
                    
            
        }
        public List <ActorEntitycs> ObtenerActor ()
        {
            UniversalRepository repository = new UniversalRepository();
           List <ActorEntitycs> result = repository.ObtenerActor();

            return result;

        }

        public List<DirectorEntity> ObtenerDirector()
        {
            UniversalRepository repository = new UniversalRepository ();
            List<DirectorEntity> result = repository.ObtenerDirector();

            return result;

        }
    }
}
