using Microsoft.AspNetCore.Mvc;
using PeliculasUniversal.Models;

namespace PeliculasUniversal.Controllers
{
    public class DirectorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AgregarDirector()
        {
            return View();
        }

        public IActionResult CrearDirector(DirectorViewModel Director)
        {
            return View();
        }
    }
}
