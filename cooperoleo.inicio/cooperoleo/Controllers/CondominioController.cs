using cooperoleo.Models;
using Microsoft.AspNetCore.Mvc;

namespace cooperoleo.Controllers
{
    public class CondominioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var listaCondominios = new List<CondominioModel>();
            listaCondominios.Add(new CondominioModel
            {
                CondominioId = 1,
                Contato = "Antônio",
                Endereco = "Rua Um, 23",
                NomeCondominio = "Edifício Azaleia",
                ConteinerId = 1,
                Ativo = true
            });

            listaCondominios.Add(new CondominioModel
            {
                CondominioId = 2,
                Contato = "Maria",
                Endereco = "Rua Dois, 203",
                NomeCondominio = "Edifício Rio de Janeiro",
                ConteinerId = 2,
                Ativo = true
            });

            listaCondominios.Add(new CondominioModel
            {
                CondominioId = 3,
                Contato = "Pedro",
                Endereco = "Rua Pedro Álvares Cabral, 50",
                NomeCondominio = "Edifício Antilhas",
                ConteinerId = 3,
                Ativo = true
            });

            listaCondominios.Add(new CondominioModel
            {
                CondominioId = 4,
                Contato = "Lúcia",
                Endereco = "Avenida Getúlio Vargas, 1450",
                NomeCondominio = "Edifício Espanha",
                ConteinerId = 4,
                Ativo = true
            });

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
    }
}
