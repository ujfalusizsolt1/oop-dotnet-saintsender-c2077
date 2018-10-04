using MimeKit;
using SaintSender.Entities;
using System;
using System.Collections.Generic;

namespace SaintSender.Services
{
    public static class MessageParser
    {
        public static Mail ParseMessage(MimeMessage message)
        {
            string sender = string.Join(", ", message.From);

            List<string> recievers = new List<string>();
            foreach (var adress in message.To.Mailboxes)
            {
                recievers.Add(adress.Address);
            }

            DateTime date = message.Date.UtcDateTime;
            string subject = message.Subject;
            string content = message.TextBody;
            bool isRead = false;
            return new Mail(sender, recievers, date, subject, isRead, content);
        }
    }
}