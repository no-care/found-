using found.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace found.Data.Interfaces
{
    public interface IAllDialogs
    {
        IEnumerable<Dialogs> GetAllUsersDialogs(int userid);
        /*
        IEnumerable<Dialogs> GetAllUsersDialogs(int User1_id, int User2_id);
        */
        void AddDialog(int User1_id, int User2_id);
        bool CheckDialogs(int User1_id, int User2_id);
        Dialogs GetCurrDialog(int id);
    }
}
