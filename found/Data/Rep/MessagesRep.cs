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
    public class MessagesRep: IAllMessages
    {
        private readonly DBContent DBContent;
        public MessagesRep(DBContent DBContent)
        {
            this.DBContent = DBContent;
        }

        public IEnumerable<Messages> GetAllDialogsMessages(int dialogid) => DBContent.messages.Where(p => p.dialogsid == dialogid).Include(c => c.Users);
        public void UpdateMessage(int messageid, string newMessage) 
        {
            Messages NewMessage = DBContent.messages.FirstOrDefault(p => p.id == messageid);
            NewMessage.message = newMessage;
            DBContent.SaveChanges();
        }
        public void AddMessage(int userid, int dialogid, string message, string datetime) 
        {
            Messages newMessage = new Messages();
            newMessage.usersid = userid;
            newMessage.dialogsid = dialogid;
            newMessage.message = message;
            newMessage.datetime = datetime;
            DBContent.messages.Add(newMessage);
            DBContent.SaveChanges();
        }
        public void DeleteMessage(int messageid) 
        {
            Messages DeletingMessage = DBContent.messages.FirstOrDefault(p => p.id == messageid);
            DBContent.Remove(DeletingMessage);
            DBContent.SaveChanges();
        }
    }
}
