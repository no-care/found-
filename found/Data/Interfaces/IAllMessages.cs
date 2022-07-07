using found.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace found.Data.Interfaces
{
    public interface IAllMessages
    {
        IEnumerable<Messages> GetAllDialogsMessages(int dialogid);
        void UpdateMessage(int messageid , string newMessage);
        void DeleteMessage(int messageid);
        void AddMessage(int userid, int dialogid, string message, string datetime);
    }
}
