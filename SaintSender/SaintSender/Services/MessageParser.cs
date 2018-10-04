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

        public static MimeMessage ConvertMessageToMail(Mail mail)
        {
            List<MailboxAddress> recipientMailboxes = new List<MailboxAddress>();
            foreach (var recipient in mail.Recievers)
            {
                recipientMailboxes.Add(new MailboxAddress(recipient));
            }

            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress(mail.Sender));
            message.To.AddRange(recipientMailboxes);
            message.Subject = mail.Subject;
            message.Body = new TextPart("plain") {
                Text = mail.Content
            };

            return message;
        }

    }
}
