using cooperoleo.Contexto;
using cooperoleo.Models;
using cooperoleo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace cooperoleo.Controllers
{
    public class ContatoController : Controller
    {
        private readonly ContatoRepository contatoRepository;

        public ContatoController(CooperContext contexto)
        {
            contatoRepository = new ContatoRepository(contexto);
        }

        public IActionResult Index()
        {
            var listaContatos = contatoRepository.FindAll();
            return View(listaContatos);
        }
    }
}
