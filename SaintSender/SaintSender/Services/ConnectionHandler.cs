using MailKit.Net.Imap;
using System;
using System.IO;

namespace SaintSender.Services
{
    public class ConnectionHandler
    {
        private const string savePath = @"C:\InWatch\secure_auth_info.txt";
        public string UserName { get; private set; } = "c2077test@gmail.com";
        public string Password { get; private set; } = "SuperSecure1234";
        public string ImapServer { get; private set; } = "imap.gmail.com";
        public int ServerPort { get; private set; } = 993;
        public ImapClient Client { get; private set; }

        public ConnectionHandler()
        {
            // LoadAuth();
            Client = TryToConnect();
        }

        public ConnectionHandler(string userName, string password)
        {
            UserName = userName;
            Password = password;
            Client = TryToConnect();
        }

        public ImapClient TryToConnect()
        {
            var client = new ImapClient();
            client.ServerCertificateValidationCallback = (s, c, h, e) => true;

            client.Connect(ImapServer, ServerPort, true);

            client.Authenticate(UserName, Password);
            //SaveAuth();

            return client;
        }

        public void SaveAuth()
        {
            using (FileStream fileStream = File.Create(savePath))
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.WriteLine(UserName);
                writer.WriteLine(Password);
            }
        }

        public void LoadAuth()
        {
        }
    }
}