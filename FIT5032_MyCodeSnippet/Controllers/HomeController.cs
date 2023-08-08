using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FIT5032_MyCodeSnippet.Models;
using FIT5032_MyCodeSnippet.Models.HellowWorld;

namespace FIT5032_MyCodeSnippet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public ActionResult About()
    {
        // I commented this line out
        //ViewBag.Message = "Your application description page.";
        // I created an instance of the Hello object
        Hello hello = new Hello();
        // I assigned the ViewBag.Message to the result
        ViewBag.Message = hello.GetHello();

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

