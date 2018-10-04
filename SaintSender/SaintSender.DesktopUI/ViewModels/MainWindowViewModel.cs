using SaintSender.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SaintSender.DesktopUI.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Mail _selectedMail;

        public Inbox Inbox { get; set; }

        public Mail SelectedMail
        {
            get { return _selectedMail; }
            set
            {
                _selectedMail = value;
                OnPropertyRaised("SelectedMail");
            }
        }
        public bool isLoggedIn { get; internal set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            Inbox = new Inbox();
            Inbox.GetMails();
        }

        protected void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}