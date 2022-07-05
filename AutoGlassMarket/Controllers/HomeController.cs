using AutoGlassMarket.Interface;
using AutoGlassMarket.Models;
using AutoGlassMarket.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGlassMarket.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        { 
            ViewBag.Title = "Главная страница";
            return View();
        }



        

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
