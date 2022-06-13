using AutoGlassMarket.Interface;
using AutoGlassMarket.Models;
using AutoGlassMarket.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AutoGlassMarket.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
