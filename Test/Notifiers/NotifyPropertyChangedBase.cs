using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Test.Notifiers
{
    // TODO: попробуй вместо этих классов использовать GalaSoft.MvvmLight,
    // ..там уже есть ViewModelBase и RelayCommand
    /// <summary>
    /// The class that is responsible for notifying the client about the change in the property value.
    /// </summary>
    public class NotifyPropertyChangedBase : INotifyPropertyChanged
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
