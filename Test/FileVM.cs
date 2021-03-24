using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class FileVM : NotifyPropertyChanged
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
                _name = value;
                OnPropertyChanged(nameof(Name));
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
