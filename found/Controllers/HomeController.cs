using found.Models;
using found.Data.Interfaces;
using found.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace found.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllAdverts _allAdv;
        private readonly IAllUsers _allUsrs;
        public HomeController(IAllAdverts adv, IAllUsers usrs)
        {
            _allAdv = adv;
            _allUsrs = usrs;        
        }
        
        public IActionResult Adverts()
        {
            AdvLVModel obj = new AdvLVModel
            {
                allAdv = _allAdv.GetActiveAdvert
            };
            return View(obj);
        }
        public IActionResult Index()
        {
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
}
