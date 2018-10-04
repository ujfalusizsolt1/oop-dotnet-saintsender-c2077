using SaintSender.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SaintSender.DesktopUI.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Mail _selectedMail;

        public Inbox Inbox { get; set; } = new Inbox();

        public Mail SelectedMail
        {
            get { return _selectedMail; }
            set
            {
                _selectedMail = value;
                OnPropertyRaised("SelectedMail");
            }
        }
        public string PlaceholderText { get; set; } = "This is a placeholder text.\nDon't forget to delete it when you don't need it anymore.";

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            List<string> recipients = new List<string>() { "It's a me, Mario!", "It's a me, Luigi!" };
            Inbox.Mails.Add(new Mail(1, "sender1@sender.com", recipients, DateTime.Now, "This is the first subject", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(2, "sender2@sender.com", recipients, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(3, "sender2@sender.com", recipients, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(4, "sender2@sender.com", recipients, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(5, "sender2@sender.com", recipients, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(6, "sender2@sender.com", recipients, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(7, "sender2@sender.com", recipients, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(8, "sender2@sender.com", recipients, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(9, "sender2@sender.com", recipients, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(10, "sender2@sender.com", recipients, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
        }

        protected void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}