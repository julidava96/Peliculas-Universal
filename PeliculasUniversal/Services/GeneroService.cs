using PeliculasUniversal.Repository.Entity;
using PeliculasUniversal.Repository;

namespace PeliculasUniversal.Services
{
    public class GeneroService
    {
        public List<GeneroEntity> ListarGeneros ()
        {

            GeneroRepository repository = new GeneroRepository();
            List<GeneroEntity> result = repository.ListarGeneros();
            return result;
        }

    }
}
