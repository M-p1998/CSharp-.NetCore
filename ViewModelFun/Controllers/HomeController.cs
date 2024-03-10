using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpGet("numbers")]
    public ViewResult Num()
    {
        int[] int_number = new int[]{1,2,3,10,43,5};
        return View(int_number);
    }

    [HttpGet("users")]
    public ViewResult Users(){
         
        return View();
    }

    [HttpGet("user")]
    public ViewResult OneUser(){
        string st = "Moose Phillips";
        return View();
    }


    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //     return View(new User { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }
}
