using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using catalogo_de_produto_Com_Condicionais.Models;

namespace catalogo_de_produto_Com_Condicionais.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
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
