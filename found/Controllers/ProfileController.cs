using found.Data.Interfaces;
using found.Data.Models;
using found.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace found.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IAllUsers _authUsr;
        private readonly IAllUsers _editedUsr;
        private readonly IAllAdverts _usersAdvrts;
        private readonly IAllAdverts _editedAdv;

        public ProfileController(IAllUsers authUsr, IAllUsers editedUsr, IAllAdverts usersAdvrts, IAllAdverts editedAdv)
        {
            _authUsr = authUsr;
            _editedUsr = editedUsr;
            _usersAdvrts = usersAdvrts;
            _editedAdv = editedAdv;
        }
        public IActionResult Profile()
        {
            int id = (int)HttpContext.Session.GetInt32("id");
            ProfileVM obj = new ProfileVM
            {
                GetObjUser = _authUsr.GetObjUser(id),
                GetUsersAdverts = _usersAdvrts.GetUsersAdverts(id)
            };
            return View(obj);
        }
        [HttpPost]
        public IActionResult Profile(string newLog, string newMail, string newPass)
        {
            int id = (int)HttpContext.Session.GetInt32("id");
            _editedUsr.updateUser(id,newLog, newMail, newPass);
            ProfileVM obj = new ProfileVM
            {
                GetObjUser = _authUsr.GetObjUser(id),
                GetUsersAdverts = _usersAdvrts.GetUsersAdverts(id)
            };
            return View(obj);
        }

        public IActionResult AdvertUpdate(int Id)
        {
            ProfileVM obj = new ProfileVM
            {
                GetAdvert = _editedAdv.GetObjAdvert(Id)
            };
            
            return View(obj);
        }
        [HttpPost]
        public IActionResult AdvertUpdate(int Id, string newDesc_short, string newDesc_long, string newLocation, string newTime, string newActivity) 
        {
            int id = (int)HttpContext.Session.GetInt32("id");
            _editedAdv.AdvertsUpdate(Id, newDesc_short, newDesc_long, newLocation, newTime, newActivity == "on" ? true : false);
            ProfileVM obj = new ProfileVM
            {
                GetObjUser = _authUsr.GetObjUser(id),
                GetUsersAdverts = _usersAdvrts.GetUsersAdverts(id)
            };
            return View("Profile",obj);
        }
        public IActionResult Finally() { return View(); }
    } 
}
