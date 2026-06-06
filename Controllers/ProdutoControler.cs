using Microsoft.AspNetcore.Mvc;
namespace catalogo_de_produto_com_Condicionais.controllers
{
    public class ProdutoController : Controller
{
    public IActionResult Index()
{
    List<string> produtos = new List<string>()
    {
        "PlayStation 5",
        "Notebook",
        "Mouse",
        "Teclado",
        "Monitor",
    };

    List<double> precos = new List<double>()
    {
        4500,
        3500,
        80,
        150,
        900,
    };
    Viewbag.Produto = produtos;
    Viewbag.precos = precos;
    return View();

}
}
}
