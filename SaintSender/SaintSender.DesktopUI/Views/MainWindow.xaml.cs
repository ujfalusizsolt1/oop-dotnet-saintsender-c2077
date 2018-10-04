using SaintSender.DesktopUI.ViewModels;
using SaintSender.Entities;
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
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var mainWindowViewModel = (MainWindowViewModel)DataContext;
            if (mainWindowViewModel.isLoggedIn == false)
            {
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
    }
}