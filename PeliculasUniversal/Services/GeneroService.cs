using PeliculasUniversal.Repository.Entity;
using PeliculasUniversal.Repository;

namespace PeliculasUniversal.Services
{
    public class GeneroService    
    {
        private readonly GeneroRepository generoRepository;
        public GeneroService(GeneroRepository generoRepository)
        {
            this.generoRepository = generoRepository;
        }
        public List<GeneroEntity> ListarGeneros ()
        {

            List<GeneroEntity> result = generoRepository.ListarGeneros();
            return result;
        }

    }
}
