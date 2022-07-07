using found.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace found.Data.Interfaces
{
    public interface IAllUsers
    {
        IEnumerable<Users> AllUsers { get; }
        Users GetObjUser(int userId);
        Users Author(Authorize authUser);
        void updateUser(int id,string newLog, string newMail, string newPass);
        void Register(Users newUser);
        Users GetUserByLogin(string login);
    }
}
