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
using found.ViewModels;

namespace found.Controllers
{
    public class MessagesController: Controller
    {
        private readonly IAllDialogs _usersDialogs;
        private readonly IAllDialogs _currDialog;
        private readonly IAllDialogs _checkDialog;
        private readonly IAllMessages _dialogsMessages;
        public MessagesController(IAllDialogs usrDia, IAllDialogs currDialog, IAllDialogs checkDialog, IAllMessages dialogsMessages)
        {
            _usersDialogs = usrDia;
            _currDialog = currDialog;
            _checkDialog = checkDialog;
            _dialogsMessages = dialogsMessages;
        }
        public IActionResult Dialogs() 
        {
            int id = (int)HttpContext.Session.GetInt32("id");
            DialogsVM obj = new DialogsVM
            {
               GetAllUsersDialogs = _usersDialogs.GetAllUsersDialogs(id)
            };
            return View(obj);
        }
        public IActionResult AddDialog(int AnotherUserid) 
        {
            int AuthUserid = (int)HttpContext.Session.GetInt32("id");         
            if(_checkDialog.CheckDialogs(AuthUserid, AnotherUserid)) 
            {
                return LocalRedirect("~/Home/Adverts");
            }
            _currDialog.AddDialog(AuthUserid, AnotherUserid);
            return LocalRedirect("~/Messages/Dialogs");

        }
        public IActionResult Messages(int id, string Title) 
        {
            DialogsVM obj = new DialogsVM
            {
                GetAllDialogsMessages = _dialogsMessages.GetAllDialogsMessages(id),
                GetCurrDialog = _currDialog.GetCurrDialog(id)
            };
            return View(obj);
        }
        [HttpPost]
        public IActionResult Messages(string message, int dialogid)
        {
                int AuthUserid = (int)HttpContext.Session.GetInt32("id");
                _dialogsMessages.AddMessage(AuthUserid, dialogid, message, DateTime.Now.ToString("yyyy-M-d H:m:s"));
                DialogsVM obj = new DialogsVM
                {
                    GetAllDialogsMessages = _dialogsMessages.GetAllDialogsMessages(dialogid),
                    GetCurrDialog = _currDialog.GetCurrDialog(dialogid)
                };
                return View(obj);     
        }       
    }
}
