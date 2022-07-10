using cooperoleo.Models;
using Microsoft.AspNetCore.Mvc;

namespace cooperoleo.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            var listaContatos = new List<ContatoModel>();
            listaContatos.Add(new ContatoModel()
            {
                ContatoId = 1,
                Nome = "Antônio",
                Cpf = "123.456.789-00",
                Telefone = "13 98756-5214",
                NomeCondominio = "Edifício Azaleia",
                Endereco = "Rua Um, 23",
                Ativo = true
            });

            listaContatos.Add(new ContatoModel()
            {
                ContatoId = 2,
                Nome = "Maria",
                Cpf = "789.456.123-11",
                Telefone = "13 98596-9856",
                NomeCondominio = "Edifício Rio de Janeiro",
                Endereco = "Rua Dois, 203",
                Ativo = true
            });

            listaContatos.Add(new ContatoModel()
            {
                ContatoId = 3,
                Nome = "Pedro",
                Cpf = "456.963.258-25",
                Telefone = "13 99742-3201",
                NomeCondominio = "Edifício Antilhas",
                Endereco = "Rua Pedro Álvares Cabral, 50",
                Ativo = true
            });

            listaContatos.Add(new ContatoModel()
            {
                ContatoId = 4,
                Nome = "Lúcia",
                Cpf = "147.852.369-63",
                Telefone = "13 99852-9820",
                NomeCondominio = "Edifício Espanha",
                Endereco = "Avenida Getúlio Vargas, 1450",
                Ativo = true
            });
            return View(listaContatos);
        }
    }
}
