﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()

    {
        ViewData["Title"] = "Ultimate Task Managment Assistant";
        return View();
    }
}
