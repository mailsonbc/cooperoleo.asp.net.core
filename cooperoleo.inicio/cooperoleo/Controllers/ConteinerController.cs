using cooperoleo.Models;
using Microsoft.AspNetCore.Mvc;

namespace cooperoleo.Controllers
{
    public class ConteinerController : Controller
    {
        public IActionResult Index()
        {
            var listaConteineres = new List<ConteinerModel>();
            listaConteineres.Add(new ConteinerModel()
            {
                ConteinerId = 1,
                Disponibilidade = false,
                Localizacao = "Edifício Azaleia",
                Ativo = true
            });

            listaConteineres.Add(new ConteinerModel()
            {
                ConteinerId = 2,
                Disponibilidade = false,
                Localizacao = "Edifício Rio de Janeiro",
                Ativo = true
            });

            listaConteineres.Add(new ConteinerModel()
            {
                ConteinerId = 3,
                Disponibilidade = false,
                Localizacao = "Edifício Antilhas",
                Ativo = true
            });

            listaConteineres.Add(new ConteinerModel()
            {
                ConteinerId = 4,
                Disponibilidade = false,
                Localizacao = "Edifício Espanha",
                Ativo = true
            });

            return View(listaConteineres);
        }
    }
}
