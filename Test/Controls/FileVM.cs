using System.Linq;
using Test.Notifiers;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Test.Controls
{
    /// <summary>
    /// View Model for file control.
    /// </summary>
    public class FileVM : NotifyDataErrorInfoBase
    {
        /// <summary>
        /// File Name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Returns and sets RemoveCommand.
        /// </summary>
        public RelayCommand<object> RemoveCommand { get; set; }

        /// <summary>
        /// Property indicates whether there are any validation errors.
        /// </summary>
        public override bool HasErrors
        {
	        get
	        {
		        return _errorsByPropertyName.Any();
	        }
        }

        /// <summary>
        /// Returns and sets File Name.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
	            Validate(value, nameof(Name));
                _name = value;
                RaisePropertyChanged(nameof(Name));
                RaisePropertyChanged(nameof(HasErrors));
            }
        }

        /// <summary>
        /// Create File.
        /// </summary>
        /// <param name="name">File Name</param>
        /// <param name="remove">RemoveCommand</param>
        public FileVM(string name, RelayCommand<object> remove)
        {
	        Name = name;
	        RemoveCommand = remove;
        }
    }
}
