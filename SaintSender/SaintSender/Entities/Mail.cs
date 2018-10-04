using System;
using System.Collections.Generic;

namespace SaintSender.Entities
{
    public class Mail
    {
        public int Id { get; }
        public string Sender { get; }
        public List<string> Recievers { get; }
        public DateTime Date { get; }
        public string Subject { get; }
        public bool IsRead { get; set; }
        public string Content { get; }

        public Mail(int id, string sender, List<string> recievers, DateTime date, string subject, bool isRead, string content)
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