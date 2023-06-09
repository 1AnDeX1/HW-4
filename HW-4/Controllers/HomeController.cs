﻿using HW_4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW_4.Controllers
{
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Success(User user)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Я, " + user.Name + " (" + user.Email + ") став розробником ASP.NET.";
                return View();
            }

            
            return View("Index");            
        }
        
    }
}