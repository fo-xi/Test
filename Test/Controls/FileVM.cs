using System.Linq;
using Test.Notifiers;

namespace Test.Controls
{
    public class FileVM : NotifyDataError
    {
        /// <summary>
        /// File Name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Returns and sets RemoveCommand.
        /// </summary>
        public Command RemoveCommand { get; set; }

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
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(HasErrors));
            }
        }

        /// <summary>
        /// Create File.
        /// </summary>
        /// <param name="name">File Name</param>
        /// <param name="remove">RemoveCommand</param>
        public FileVM(string name, Command remove)
        {
	        Name = name;
	        RemoveCommand = remove;
        }
    }
}
