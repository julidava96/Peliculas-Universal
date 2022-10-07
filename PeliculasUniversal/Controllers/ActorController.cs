using Microsoft.AspNetCore.Mvc;
using PeliculasUniversal.Models;

namespace PeliculasUniversal.Controllers
{
    public class ActorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AgregarActor()
        {
            return View();
        }

        public IActionResult CrearActor(ActorViewModel Actor)
        {
            return View();
        }
    }
}
