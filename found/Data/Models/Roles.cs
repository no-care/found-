using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace found.Data.Models
{
    public class Roles
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
