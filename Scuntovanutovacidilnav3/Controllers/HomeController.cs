using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        Generator generator = new Generator();
        ViewBag.Cislo = generator.VratCislo();
        return View();
    }
}
