using System;
using System.Collections.Generic;

namespace SaintSender.Entities
{
    public class Mail
    {
        public string Sender { get; }
        public List<string> Recievers { get; }
        public DateTime Date { get; }
        public string Subject { get; }
        public bool IsRead { get; set; }
        public string Content { get; }

        public Mail(string sender, List<string> recievers, DateTime date, string subject, bool isRead, string content)
        {
            Sender = sender;
            Recievers = recievers;
            Date = date;
            Subject = subject;
            IsRead = isRead;
            Content = content;
        }
    }
}