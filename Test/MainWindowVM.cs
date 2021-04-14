using GalaSoft.MvvmLight;
using Test.Controls;
using Test.Notifiers;

namespace Test
{
	// TODO: оформление кода? везде (+)
	/// <summary>
	/// View Model for window MainWindow.
	/// </summary>
	public class MainWindowVM : ViewModelBase
    {
		/// <summary>
		/// Files.
		/// </summary>
	    private FilesVM _filesVM;

		/// <summary>
		/// Returns and sets files.
		/// </summary>
		public FilesVM FilesVM
	    {
		    get
		    {
			    return _filesVM;
		    }
		    set
		    {
			    _filesVM = value;
				RaisePropertyChanged(nameof(FilesVM));
		    }
	    }

		/// <summary>
		/// Files creation.
		/// </summary>
		/// <param name="addFileWindowService">Add file window.</param>
		public MainWindowVM(IAddFileWindowService addFileWindowService)
	    {
		    FilesVM = new FilesVM(addFileWindowService);
	    }
    }
}
