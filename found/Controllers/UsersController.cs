 using found.Data;
using found.Data.Interfaces;
using found.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace found.Controllers
{
    
    public class UsersController: Controller
    {
        private readonly IAllUsers _addUsr;
        private readonly IAllUsers _logUsr;
        public const string SessionKeyName = "id";
        public UsersController(IAllUsers addUsr, IAllUsers logUsr) 
        {
            _addUsr = addUsr;
            _logUsr = logUsr;
        }
        public IActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Users users) 
        {
            if (ModelState.IsValid) 
            { 
                _addUsr.Register(users);
                if (CurrUserData.LogEx == true)
                {
                    ModelState.AddModelError("login", "Пользователь с таким логином уже существует");
                    CurrUserData.LogEx = false;
                }
                else
                {
                    return RedirectToAction("RegComplete");
                }
                    
            }
            return View(users);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Authorize authUser)
        {
            if (ModelState.IsValid)
            {
                Users logcheck = _logUsr.GetUserByLogin(authUser.login);
                if (logcheck == null)
                {
                    ModelState.AddModelError("login", "Пользователь с таким логином не существует");
                }
                else
                {
                    Users Usr = _logUsr.Author(authUser);
                    if (Usr == null)
                    {
                        ModelState.AddModelError("password", "Пароль введен неверно");
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("id", Usr.id);
                        HttpContext.Session.SetInt32("roleid", Usr.roleid);
                        if (Usr.roleid == 2)
                        {
                            return LocalRedirect("~/Admin/Admin");
                        }
                        else
                        {
                            return LocalRedirect("~/Home/Adverts");
                        }

                    }

                }
            }
            return View();
        }
        public IActionResult RegComplete()
        {
            ViewBag.Message = "Успешно";
            return View();
        }
        public IActionResult LogComplete()
        {
            ViewBag.Message = "Успешно";
            return View();
        }
        public IActionResult LogOut() 
        {
            HttpContext.Session.Clear();
            return View("Login");
           
        }
    }
}
