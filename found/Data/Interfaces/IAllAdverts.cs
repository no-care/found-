using found.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace found.Data.Interfaces
{
    public interface IAllAdverts
    {
        IEnumerable<Advert> GetAllAdverts { get; }
        IEnumerable<Advert> GetActiveAdvert { get; }
        IEnumerable<Advert> GetUsersAdverts(int id);
        Advert GetObjAdvert(int advId);
        IEnumerable<Advert> GetCurrAdvert(int advId);
        void addAdvert(Advert newAdvert);
        void AdvertsUpdate(int advid,string newDesc_short, string newDesc_long, string newLocation, string newTime, bool newActivity);

        IEnumerable<Advert> GetUnApprovedAdv { get; }

        void ApproveAdvert(int id);

        void DeleteAdvert(int id);
    }
}
