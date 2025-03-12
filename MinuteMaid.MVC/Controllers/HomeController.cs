using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinuteMaid.MVC.Data;
using MinuteMaid.MVC.Models;

namespace MinuteMaid.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly MinuteMadeDbContext _context;

    public HomeController(ILogger<HomeController> logger, MinuteMadeDbContext context)
    {
        _logger = logger?? throw new ArgumentNullException(nameof(logger));
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public IActionResult Index()
    {
        return View(_context.Recipes.ToList());
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

    public IActionResult Details(int id)
    {
        return View(_context.Recipes.Find(id));
    } 
}
