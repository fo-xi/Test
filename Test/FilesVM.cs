using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class FilesVM : NotifyPropertyChanged
    {
		/// <summary>
		/// List of all files.
		/// </summary>
		public ObservableCollection<FileVM> _files;

		/// <summary>
		/// Selected File.
		/// </summary>
		private FileVM _selectedFile;

		/// <summary>
		/// Returns and sets a list of all files.
		/// </summary>
		public ObservableCollection<FileVM> Files
		{
			get
			{
				return _files;
			}
			set
			{
				_files = value;
				OnPropertyChanged(nameof(Files));
			}
		}

		/// <summary>
		/// Responsible for calling the MessageBox.
		/// </summary>
		private IMessageBoxService _messageBoxService;

		/// <summary>
		/// Responsible for calling the AddFileWindowService.
		/// </summary>
		private IAddFileWindowService _addFileWindowService;

		/// <summary>
		/// Returns and sets AddCommand.
		/// </summary>
		public Command AddCommand { get; set; }

		/// <summary>
		/// Returns and sets selected File.
		/// </summary>
		public FileVM SelectedFile
		{
			get
			{
				return _selectedFile;
			}
			set
			{
				_selectedFile = value;
				OnPropertyChanged(nameof(SelectedFile));
			}
		}

		/// <summary>
		/// Add file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		private void Add(object sender)
		{
			if (_addFileWindowService.DialogResult)
			{
				Files.Add(new FileVM(_addFileWindowService.FileName, new Command(Remove)));
			}
		}

		/// <summary>
		/// Remove file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		private void Remove(object sender)
		{
			var selectedFile = SelectedFile;

			if (selectedFile == null)
			{
				_messageBoxService.Show("Select File!");
				return;
			}

			Files.Remove(selectedFile);
		}

		/// <summary>
		/// Creates a file list.
		/// </summary>
		/// <param name="messageBoxService">MessageBox.</param>
		/// <param name="addFileWindowService">AddFile Window.</param>
		/// <param name="files">File list.</param>
		public FilesVM(IMessageBoxService messageBoxService,
			IAddFileWindowService addFileWindowService,
			ObservableCollection<FileVM> files)
		{
			Files = files;

			_messageBoxService = messageBoxService;
			_addFileWindowService = addFileWindowService;

			AddCommand = new Command(Add);
		}
	}
}
