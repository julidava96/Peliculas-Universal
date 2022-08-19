using Microsoft.AspNetCore.Mvc;
using PeliculasUniversal.Models;
using System.Diagnostics;

namespace PeliculasUniversal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
            PeliculaViewModel peliculas = new PeliculaViewModel()
            {
                Nombre = "Duro de matar",
                Anio = 2010
            };

            return View(peliculas);
        }

        public IActionResult Actor()
        {
            ActorViewModel actores = new ActorViewModel()
            {
                Nombre = "La",
                Apellido = "Roca"
            };
            return View(actores);

        }

        public IActionResult Director()
        {
            DirectorViewModel directores = new DirectorViewModel()
            {
                Nombre = "Quentin",
                Apellido = "Tarantino"
            };
            return View(directores);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}