using MimeKit;
using SaintSender.Entities;
using System;
using System.Collections.Generic;

namespace SaintSender.Services
{
    public class MessageParser
    {
        public Mail ParseMessage(MimeMessage message)
        {
            int id = int.Parse(message.MessageId);
            string sender = message.Sender.Address;

            List<string> recievers = new List<string>();
            foreach (var adress in message.To.Mailboxes)
            {
                recievers.Add(adress.Address);
            }

            DateTime date = message.Date.UtcDateTime;
            string subject = message.Subject;
            string content = message.TextBody;
            bool isRead = false;
            return new Mail(id, sender, recievers, date, subject, isRead, content);
        }
    }
}