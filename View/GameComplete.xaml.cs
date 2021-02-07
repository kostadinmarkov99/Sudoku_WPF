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
using System.Windows.Shapes;

namespace Sudoku_WPF.View
{
    /// <summary>
    /// Interaction logic for GameComplete.xaml
    /// </summary>
    public partial class GameComplete : Window
    {
        #region . Constructors .

        /// <summary>
        /// Initializes a new instance of the GameComplete window.
        /// </summary>
        /// <param name="message">Message to display in this form.</param>
        public GameComplete(Sudoku vm)
        {
            InitializeComponent();

            this.DataContext = vm;          // Set the data context for this window
        }

        #endregion

        #region . Form Event Handlers .

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();               // OK button pressed.  Close the window.
        }

        #endregion
    }
}
