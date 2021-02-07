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
    /// Interaction logic for StatisticWindow.xaml
    /// </summary>
    public partial class StatisticWindow : Window
    {
        public StatisticWindow(Sudoku vm)
        {
            InitializeComponent();

            this.DataContext = vm;          // Set the data context for this window
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
