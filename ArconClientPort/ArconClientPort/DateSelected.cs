using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;

namespace ArconClientPort
{
    public class DateSelected: INotifyPropertyChanged
    {

        public static DateTime DateRange { get; set; }
        public static DateTime datechosen; 

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime DateChosen
        {
            get
            {
                return datechosen;
            }
            set
            {
                if (datechosen != value)
                {
                    datechosen = value;
                    OnPropertyChanged("DateChosen");
                    //SetNewColor();
                    
                }
            }

        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
