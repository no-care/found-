using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using found.Data.Interfaces;
using found.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace found.Data.Rep
{
    public class UserRep : IAllUsers
    {
        private readonly DBContent DBContent;

        public UserRep(DBContent DBContent)
        {
            this.DBContent = DBContent;
        }
        public IEnumerable<Users> AllUsers => DBContent.users;
        public Users GetObjUser(int id) => DBContent.users.FirstOrDefault(p => p.id == id);
        public void updateUser(int id,string newLog, string newMail, string newPass)   
        {
            Users editedUsr = DBContent.users.FirstOrDefault(p => p.id == id);
            editedUsr.login = newLog;
            editedUsr.mail = newMail;
            editedUsr.password = newPass;
            DBContent.SaveChanges();
        }
        public void Register(Users newUsers) 
        {
            Users logCheck= null;
            logCheck = DBContent.users.FirstOrDefault(u => u.login == newUsers.login);
            if(logCheck == null)
            {
                newUsers.roleid = 1;
                DBContent.users.Add(newUsers);
                DBContent.SaveChanges();
            }
            else 
            {
                CurrUserData.LogEx = true;
            };
                
        }
        public Users Author(Authorize authUser) => DBContent.users.FirstOrDefault(u => u.login == authUser.login && u.password == authUser.password);
        public Users GetUserByLogin(string login) => DBContent.users.FirstOrDefault(u => u.login == login);
    }
}
