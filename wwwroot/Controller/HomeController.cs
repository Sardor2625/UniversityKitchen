using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UniversityKitchen.Excpetion;

namespace UniversityKitchen.wwwroot.Controller;

public class HomeController(ILogger<HomeController> logger) : Microsoft.AspNetCore.Mvc.Controller
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
        return View(new ErrorView { RequestedId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}