using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DIEX.Models;
using DIEXData;

namespace DIEX.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IDataService _iDataService;

   public HomeController(ILogger<HomeController> logger,IDataService iDataService)
    {
        _iDataService=iDataService;
        _logger = logger;
    }
    public IActionResult Index()
    {
        string val= _iDataService.SaysHello();
          ViewData["display"] =val;
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
