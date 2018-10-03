using System;
using System.Collections.Generic;

namespace SaintSender.Entities
{
    public class Mail
    {
        public int Id { get; }
        public List<string> Sender { get; }
        public string Recievers { get; }
        public DateTime Date { get; }
        public string Subject { get; }
        public bool IsRead { get; set; }
        public string Content { get; }

        public Mail(int id, List<string> sender, string recievers, DateTime date, string subject, bool isRead, string content)
        {
            Id = id;
            Sender = sender;
            Recievers = recievers;
            Date = date;
            Subject = subject;
            IsRead = isRead;
            Content = content;
        }
    }
}