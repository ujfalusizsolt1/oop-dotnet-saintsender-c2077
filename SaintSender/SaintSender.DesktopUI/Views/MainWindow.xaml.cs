using SaintSender.DesktopUI.ViewModels;
using SaintSender.Entities;
using System.Diagnostics;
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
    }
}