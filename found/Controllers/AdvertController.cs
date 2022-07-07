using found.Data.Interfaces;
using found.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using found.ViewModels;
using System.IO;
using Microsoft.EntityFrameworkCore;
using found.Data;
using Microsoft.AspNetCore.Hosting;

namespace found.Controllers
{
    public class AdvertController : Controller
    {

        private readonly IAllAdverts _newAdv;
        private readonly IAllAdverts _objAdv;
        IWebHostEnvironment _appEnviroment;


        public AdvertController(IAllAdverts newAdv, IWebHostEnvironment appEnviroment,IAllAdverts objAdv)
        {
            _objAdv = objAdv;
            _appEnviroment = appEnviroment;
            _newAdv = newAdv;
        }
        public IActionResult NewAdvert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewAdvert(Advert advert, IFormFile uploadedImg)
        {
            string path = null;
            if (uploadedImg != null)
            {
                path = "/Img/" + uploadedImg.FileName;
                using var fileStream = new FileStream(_appEnviroment.WebRootPath + path, FileMode.Create);
                await uploadedImg.CopyToAsync(fileStream);
            }
            if (ModelState.IsValid)
            {
                if(path == null) 
                {
                    advert.img = "/Img/no_picture.png";
                }
                else 
                {
                    advert.img = path;
                }
                advert.Usersid = (int)HttpContext.Session.GetInt32("id");
                _newAdv.addAdvert(advert);
                return RedirectToAction("Success");
            }
            return View(advert);
        }

        public IActionResult Success()
        {
            return View();
        }
        public IActionResult CurrAdvert(int Id)
        {
            AdvLVModel obj = new AdvLVModel
            {
                GetCurrAdvrt = _objAdv.GetCurrAdvert(Id)
            };
            return View(obj);
        }
    }
}

