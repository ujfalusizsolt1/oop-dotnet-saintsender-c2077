using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SaintSender.DesktopUI.ViewModels
{
    public class WriteEmailWindowViewModel : INotifyPropertyChanged
    {
     
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
