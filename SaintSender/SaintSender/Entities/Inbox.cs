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

        public Inbox(List<Mail> mails)
        {
            conn = new ConnectionHandler();
        }

        public List<Mail> GetMails()
        {
            ImapClient client = conn.client;
            List<Mail> result = new List<Mail>();
            var inbox = client.Inbox;

            for (int i = 0; i < inbox.Count; i++)
            {
                var msg = inbox.GetMessage(i);
                //result.Add(new Mail(int.Parse(msg.MessageId), msg.From.ToString(), msg.To.ToString(), DateTime.Parse(msg.Date), msg.Subject, false, msg.Body.ToString()));
                //Mails.Add(inbox.GetMessage(i));
            }

            return result;
            
        }

        public void SendMail(Mail toSend)
        {
            ImapClient client = conn.client;
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(toSend.Sender));
            message.To.Add(new MailboxAddress(toSend.Reciever));
            message.Subject = toSend.Subject;
            message.Body = toSend.Content;
            SaveDraft(message);

            using (var sendingClient = new SmtpClient())
            {
                sendingClient.Connect("smtp.gmail.com", 587);

                // use the OAuth2.0 access token obtained above
                var oauth2 = new SaslMechanismOAuth2("c2077test@gmail.com", credential.Token.AccessToken);
                sendingClient.Authenticate(oauth2);

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