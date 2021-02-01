using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void ApplicationStartup(object sender, StartupEventArgs args)
        {
            MainWindow mainWindow = new MainWindow();                           // Instantiate the main window
            mainWindow.Sudoku = Sudoku.GetInstance(mainWindow);      // Get an instance of the ViewModel and set the View's ViewModel pointer
            mainWindow.Show();                                                  // Now display the view
        }
    }
}
