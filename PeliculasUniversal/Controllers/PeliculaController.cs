using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PeliculasUniversal.Models;
using PeliculasUniversal.Services;

namespace PeliculasUniversal.Controllers
{
    public class PeliculaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AgregarPelicula()
        {
            GeneroService generoService = new GeneroService();
            var listaEntity = generoService.ListarGeneros();
             
            var model = new AgregarPeliculaViewModel();
            model.ListaGeneros = new List<SelectListItem>();
            foreach(var entity in listaEntity)
            {
                model.ListaGeneros.Add(new SelectListItem
                {
                    Value = entity.Id.ToString(),
                    Text = entity.Descripcion
                });
            }
            return View(model);
            
        }


        [HttpPost]
        public IActionResult CrearPelicula(PeliculaViewModel pelicula)
        {

            PeliculasService peliculasService = new PeliculasService();
            peliculasService.AgregarPelicula(pelicula);

            return View("AgregarPelicula");
        }

    }
}
