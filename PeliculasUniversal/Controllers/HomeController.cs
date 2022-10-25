using Microsoft.AspNetCore.Mvc;
using PeliculasUniversal.Models;
using PeliculasUniversal.Services;
using System.Diagnostics;

namespace PeliculasUniversal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PeliculasService peliculasService;
        public HomeController(ILogger<HomeController> logger, PeliculasService peliculasService)
        {
            _logger = logger;
            this.peliculasService = peliculasService;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Pelicula()
        {
            var peliculaListDB = peliculasService.ObtenerPeliculas();

            PeliculasViewModel pelicula2 = new PeliculasViewModel();

            pelicula2.PeliculaList = new List<PeliculaViewModel>();

            foreach (var peliculaDB in peliculaListDB) 
            {
                PeliculaViewModel peliculaVM = new PeliculaViewModel();
                peliculaVM.Anio = peliculaDB.Anio;
                peliculaVM.Nombre = peliculaDB.Nombre;
                pelicula2.PeliculaList.Add(peliculaVM);

            }
            
            return View(pelicula2);
        }

        public IActionResult Actor()
        {
            

            var actorListDB = peliculasService.ObtenerActor();

            ActoresViewModel actor2 = new ActoresViewModel();

            actor2.ActoresList = new List<ActorViewModel>();

            foreach(var actorDB in actorListDB)
            {
                ActorViewModel actorVM = new ActorViewModel();
                actorVM.Nombre = actorDB.NombreYapellido;
                actorVM.edad = actorDB.edad;
                actor2.ActoresList.Add(actorVM);
            }
           return View(actor2);

        }

        public IActionResult Director()
        {
           
            var directorListDB = peliculasService.ObtenerDirector();

            DirectoresViewModel director2 = new DirectoresViewModel();
            director2.DirectoresList = new List<DirectorViewModel>();

            foreach(var directorDB in directorListDB)
            {
                DirectorViewModel directorVM = new DirectorViewModel();
                directorVM.Nombre = directorDB.nombreApellido;
                directorVM.Edad = directorDB.edad;
                directorVM.PaisOrigen = directorDB.PaisOrigen;
                director2.DirectoresList.Add(directorVM);
            };

            return View(director2);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}