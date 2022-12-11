using Microsoft.AspNetCore.Mvc;
using Salao.Models;

namespace Salao.Controllers
{
    [Route("[controller]")]
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            List<Cliente> list = new List<Cliente>();
            list.Add(new Cliente { Id_Cliente = 1, Nome = "Emilly Luiza Flausino Marques", Endereco = "Rua Moura lima, 268 - Jardim da Glória - Vespasiano/MG - 33206-076", Aniversario = "07/04", DataCad = DateTime.Parse("2022-12-11") });
            list.Add(new Cliente { Id_Cliente = 2, Nome = "Vanessa Gaciele Marques", Endereco = "Rua Moura lima, 256 - Jardim da Glória - Vespasiano/MG - 33206-076", Aniversario = "07/04", DataCad = DateTime.Parse("2022-12-11") });
            list.Add(new Cliente { Id_Cliente = 3, Nome = "Eriadna Costa Nunes", Endereco = "Rua Silvestre, 300 - Jardim da Glória - Vespasiano/MG - 33200-000", Aniversario = "07/04", DataCad = DateTime.Parse("2022-12-11") });
            return View(list);
        }
    }
}