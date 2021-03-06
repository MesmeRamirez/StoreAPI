﻿using CommonStoreAPI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StoreAPIApplication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private readonly ICurrentUserFactory _currentUser;

        public HomeController(ICurrentUserFactory currentUser)
        {
            _currentUser = currentUser;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
