﻿using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class commonDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
