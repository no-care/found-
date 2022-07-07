using found.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace found.ViewModels
{
    public class AdvLVModel
    {
        public IEnumerable<Advert> allAdv { get; set; }
        public IEnumerable<Advert> GetCurrAdvrt { get; set; }
        public Advert GetAdvert { get; set; }
        public Advert AddAdvert { get; set; }
        public Users Author { get; set; }
        public Users Register { get; set; }
        public string username { get; set; }
    }
}
