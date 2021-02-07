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

namespace WpfApp4.View
{
    /// <summary>
    /// Interaction logic for inpudPad.xaml
    /// </summary>
    public partial class inpudPad : Window
    {
        #region . Constructors .

        /// <summary>
        /// Initializes a new instance of the InputPad window.
        /// </summary>
        public inpudPad()
        {
            InitializeComponent();
        }

        #endregion

        private string clickedValue = "0";

        #region . Public Read-only properties .

        #endregion

        #region . Form Event Handlers .

        public string ClikedValue
        {
            get { return clickedValue; }
            set
            {
                switch (value)
                {
                    case "1": clickedValue = value; break;
                    case "2": clickedValue = value; break;
                    case "3": clickedValue = value; break;
                    case "4": clickedValue = value; break;
                    case "5": clickedValue = value; break;
                    case "6": clickedValue = value; break;
                    case "7": clickedValue = value; break;
                    case "8": clickedValue = value; break;
                    case "9": clickedValue = value; break;
                    default: clickedValue = "0"; break;
                }
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            SaveState("1");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            SaveState("2");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            SaveState("3");
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            SaveState("4");
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            SaveState("5");
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            SaveState("6");
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            SaveState("7");
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            SaveState("8");
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            SaveState("9");
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            SaveState("0");
        }

        #endregion

        #region . Private methods .

        private void SaveState(string number)
        {
            clickedValue = number;                              // Save the state to the property.*/
            this.Close();                                       // Close the window.
        }

        #endregion
    }
}
