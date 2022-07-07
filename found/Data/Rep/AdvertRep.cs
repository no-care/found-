using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using found.Data.Interfaces;
using found.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace found.Data.Rep
{
    public class AdvertRep : IAllAdverts
    {
        private readonly DBContent DBContent;
        public AdvertRep(DBContent DBContent)
        {
            this.DBContent = DBContent;
        }
        public IEnumerable<Advert> GetAllAdverts => DBContent.adv.Include(c => c.Users);
        public IEnumerable<Advert> GetActiveAdvert => DBContent.adv.Where(p => p.isActive == true && p.isApprove == true).Include(c => c.Users);
        public IEnumerable<Advert> GetCurrAdvert(int advId) => DBContent.adv.Where(p => p.id == advId).Include(c => c.Users);
        public Advert GetObjAdvert(int advId) => DBContent.adv.FirstOrDefault(p => p.id == advId);
        public IEnumerable<Advert> GetUsersAdverts(int id) => DBContent.adv.Where(p => p.Usersid == id);
        public void addAdvert(Advert newAdvert) 
        {
            newAdvert.isActive = true;
            newAdvert.isApprove = false;
            DBContent.adv.Add(newAdvert);
            DBContent.SaveChanges();
        }
        public void AdvertsUpdate(int advid,string newDesc_short, string newDesc_long, string newLocation, string newTime, bool newActivity)
        {
            Advert editedAdv = DBContent.adv.FirstOrDefault(p => p.id == advid);
            editedAdv.desc_short = newDesc_short;
            editedAdv.desc_long = newDesc_long;
            editedAdv.location = newLocation;
            editedAdv.time = newTime;
            editedAdv.isActive = newActivity;
            DBContent.SaveChanges();
        }

        public IEnumerable<Advert> GetUnApprovedAdv => DBContent.adv.Where(p => p.isApprove == false).Include(c => c.Users);

        public void ApproveAdvert(int id) 
        {
            Advert UnApprovedAdv = DBContent.adv.FirstOrDefault(p => p.id == id);
            UnApprovedAdv.isApprove = true;
            DBContent.SaveChanges();
        }
        public void DeleteAdvert(int id) 
        {
           Advert DeletingAdv = DBContent.adv.FirstOrDefault(p => p.id == id);
           DBContent.Remove(DeletingAdv);
           DBContent.SaveChanges();
        }
    }
}
