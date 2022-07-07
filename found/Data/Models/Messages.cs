using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace found.Data.Models
{
    public class Messages
    {
        public int id { get; set; }
        public int dialogsid { get; set; }
        public int usersid { get; set; }
        public string message { get; set; }
        public string datetime { get; set; }
        public virtual Users Users { get; set; }
        public virtual Dialogs Dialogs { get; set; }
    }
}
