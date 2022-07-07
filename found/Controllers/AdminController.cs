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
    public class AdminController : Controller
    {
        private readonly IAllAdverts _UnApprovedAdv;
        private readonly IAllUsers _AdvUser;

        public AdminController(IAllAdverts UnApprovedAdv, IAllUsers AdvUser)
        {
            _UnApprovedAdv = UnApprovedAdv;
            _AdvUser = AdvUser;
        }

        public IActionResult Admin() 
        {
            AdminVM obj = new AdminVM
            {
               GetUnApprovedAdv = _UnApprovedAdv.GetUnApprovedAdv
            };
            return View(obj);
        }

        [HttpPost]
        public IActionResult Admin(int id)
        {
            _UnApprovedAdv.ApproveAdvert(id);
            AdminVM obj = new AdminVM
            {
                GetUnApprovedAdv = _UnApprovedAdv.GetUnApprovedAdv
            };
            return View(obj);
        }

        public IActionResult Decline(int id) 
        {
            _UnApprovedAdv.DeleteAdvert(id);
            AdminVM obj = new AdminVM
            {
                GetUnApprovedAdv = _UnApprovedAdv.GetUnApprovedAdv
            };
            return LocalRedirect("~/Admin/Admin");
        }
    }
}

