using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test.Notifiers
{
    // TODO: попробуй вместо этих классов использовать GalaSoft.MvvmLight,
    // ..там уже есть ViewModelBase и RelayCommand
    public class NotifyPropertyChanged : INotifyPropertyChanged
    {
        /// <summary>
        /// Event that will react to changes in the property.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Event triggering.
        /// </summary>
        /// <param name="propertyName">Property Name.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
