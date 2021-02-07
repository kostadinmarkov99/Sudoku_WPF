using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for SaveGame.xaml
    /// </summary>
    public partial class SaveGame : Window
    {
        public SaveGame()
        {
            InitializeComponent();
        }

        private string fileName = "";

        public string FileName
        {
            get { return fileName; }
            set
            {
                fileName = value;
            }
        }

        private void btnSaveGame_Click(object sender, RoutedEventArgs e)
        {
            string textInTexBox = tbxFileName.Text;

            SaveName(textInTexBox);
        }

        private void btnCanselSaveGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            tbxFileName.Text = string.Concat(tbxFileName.Text.Where(char.IsLetterOrDigit));
        }

        private void SaveName(string name)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show($"Are you sure you want save this game with name {name}?", "Start New Game", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                FileName = name;
                this.Close();
            }
        }
    }
}
