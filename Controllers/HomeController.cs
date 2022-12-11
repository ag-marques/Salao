using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Salao.Models;

namespace Salao.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {        
        ViewData["empresa"]  = "Cíntia Morães Studio";
        ViewData["endereco"] = "Rua Cinco, 42 - Jardim Encantado - Vespasiano/MG";
        ViewData["telefone"] = "31 98786-8580";
        ViewData["desenv"] = "by Anderson Marques";

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
