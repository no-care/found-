using found.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace found.ViewModels
{
    public class AdminVM
    {
        public IEnumerable<Advert> GetUnApprovedAdv { get; set; }
        public IEnumerable<Users> GetObjUser { get; set; }
    }
}
