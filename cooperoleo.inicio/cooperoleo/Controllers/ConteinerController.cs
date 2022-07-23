using cooperoleo.Contexto;
using cooperoleo.Models;
using cooperoleo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace cooperoleo.Controllers
{
    public class ConteinerController : Controller
    {
        private readonly ConteinerRepository conteinerRepository;

        public ConteinerController(CooperContext contexto)
        {
            conteinerRepository = new ConteinerRepository(contexto);
        }

        public IActionResult Index()
        {
            var listaConteineres = conteinerRepository.FindAll();

            return View(listaConteineres);
        }
    }
}
