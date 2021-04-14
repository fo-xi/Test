using System.Windows;
using Test;

namespace View
{
    /// <summary>
    /// MainWindow.
    /// </summary>
    public partial class MainWindow : Window
    {
	    MainWindowVM _mainWindow = new MainWindowVM(new AddFileWindowService());

        public MainWindow()
        {
            InitializeComponent();

            DataContext = _mainWindow;
        }
    }
}
