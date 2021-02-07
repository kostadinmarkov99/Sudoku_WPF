using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp4.View;

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
            SudokuMatrix sm = new SudokuMatrix();
           
            mainWindow.Sudoku = Sudoku.GetInstance(mainWindow, sm);      // Get an instance of the ViewModel and set the View's ViewModel pointer
            sm.Sudoku = mainWindow.Sudoku;
            mainWindow.Show();                                                  // Now display the view
        }
    }
}
