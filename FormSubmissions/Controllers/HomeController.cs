using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormSubmissions.Models;

namespace FormSubmissions.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public ViewResult Index(){
        return View();
    }

    [HttpPost("Create")]
    public IActionResult Create(User result){
        if(ModelState.IsValid){
            return RedirectToAction("Result");
        }
        return View("Index");
    }

    [HttpGet("success")]
    public ViewResult Result(){
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
