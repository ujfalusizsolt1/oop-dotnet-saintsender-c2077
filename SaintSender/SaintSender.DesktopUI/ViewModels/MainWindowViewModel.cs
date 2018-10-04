using SaintSender.Entities;
using System;
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
            Inbox.Mails.Add(new Mail(1, "sender1@sender.com", string.Empty, DateTime.Now, "This is the first subject", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(2, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.\nDuis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."));
            Inbox.Mails.Add(new Mail(3, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem.Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur ? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?"));
            Inbox.Mails.Add(new Mail(4, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(5, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body.\n"));
            Inbox.Mails.Add(new Mail(6, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(7, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(8, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(9, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
            Inbox.Mails.Add(new Mail(10, "sender2@sender.com", string.Empty, DateTime.Now, "This is the subject.", false, "This is the messsage body."));
        }

        protected void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}