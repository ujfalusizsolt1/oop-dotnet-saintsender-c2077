using System;

namespace SaintSender.Entities
{
    public class Mail
    {
        public int Id { get; }
        public string Sender { get; }
        public string Reciever { get; }
        public DateTime Date { get; }
        public string Subject { get; }
        public bool IsRead { get; set; }
        public string Content { get; }

        public Mail(int id, string sender, string reciever, DateTime date, string subject, bool isRead, string content)
        {
            Id = id;
            Sender = sender;
            Reciever = reciever;
            Date = date;
            Subject = subject;
            IsRead = isRead;
            Content = content;
        }
    }
}