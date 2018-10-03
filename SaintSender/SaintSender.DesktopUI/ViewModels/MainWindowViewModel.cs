using SaintSender.Entities;
using System;

namespace SaintSender.DesktopUI.ViewModels
{
    public class MainWindowViewModel
    {
        public Inbox Inbox { get; set; } = new Inbox();
        public string PlaceholderText { get; set; } = "This is a placeholder text.\nDon't forget to delete it when you don't need it anymore.";

        public MainWindowViewModel()
        {
            Inbox.Mails.Add(new Mail(1, "sender1@sender.com", string.Empty, DateTime.Now, "This is the first subject", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(2, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(3, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(4, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(5, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(6, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(7, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(8, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(9, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(10, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
        }
    }
}