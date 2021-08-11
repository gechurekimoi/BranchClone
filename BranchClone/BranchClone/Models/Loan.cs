using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace BranchClone.Models
{
    public class Loan : INotifyPropertyChanged
    {
        public string Amount { get; set; }

        public string BackgroundColor 
        { 
            get 
            { 
                return IsSelected == true ? "#4FCDFF" : "LightGray";  
            }  
        }

        public int Height 
        {
            get
            {
                return IsSelected == true ? 200 : 150;
            }
        }

        public int Width
        {
            get
            {
                return IsSelected == true ? 200 : 150;
            }
        }

        public int FontSize
        {
            get
            {
                
                return IsSelected == true ? 30 : 25; 
            }
        }

        public bool IsSelected { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

    }
}
