using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class MainWindowVM : NotifyPropertyChanged
    {
	    private FilesVM _filesVM;

	    public FilesVM FilesVM
	    {
		    get
		    {
			    return _filesVM;
		    }
		    set
		    {
			    _filesVM = value;
				OnPropertyChanged(nameof(FilesVM));
		    }
	    }

	    public MainWindowVM(IMessageBoxService messageBoxService,
		    IAddFileWindowService addFileWindowService)
	    {
		    FilesVM = new FilesVM(messageBoxService, addFileWindowService);
	    }
    }
}
