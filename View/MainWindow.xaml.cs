using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Windows.Forms;
using WpfApp4.View;

namespace WpfApp4.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Sudoku prop of the class Sudoku
        /// </summary>
        private Sudoku sudoku;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sudoku getter and setter
        /// </summary>
        internal Sudoku Sudoku
        {
            get { return sudoku; }
            set
            {
                sudoku = value;
                this.DataContext = value;

            }
        }

        /// <summary>
        /// Function, triggered, when the user clicks the New Game Button
        /// </summary>
        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                ComboBoxItem typeItem = (ComboBoxItem)cboDifficulty.SelectedItem;
                string difficulty = typeItem.Content.ToString();

                Sudoku.LoadNewGame(difficulty);
            }
        }

        /// <summary>
        /// Function, that shows the InpudPad and returns selected number
        /// </summary>
        internal string ShowNumberPad()
        {
            inpudPad inputPad;
            try
            {
                inputPad = new inpudPad();                              // Instantiate a new instance of the window
                inputPad.Owner = this;                                  // Set the owner to this window
                System.Drawing.Point point = System.Windows.Forms.Control.MousePosition;    // Figure out the current mouse position relative to the whole screen
                inputPad.Left = point.X + 20;                           // Set the left edge equal to the mouse pointer + 20 pixels
                inputPad.Top = point.Y - (inputPad.Height / 2);         // Set the middle of the window vertically where the mouse clicked
                inputPad.ShowDialog();
                // Now show the dialog

                return inputPad.ClikedValue;
            }
            finally
            {
                inputPad = null;                                        // Release the window pointer
            }
        }

        /// <summary>
        /// Function, triggered, when the user clicks the Cancel Button
        /// </summary>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure you want to close the current session of Sudoku", "Quit", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                this.Close();
            }   
        }

        /// <summary>
        /// Function, triggered, when the user clicks the Pause Game Button
        /// </summary>
        private void btnPause_Click(object sender, RoutedEventArgs e)
        {

            if (Sudoku != null)
            {
                Sudoku.PauseGame();
            }
        }

        /// <summary>
        /// Function, triggered, when the user clicks the Resume Game Button
        /// </summary>
        private void btnResume_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                Sudoku.ResumeGame();
            }
        }

        /// <summary>
        /// Function, triggered, when the user clicks the Reset Game Button
        /// </summary>
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                Sudoku.ResetGame();
            }
        }

        /// <summary>
        /// Function, triggered, when the user clicks the Undo menu option 
        /// </summary>
        private void mnuUndo_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                Sudoku.UndoClicked();
            }
        }

        /// <summary>
        /// Function, triggered, when the user clicks the Redo menu option 
        /// </summary>
        private void mnuRedo_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                Sudoku.RedoClicked();
            }
        }

        /// <summary>
        /// Function, triggered, when the user clicks the Statistic menu option 
        /// </summary>
        private void mnuStatistic_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                Sudoku.StatisticClicked();
            }
        }

        /// <summary>
        /// Function, triggered, when the user clicks the Show Solution menu option 
        /// </summary>
        private void mnuShowSolution_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                Sudoku.ShowSolution();
            }
        }

        /// <summary>
        /// Launch the Game Complete dialog.
        /// </summary>
        internal void ShowGameCompletedDialog()
        {
            GameComplete gameComplete;
            try
            {
                gameComplete = new GameComplete(Sudoku);        // Instantiate a new instance of the window and pass it the ViewModel instance
                gameComplete.Owner = this;                          // Set the owner to this window
                gameComplete.ShowDialog();                          // Display the dialog
            }
            finally
            {
                gameComplete = null;                                // Release the window pointer
            }
        }

        /// <summary>
        /// Launch the Game Complete dialog.
        /// </summary>
        internal string ShowOldGameDialog()
        {
            NewGame oldGame;
            try
            {
                oldGame = new NewGame();        // Instantiate a new instance of the window and pass it the ViewModel instance
                oldGame.Owner = this;                          // Set the owner to this window
                oldGame.ShowDialog();                          // Display the dialog

                return oldGame.FileName;
            }
            finally
            {
                oldGame = null;                                // Release the window pointer
            }
        }

        /// <summary>
        /// Launch the Game Complete dialog.
        /// </summary>
        internal void ShowGameStatisticDialog()
        {
            StatisticWindow gameStat;
            try
            {
                gameStat = new StatisticWindow(Sudoku);        // Instantiate a new instance of the window and pass it the Sudoku instance
                gameStat.Owner = this;                          // Set the owner to this window
                gameStat.ShowDialog();                          // Display the dialog
            }
            finally
            {
                gameStat = null;                                // Release the window pointer
            }
        }

        /// <summary>
        /// Launch the Game Save dialog.
        /// </summary>
        internal string ShowGameSaveDialog()
        {
               SaveGame saveGame;
            try
            {
                saveGame = new SaveGame();                              // Instantiate a new instance of the window
                saveGame.Owner = this;                                  // Set the owner to this window
                System.Drawing.Point point = System.Windows.Forms.Control.MousePosition;    // Figure out the current mouse position relative to the whole screen
                saveGame.Left = point.X + 20;                           // Set the left edge equal to the mouse pointer + 20 pixels
                saveGame.Top = point.Y - (saveGame.Height / 2);         // Set the middle of the window vertically where the mouse clicked
                saveGame.ShowDialog();
                // Now show the dialog

                return saveGame.FileName;
            }
            finally
            {
                saveGame = null;                                        // Release the window pointer
            }
        }

        /// <summary>
        /// Save the Current Game for the future.
        /// </summary>
        /// 
        private void mnuSave_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                System.Windows.Controls.ComboBox cb = cboDifficulty;

                Sudoku.SaveClick(cb);
            }
        }

        /// <summary>
        /// Save the Current Game for the future.
        /// </summary>
        private void mnuNewGame_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                System.Windows.Controls.ComboBox cb = cboDifficulty;

                Sudoku.NewGameClick(cb);
            }
        }
        
        /// <summary>
        /// Check is the Current Game for solved.
        /// </summary>
        private void mnuCheckSolution_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                Sudoku.CheckResult();
            }
        }
    }
}
