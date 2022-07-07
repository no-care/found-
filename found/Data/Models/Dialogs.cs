using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace found.Data.Models
{
    public class Dialogs
    {
        public int id { get; set; }
        public virtual ICollection<Users> Users { get; set; }
        public virtual ICollection<Messages> Messages { get; set; }
    }
}
