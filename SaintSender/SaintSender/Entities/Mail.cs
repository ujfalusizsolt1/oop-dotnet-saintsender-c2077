using System;
using System.Collections.Generic;

namespace SaintSender.Entities
{
    public class Mail
    {
        public string Sender { get; set; }
        public List<string> Recievers { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public bool IsRead { get; set; }
        public string Content { get; set; }

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