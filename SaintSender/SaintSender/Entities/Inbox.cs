using MimeKit;
using SaintSender.Entities;
using SaintSender.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender.Entities
{
    public class Inbox
    {
        public List<Mail> Mails { get; private set; } = new List<Mail>();

        public List<Mail> GetMails()
        {
            /*
            get client
            List<Mail> result = new List<Mail>;
            var inbox = client.inbox;

            for (int i = 0; i < inbox.Count; i++)
            {
                result.Add(inbox.GetMessage(i));
            }

            return result;
            */
            throw new NotImplementedException();
        }

        public void OpenMail(int id)
        {
            /*
            get client;
            var inbox = client.inbox;
            inbox.GetMessage(id);
            */
        }

        public void SendMail(Mail toSend)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("sender Mail"));
            message.To.Add(new MailboxAddress("receiver Mail"));
            message.Subject = toSend.Subject;
            //message.Body = toSend.Body;
        }

        public void SaveDraft()
        {
        }

        private void ReOpenDraft()
        {
        }
    }
}