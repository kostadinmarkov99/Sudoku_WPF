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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Sudoku sudoku;

        public MainWindow()
        {
            InitializeComponent();
        }

        internal Sudoku Sudoku
        {
            get { return sudoku; }
            set
            {
                sudoku = value;
                this.DataContext = value;

            }
        }


        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                ComboBoxItem typeItem = (ComboBoxItem)cboDifficulty.SelectedItem;
                string difficulty = typeItem.Content.ToString();

                Sudoku.startNewGame(difficulty);
            }
        }

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

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_MouseDoubleClick00(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(0, 0);
            }
        }
        private void TextBox_MouseDoubleClick01(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(0, 1);
            }
        }
        private void TextBox_MouseDoubleClick02(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(0, 2);
            }
        }
        private void TextBox_MouseDoubleClick03(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(0, 3);
            }
        }
        private void TextBox_MouseDoubleClick04(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(0, 4);
            }
        }
        private void TextBox_MouseDoubleClick05(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(0, 5);
            }
        }
        private void TextBox_MouseDoubleClick06(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(0, 6);
            }
        }
        private void TextBox_MouseDoubleClick07(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(0, 7);
            }
        }
        private void TextBox_MouseDoubleClick08(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(0, 8);
            }
        }
        private void TextBox_MouseDoubleClick10(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(1, 0);
            }
        }
        private void TextBox_MouseDoubleClick11(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(1, 1);
            }
        }
        private void TextBox_MouseDoubleClick12(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(1, 2);
            }
        }
        private void TextBox_MouseDoubleClick13(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(1, 3);
            }
        }
        private void TextBox_MouseDoubleClick14(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(1, 4);
            }
        }

        private void TextBox_MouseDoubleClick15(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(1, 5);
            }
        }

        private void TextBox_MouseDoubleClick16(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(1, 6);
            }
        }

        private void TextBox_MouseDoubleClick17(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(1, 7);
            }
        }

        private void TextBox_MouseDoubleClick18(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(1, 8);
            }
        }

        private void TextBox_MouseDoubleClick20(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(2, 0);
            }
        }

        private void TextBox_MouseDoubleClick21(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(2, 1);
            }
        }

        private void TextBox_MouseDoubleClick22(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(2, 2);
            }
        }

        private void TextBox_MouseDoubleClick23(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(2, 3);
            }
        }

        private void TextBox_MouseDoubleClick24(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(2, 4);
            }
        }

        private void TextBox_MouseDoubleClick25(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(2, 5);
            }
        }

        private void TextBox_MouseDoubleClick26(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(2, 6);
            }
        }

        private void TextBox_MouseDoubleClick27(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(2, 7);
            }
        }

        private void TextBox_MouseDoubleClick28(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(2, 8);
            }
        }

        private void TextBox_MouseDoubleClick30(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(3, 0);
            }
        }

        private void TextBox_MouseDoubleClick31(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(3, 1);
            }
        }

        private void TextBox_MouseDoubleClick32(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(3, 2);
            }
        }

        private void TextBox_MouseDoubleClick33(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(3, 3);
            }
        }

        private void TextBox_MouseDoubleClick34(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(3, 4);
            }
        }

        private void TextBox_MouseDoubleClick35(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(3, 5);
            }
        }

        private void TextBox_MouseDoubleClick36(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(3, 6);
            }
        }

        private void TextBox_MouseDoubleClick37(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(3, 7);
            }
        }

        private void TextBox_MouseDoubleClick38(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(3, 8);
            }
        }

        private void TextBox_MouseDoubleClick40(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(4, 0);
            }
        }

        private void TextBox_MouseDoubleClick41(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(4, 1);
            }
        }

        private void TextBox_MouseDoubleClick42(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(4, 2);
            }
        }

        private void TextBox_MouseDoubleClick43(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(4, 3);
            }
        }

        private void TextBox_MouseDoubleClick44(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(4, 4);
            }
        }

        private void TextBox_MouseDoubleClick45(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(4, 5);
            }
        }

        private void TextBox_MouseDoubleClick46(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(4, 6);
            }
        }

        private void TextBox_MouseDoubleClick47(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(4, 7);
            }
        }

        private void TextBox_MouseDoubleClick48(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(4, 8);
            }
        }

        private void TextBox_MouseDoubleClick50(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(5, 0);
            }
        }

        private void TextBox_MouseDoubleClick51(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;
            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(5, 1);
            }
        }

        private void TextBox_MouseDoubleClick52(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(5, 2);
            }
        }

        private void TextBox_MouseDoubleClick53(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(5, 3);
            }
        }

        private void TextBox_MouseDoubleClick54(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(5, 4);
            }
        }

        private void TextBox_MouseDoubleClick55(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(5, 5);
            }
        }

        private void TextBox_MouseDoubleClick56(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(5, 6);
            }
        }

        private void TextBox_MouseDoubleClick57(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(5, 7);
            }
        }

        private void TextBox_MouseDoubleClick58(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(5, 8);
            }
        }

        private void TextBox_MouseDoubleClick60(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(6, 0);
            }
        }

        private void TextBox_MouseDoubleClick61(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(6, 1);
            }
        }

        private void TextBox_MouseDoubleClick62(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(6, 2);
            }
        }

        private void TextBox_MouseDoubleClick63(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(6, 3);
            }
        }

        private void TextBox_MouseDoubleClick64(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(6, 4);
            }
        }

        private void TextBox_MouseDoubleClick65(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(6, 5);
            }
        }

        private void TextBox_MouseDoubleClick66(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(6, 6);
            }
        }

        private void TextBox_MouseDoubleClick67(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(6, 7);
            }
        }

        private void TextBox_MouseDoubleClick68(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(6, 8);
            }
        }

        private void TextBox_MouseDoubleClick70(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(7, 0);
            }
        }

        private void TextBox_MouseDoubleClick71(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(7, 1);
            }
        }

        private void TextBox_MouseDoubleClick72(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(7, 2);
            }
        }

        private void TextBox_MouseDoubleClick73(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(7, 3);
            }
        }

        private void TextBox_MouseDoubleClick74(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(7, 4);
            }
        }

        private void TextBox_MouseDoubleClick75(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(7, 5);
            }
        }

        private void TextBox_MouseDoubleClick76(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(7, 6);
            }
        }

        private void TextBox_MouseDoubleClick77(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(7, 7);
            }
        }

        private void TextBox_MouseDoubleClick78(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(7, 8);
            }
        }

        private void TextBox_MouseDoubleClick80(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(8, 0);
            }
        }

        private void TextBox_MouseDoubleClick81(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(8, 1);
            }
        }

        private void TextBox_MouseDoubleClick82(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(8, 2);
            }
        }

        private void TextBox_MouseDoubleClick83(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(8, 3);
            }
        }

        private void TextBox_MouseDoubleClick84(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(8, 4);
            }
        }

        private void TextBox_MouseDoubleClick85(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(8, 5);
            }
        }


        private void TextBox_MouseDoubleClick86(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(8, 6);
            }
        }

        private void TextBox_MouseDoubleClick87(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(8, 7);
            }
        }

        private void TextBox_MouseDoubleClick88(object sender, MouseButtonEventArgs e)
        {
            var objectClicked = (sender as System.Windows.Controls.TextBox);
            bool isReadOnly = objectClicked.IsReadOnly;

            if (Sudoku != null && !isReadOnly)
            {
                Sudoku.CellClicked(8, 8);
            }
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {

            if (Sudoku != null)
            {
                Sudoku.PauseGame();
            }
        }

        private void btnResume_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                Sudoku.ResumeGame();
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                Sudoku.ResetGame();
            }
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                Sudoku.CheckResult();
            }
        }

        private void mnuUndo_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                Sudoku.UndoClicked();
            }
        }

        private void mnuRedo_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                Sudoku.RedoClicked();
            }
        }

        private void mnuStatistic_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                //Sudoku.CheckResult();
            }
        }

        private void mnuShowSolution_Click(object sender, RoutedEventArgs e)
        {
            if (Sudoku != null)
            {
                //Sudoku.CheckResult();
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
    }
}
