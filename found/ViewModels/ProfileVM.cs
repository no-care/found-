using found.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace found.ViewModels
{
    public class ProfileVM
    {
        public Users GetObjUser { get; set; }
        public IEnumerable<Advert> GetUsersAdverts {get;set;}
        public Advert GetAdvert { get; set; }
    }
}
