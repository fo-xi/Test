using System.Collections.ObjectModel;
using Test.Notifiers;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Test.Controls
{
	/// <summary>
	/// View Model for files control.
	/// </summary>
	public class FilesVM : ViewModelBase
    {
		/// <summary>
		/// List of all files.
		/// </summary>
		public ObservableCollection<FileVM> _files;

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
				RaisePropertyChanged(nameof(Files));
			}
		}

		/// <summary>
		/// Responsible for calling the AddFileWindowService.
		/// </summary>
		private IAddFileWindowService _addFileWindowService;

		/// <summary>
		/// Returns and sets AddCommand.
		/// </summary>
		public RelayCommand AddCommand { get; set; }

		/// <summary>
		/// Add file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		private void Add()
		{
			_addFileWindowService.OpenFileDialog();

			if (_addFileWindowService.DialogResult)
			{
				foreach (var fileName in _addFileWindowService.FileName)
				{
					Files.Add(new FileVM(fileName, new RelayCommand<object>(Remove)));
				}
			}
		}

		/// <summary>
		/// Remove file.
		/// </summary>
		/// <param name="sender">Sender.</param>
		private void Remove(object sender)
		{
			var selectedFile = (FileVM)sender;
			Files.Remove(selectedFile);
		}

		/// <summary>
		/// Creates a file list.
		/// </summary>
		/// <param name="addFileWindowService">AddFile Window.</param>
		/// <param name="files">File list.</param>
		public FilesVM(IAddFileWindowService addFileWindowService)
		{
			Files = new ObservableCollection<FileVM>();

			_addFileWindowService = addFileWindowService;

			AddCommand = new RelayCommand(Add);
		}
	}
}
