using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using SaintSender.Entities;
using SaintSender.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender.Entities
{
    public class Inbox : INotifyPropertyChanged
    {
        public List<Mail> Mails
        {
            get { return _mails; }
            private set
            {
                _mails = value;
                OnPropertyRaised("Mails");
            }
        }
        private ConnectionHandler conn;
        private Mail draft;
        private List<Mail> _mails = new List<Mail>();

        public event PropertyChangedEventHandler PropertyChanged;

        public Inbox()
        {
            conn = new ConnectionHandler();
        }

        public Inbox(string userName, string password)
        {
            conn = new ConnectionHandler(userName, password);
        }

        public void GetMails()
        {
            ImapClient client = conn.Client;
            List<Mail> result = new List<Mail>();
            var inbox = client.Inbox;
            inbox.Open(MailKit.FolderAccess.ReadOnly);

            for (int i = inbox.Count - 1; i >= 0; i--)
            {
                var msg = inbox.GetMessage(i);
                Mails.Add(MessageParser.ParseMessage(msg));
            }
        }

        //public void SendMail(Mail toSend)
        //{
        //    ImapClient client = conn.client;
        //    var message = new MimeMessage();
        //    message.From.Add(new MailboxAddress(toSend.Sender));
        //    message.To.Add(new MailboxAddress(toSend.Reciever));
        //    message.Subject = toSend.Subject;
        //    message.Body = toSend.Content;
        //    SaveDraft(message);

        //    using (var sendingClient = new SmtpClient())
        //    {
        //        sendingClient.Connect("smtp.gmail.com", 587);

        //        // use the OAuth2.0 access token obtained above
        //        var oauth2 = new SaslMechanismOAuth2("c2077test@gmail.com", credential.Token.AccessToken);
        //        sendingClient.Authenticate(oauth2);

        //        sendingClient.Send(message);
        //        sendingClient.Disconnect(true);
        //    }
        //}

        public void SaveDraft(Mail newDraft)
        {
            draft = newDraft;
        }

        private Mail ReOpenDraft()
        {
            return draft;
        }

        protected void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}