using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UTBAirlines.Web.Models;
using UTBAirlines.Application.Abstraction;

namespace UTBAirlines.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILetenkaAppService _letenkaAppService;

    public HomeController(ILetenkaAppService letenkaAppService)
    {
        _letenkaAppService = letenkaAppService;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult UTBAirlines()
    {
        var letenky = _letenkaAppService.SelectAll();
        return View(letenky);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}