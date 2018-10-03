using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaintSender.Services;
using SaintSender.Entities;
using MimeKit;

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
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("sender email"));
            message.To.Add(new MailboxAddress("receiver email"));
            message.Subject = toSend.Subject;
            message.Body = toSend.Body;
        }

        public void SaveDraft()
        {

        }

        private void ReOpenDraft()
        {

        }

    }
}
