using SaintSender.DesktopUI.ViewModels;
using SaintSender.Entities;
using SaintSender.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void MailListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var mailListBox = (ListBox)sender;
            var selectedItem = (Mail)mailListBox.SelectedItem;
            Debug.WriteLine($"The id of the selected mail is {selectedItem.Id}");
            ((MainWindowViewModel)DataContext).SelectedMail = selectedItem;
            selectedMailDataStackPanel.Visibility = Visibility.Visible;
            mailContentTextBox.Visibility = Visibility.Visible;
        }

       
    }
}