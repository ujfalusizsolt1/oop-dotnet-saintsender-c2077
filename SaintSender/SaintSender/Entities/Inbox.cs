using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaintSender.Services;
using SaintSender.Entities;

namespace SaintSender.Entities
{
    class Inbox
    {
        public List<Email> emails;

        public List<Email> GetMails()
        {
            /* 
            get client
            List<Email> result = new List<Email>;
            var inbox = client.inbox;
            
            for (int i = 0; i < inbox.Count; i++)
            {
                result.Add(inbox.GetMessage(i));
            }

            return result;
            */
        }

        public void OpenMail(int id)
        {
            /*
            get client;
            var inbox = client.inbox;
            inbox.GetMessage(id);
            */

        }

        public void SendMail(Email toSend)
        {

        }

        public void SaveDraft()
        {

        }

        private void ReOpenDraft()
        {

        }

    }
}
