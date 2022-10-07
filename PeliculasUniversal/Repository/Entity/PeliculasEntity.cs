using static Dapper.SqlMapper;

namespace PeliculasUniversal.Repository.Entity
{
    public class PeliculasEntity
    {
        
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Anio { get; set; }
        public int IdGenero { get; set; }
        public int IdDirector { get; set; }
        public int IdActor { get; set; }
    }
}
