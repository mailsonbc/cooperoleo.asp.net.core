using cooperoleo.Models;
using Microsoft.AspNetCore.Mvc;

namespace cooperoleo.Controllers
{
    public class CondominioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {    
            return View();
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
