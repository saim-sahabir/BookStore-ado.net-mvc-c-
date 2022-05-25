﻿using System.Diagnostics;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;

namespace BookStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ITestClass _testClass;

    public HomeController(ILogger<HomeController> logger , ITestClass testClass)
    {
        _logger = logger;
        _testClass = testClass;
    }

    public IActionResult Index()
    { 
       _logger.LogInformation("its home");
     var  model = new IndexModel();
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}