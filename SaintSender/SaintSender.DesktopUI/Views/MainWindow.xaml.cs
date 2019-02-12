using SaintSender.DesktopUI.ViewModels;
using SaintSender.Entities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace SaintSender.DesktopUI.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var loginWindow = new LoginWindow();
            var dialogResult = loginWindow.ShowDialog();
            if (dialogResult == true)
            {
                DataContext = new MainWindowViewModel(loginWindow.userNameTextBox.Text, loginWindow.passwordBox.Password);
            }
            else
            {
                this.Close();
            }
        }

        private void MailListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var mailListBox = (ListBox)sender;
            var selectedItem = (Mail)mailListBox.SelectedItem;

            ((MainWindowViewModel)DataContext).SelectedMail = selectedItem;
            selectedMailDataStackPanel.Visibility = Visibility.Visible;
            mailContentTextBox.Visibility = Visibility.Visible;
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindowViewModel)DataContext).SelectedMail = null;
            mailListBox.SelectedItem = null;
            ((MainWindowViewModel)DataContext).Inbox.GetMails();
        }

        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Upgrade_Click(object sender, RoutedEventArgs e)
        {
            var getPro = new GetProWindow();
            getPro.Show();
        }

        private void newEmail_Click(object sender, RoutedEventArgs e)
        {
            WriteEmailWindow writeEmailWindow = new WriteEmailWindow();
            var dialogResult = writeEmailWindow.ShowDialog();
            if (dialogResult == true)
            {
                string from = ((MainWindowViewModel)DataContext).LoggedIn;
                List<string> recipients = new List<string>(Regex.Split(writeEmailWindow.recipients.Text, ", "));
                string subject = writeEmailWindow.subject.Text;
                string content = writeEmailWindow.message.Text;
                var rawMail = new Mail(from, recipients, System.DateTime.Now, subject, false, content);

                ((MainWindowViewModel)DataContext).Inbox.SaveDraft(rawMail); //save before sending
                ((MainWindowViewModel)DataContext).Inbox.SendMail(rawMail);  //send email
            }
            else
            {
                this.Close();
            }
        }
    }
}