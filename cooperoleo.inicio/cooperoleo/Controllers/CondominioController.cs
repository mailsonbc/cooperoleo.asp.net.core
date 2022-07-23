using cooperoleo.Contexto;
using cooperoleo.Models;
using cooperoleo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace cooperoleo.Controllers
{
    public class CondominioController : Controller
    {
        private readonly CondominoRepository condominoRepository;

        public CondominioController(CooperContext context)
        {
            condominoRepository = new CondominoRepository(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaCondominios = condominoRepository.FindAll();
            return View(listaCondominios);
        }

        [HttpGet]
        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Inserir(CondominioModel condominio)
        {            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {            
            return View();
        }

        [HttpPost]
        public IActionResult Editar(CondominioModel condominio)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Detalhar(int id)
        {            
            return View();
        }
    }
}
