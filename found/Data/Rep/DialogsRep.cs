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
    public class DialogsRep : IAllDialogs
    {
        private readonly DBContent DBContent;
        public DialogsRep(DBContent DBContent)
        {
            this.DBContent = DBContent;
        }

        public IEnumerable<Dialogs> GetAllUsersDialogs(int userid)
            => DBContent.dialogs.Include(u => u.Messages).Include(c => c.Users).Where(p => p.Users.Any(u => u.id == userid));
        /*
        public IEnumerable<Dialogs> GetAllUsersDialogs(int User1_id, int User2_id) =>
           DBContent.dialogs.Where(p => p.user1_id == User1_id && p.user2_id == User2_id || p.user1_id == User2_id && p.user2_id == User1_id).Include(c => c.Users);
        */
        public void AddDialog(int User1_id, int User2_id)
        {
            Dialogs newDialog = new();
            newDialog.Users = new List<Users>();
            var newUser1 = DBContent.users.FirstOrDefault(p => p.id == User1_id);
            var newUser2 = DBContent.users.FirstOrDefault(p => p.id == User2_id);
            newDialog.Users.Add(newUser1);
            newDialog.Users.Add(newUser2);
            DBContent.dialogs.Add(newDialog);
            DBContent.SaveChanges();
        }
        
        public bool CheckDialogs(int User1_id, int User2_id)
        {
            Dialogs newDialog = new();
            newDialog.Users = new List<Users>();
            var newUser1 = DBContent.users.FirstOrDefault(p => p.id == User1_id);
            var newUser2 = DBContent.users.FirstOrDefault(p => p.id == User2_id);
            var alldialogs = DBContent.dialogs.Include(c => c.Users).Where(p => p.Users.Any(u => u.id == User1_id) && p.Users.Any(u => u.id == User2_id)).ToList();
            if (alldialogs.Count == 0)
            {
                return false;
            }
            else { return true; }
        }
        public Dialogs GetCurrDialog(int id) => DBContent.dialogs.Include(u=> u.Users).FirstOrDefault(P => P.id == id);
    }
}
