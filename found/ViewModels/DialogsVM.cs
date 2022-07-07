using found.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace found.ViewModels
{
    public class DialogsVM
    {
        public IEnumerable<Dialogs> GetAllUsersDialogs { get; set; }
        public IEnumerable<Messages> GetAllDialogsMessages { get; set; }
        public Dialogs GetCurrDialog { get; set; }
    }
}
