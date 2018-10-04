using MailKit.Net.Imap;
using System;

namespace SaintSender.Services
{
    internal class ConnectionHandler
    {
        public string UserName { get; private set; } = "c2077test@gmail.com";
        public string Password { get; private set; } = "SuperSecure1234";
        public string ImapServer { get; private set; } = "imap.gmail.com";
        public int ServerPort { get; private set; } = 993;
        public ImapClient client { get; private set; }

        public ConnectionHandler()
        {
            client = TryToConnect();
        }

        public bool isLoggedIn { get; set; } = false;

        public ImapClient TryToConnect()
        {
            var client = new ImapClient();
            client.ServerCertificateValidationCallback = (s, c, h, e) => true;

            client.Connect(ImapServer, ServerPort, true);

            client.Authenticate(UserName, Password);
            return client;
        }

        public void SaveAuth()
        {
            throw new NotImplementedException();
        }
    }
}