using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Security;
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
        private ConnectionHandler conn;
        private Mail draft;

        public Inbox()
        {
            conn = new ConnectionHandler();
        }

        public List<Mail> GetMails()
        {
            ImapClient client = conn.client;
            var inbox = client.Inbox;

            for (int i = 0; i < inbox.Count; i++)
            {
                var msg = MessageParser.ParseMessage(inbox.GetMessage(i));
                Mails.Add(msg);
            }

            return Mails;
        }

        public void SendMail(Mail toSend)
        {
            ImapClient client = conn.client;
            SaveDraft(toSend);
            var message = MessageParser.ConvertMessageToMail(toSend);

            using (var sendingClient = new SmtpClient())
            {
                sendingClient.Connect("smtp.gmail.com", 587);

                // disable the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                sendingClient.Authenticate(conn.UserName, conn.Password);

                sendingClient.Send(message);
                sendingClient.Disconnect(true);
            }
        }

        public void SaveDraft(Mail newDraft)
        {
            draft = newDraft;
        }

        private Mail ReOpenDraft()
        {
            return draft;
        }
    }
}