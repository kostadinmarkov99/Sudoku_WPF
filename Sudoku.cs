using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp4
{
    public class Sudoku : INotifyPropertyChanged
    {
        private string[,] matrix = new string[9, 9];
        private string[,] startingMatrix;
        private string[,] solvedMatrix;
        private MainWindow _view;                               // Save the window
        private TimerClass _timer = new TimerClass();                              // Instantiate a new timer class
        private static Sudoku _instance;
        private string _gameTimeElapsed;
        Stack<Tuple<Tuple<int, int>, string>> moves = new Stack<Tuple<Tuple<int, int>, string>>();
        Stack<Tuple<Tuple<int, int>, string>> movesRedo = new Stack<Tuple<Tuple<int, int>, string>>();
        Stack<Tuple<Tuple<int, int>, string>> movesCopy = new Stack<Tuple<Tuple<int, int>, string>>();
        Stack<Tuple<Tuple<int, int>, string>> movesRedoCopy = new Stack<Tuple<Tuple<int, int>, string>>();
        int lastRowInStack = -1;
        int lastColInStack = -1;
        bool doNotFill = false;
        private int movesNumber;

        public int MovesNumber
        {
            get { return movesNumber; }
            set
            {
                movesNumber = value;
            }
        }

        private List<string> last00 = new List<string>();
        private List<string> last01 = new List<string>();
        private List<string> last02 = new List<string>();
        private List<string> last03 = new List<string>();
        private List<string> last04 = new List<string>();
        private List<string> last05 = new List<string>();
        private List<string> last06 = new List<string>();
        private List<string> last07 = new List<string>();
        private List<string> last08 = new List<string>();
        private List<string> last10 = new List<string>();
        private List<string> last11 = new List<string>();
        private List<string> last12 = new List<string>();
        private List<string> last13 = new List<string>();
        private List<string> last14 = new List<string>();
        private List<string> last15 = new List<string>();
        private List<string> last16 = new List<string>();
        private List<string> last17 = new List<string>();
        private List<string> last18 = new List<string>();
        private List<string> last20 = new List<string>();
        private List<string> last21 = new List<string>();
        private List<string> last22 = new List<string>();
        private List<string> last23 = new List<string>();
        private List<string> last24 = new List<string>();
        private List<string> last25 = new List<string>();
        private List<string> last26 = new List<string>();
        private List<string> last27 = new List<string>();
        private List<string> last28 = new List<string>();
        private List<string> last30 = new List<string>();
        private List<string> last31 = new List<string>();
        private List<string> last32 = new List<string>();
        private List<string> last33 = new List<string>();
        private List<string> last34 = new List<string>();
        private List<string> last35 = new List<string>();
        private List<string> last36 = new List<string>();
        private List<string> last37 = new List<string>();
        private List<string> last38 = new List<string>();
        private List<string> last40 = new List<string>();
        private List<string> last41 = new List<string>();
        private List<string> last42 = new List<string>();
        private List<string> last43 = new List<string>();
        private List<string> last44 = new List<string>();
        private List<string> last45 = new List<string>();
        private List<string> last46 = new List<string>();
        private List<string> last47 = new List<string>();
        private List<string> last48 = new List<string>();
        private List<string> last50 = new List<string>();
        private List<string> last51 = new List<string>();
        private List<string> last52 = new List<string>();
        private List<string> last53 = new List<string>();
        private List<string> last54 = new List<string>();
        private List<string> last55 = new List<string>();
        private List<string> last56 = new List<string>();
        private List<string> last57 = new List<string>();
        private List<string> last58 = new List<string>();
        private List<string> last60 = new List<string>();
        private List<string> last61 = new List<string>();
        private List<string> last62 = new List<string>();
        private List<string> last63 = new List<string>();
        private List<string> last64 = new List<string>();
        private List<string> last65 = new List<string>();
        private List<string> last66 = new List<string>();
        private List<string> last67 = new List<string>();
        private List<string> last68 = new List<string>();
        private List<string> last70 = new List<string>();
        private List<string> last71 = new List<string>();
        private List<string> last72 = new List<string>();
        private List<string> last73 = new List<string>();
        private List<string> last74 = new List<string>();
        private List<string> last75 = new List<string>();
        private List<string> last76 = new List<string>();
        private List<string> last77 = new List<string>();
        private List<string> last78 = new List<string>();
        private List<string> last80 = new List<string>();
        private List<string> last81 = new List<string>();
        private List<string> last82 = new List<string>();
        private List<string> last83 = new List<string>();
        private List<string> last84 = new List<string>();
        private List<string> last85 = new List<string>();
        private List<string> last86 = new List<string>();
        private List<string> last87 = new List<string>();
        private List<string> last88 = new List<string>();

        public List<string> Last00
        {
            get { return last00; }
            set { last00 = value; }
        }

        public List<string> Last01
        {
            get { return last01; }
            set { last01 = value; }
        }

        public List<string> Last02
        {
            get { return last02; }
            set { last02 = value; }
        }

        public List<string> Last03
        {
            get { return last03; }
            set { last03 = value; }
        }

        public List<string> Last04
        {
            get { return last04; }
            set { last04 = value; }
        }

        public List<string> Last05
        {
            get { return last05; }
            set { last05 = value; }
        }

        public List<string> Last06
        {
            get { return last06; }
            set { last06 = value; }
        }
        public List<string> Last07
        {
            get { return last07; }
            set { last07 = value; }
        }

        public List<string> Last08
        {
            get { return last08; }
            set { last08 = value; }
        }

        public List<string> Last10
        {
            get { return last10; }
            set { last10 = value; }
        }

        public List<string> Last11
        {
            get { return last11; }
            set { last11 = value; }
        }

        public List<string> Last12
        {
            get { return last12; }
            set { last12 = value; }
        }

        public List<string> Last13
        {
            get { return last13; }
            set { last13 = value; }
        }

        public List<string> Last14
        {
            get { return last14; }
            set { last14 = value; }
        }

        public List<string> Last15
        {
            get { return last15; }
            set { last15 = value; }
        }

        public List<string> Last16
        {
            get { return last16; }
            set { last16 = value; }
        }
        public List<string> Last17
        {
            get { return last17; }
            set { last17 = value; }
        }

        public List<string> Last18
        {
            get { return last18; }
            set { last18 = value; }
        }
        public List<string> Last20
        {
            get { return last20; }
            set { last20 = value; }
        }

        public List<string> Last21
        {
            get { return last21; }
            set { last21 = value; }
        }

        public List<string> Last22
        {
            get { return last22; }
            set { last22 = value; }
        }

        public List<string> Last23
        {
            get { return last23; }
            set { last23 = value; }
        }

        public List<string> Last24
        {
            get { return last24; }
            set { last24 = value; }
        }

        public List<string> Last25
        {
            get { return last25; }
            set { last25 = value; }
        }

        public List<string> Last26
        {
            get { return last26; }
            set { last26 = value; }
        }
        public List<string> Last27
        {
            get { return last27; }
            set { last27 = value; }
        }

        public List<string> Last28
        {
            get { return last28; }
            set { last28 = value; }
        }
        public List<string> Last30
        {
            get { return last30; }
            set { last30 = value; }
        }

        public List<string> Last31
        {
            get { return last31; }
            set { last31 = value; }
        }

        public List<string> Last32
        {
            get { return last32; }
            set { last32 = value; }
        }

        public List<string> Last33
        {
            get { return last33; }
            set { last33 = value; }
        }

        public List<string> Last34
        {
            get { return last34; }
            set { last34 = value; }
        }

        public List<string> Last35
        {
            get { return last35; }
            set { last35 = value; }
        }

        public List<string> Last36
        {
            get { return last36; }
            set { last36 = value; }
        }
        public List<string> Last37
        {
            get { return last37; }
            set { last37 = value; }
        }

        public List<string> Last38
        {
            get { return last38; }
            set { last38 = value; }
        }

        public List<string> Last40
        {
            get { return last40; }
            set { last40 = value; }
        }

        public List<string> Last41
        {
            get { return last41; }
            set { last41 = value; }
        }

        public List<string> Last42
        {
            get { return last42; }
            set { last42 = value; }
        }

        public List<string> Last43
        {
            get { return last43; }
            set { last43 = value; }
        }

        public List<string> Last44
        {
            get { return last44; }
            set { last44 = value; }
        }

        public List<string> Last45
        {
            get { return last45; }
            set { last45 = value; }
        }

        public List<string> Last46
        {
            get { return last46; }
            set { last46 = value; }
        }
        public List<string> Last47
        {
            get { return last47; }
            set { last47 = value; }
        }

        public List<string> Last48
        {
            get { return last48; }
            set { last48 = value; }
        }

        public List<string> Last50
        {
            get { return last50; }
            set { last50 = value; }
        }

        public List<string> Last51
        {
            get { return last51; }
            set { last51 = value; }
        }

        public List<string> Last52
        {
            get { return last52; }
            set { last52 = value; }
        }

        public List<string> Last53
        {
            get { return last53; }
            set { last53 = value; }
        }

        public List<string> Last54
        {
            get { return last54; }
            set { last54 = value; }
        }

        public List<string> Last55
        {
            get { return last55; }
            set { last55 = value; }
        }

        public List<string> Last56
        {
            get { return last56; }
            set { last56 = value; }
        }
        public List<string> Last57
        {
            get { return last57; }
            set { last57 = value; }
        }

        public List<string> Last58
        {
            get { return last58; }
            set { last58 = value; }
        }

        public List<string> Last60
        {
            get { return last60; }
            set { last60 = value; }
        }

        public List<string> Last61
        {
            get { return last61; }
            set { last61 = value; }
        }

        public List<string> Last62
        {
            get { return last62; }
            set { last62 = value; }
        }

        public List<string> Last63
        {
            get { return last63; }
            set { last63 = value; }
        }

        public List<string> Last64
        {
            get { return last64; }
            set { last64 = value; }
        }

        public List<string> Last65
        {
            get { return last65; }
            set { last65 = value; }
        }

        public List<string> Last66
        {
            get { return last66; }
            set { last66 = value; }
        }
        public List<string> Last67
        {
            get { return last67; }
            set { last67 = value; }
        }

        public List<string> Last68
        {
            get { return last68; }
            set { last68 = value; }
        }
        public List<string> Last70
        {
            get { return last70; }
            set { last70 = value; }
        }

        public List<string> Last71
        {
            get { return last71; }
            set { last71 = value; }
        }

        public List<string> Last72
        {
            get { return last72; }
            set { last72 = value; }
        }

        public List<string> Last73
        {
            get { return last73; }
            set { last73 = value; }
        }

        public List<string> Last74
        {
            get { return last74; }
            set { last74 = value; }
        }

        public List<string> Last75
        {
            get { return last75; }
            set { last75 = value; }
        }

        public List<string> Last76
        {
            get { return last76; }
            set { last76 = value; }
        }
        public List<string> Last77
        {
            get { return last77; }
            set { last77 = value; }
        }

        public List<string> Last78
        {
            get { return last78; }
            set { last78 = value; }
        }
        public List<string> Last80
        {
            get { return last80; }
            set { last80 = value; }
        }

        public List<string> Last81
        {
            get { return last81; }
            set { last81 = value; }
        }

        public List<string> Last82
        {
            get { return last82; }
            set { last82 = value; }
        }

        public List<string> Last83
        {
            get { return last83; }
            set { last83 = value; }
        }

        public List<string> Last84
        {
            get { return last84; }
            set { last84 = value; }
        }

        public List<string> Last85
        {
            get { return last85; }
            set { last85 = value; }
        }

        public List<string> Last86
        {
            get { return last86; }
            set { last86 = value; }
        }
        public List<string> Last87
        {
            get { return last87; }
            set { last87 = value; }
        }

        public List<string> Last88
        {
            get { return last88; }
            set { last88 = value; }
        }

        private bool GameInProgress { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public string[,] Matrix
        {
            get { return matrix; }
            set
            {
                matrix = value;
            }
        }

        public string[,] StartingMatrix
        {
            get { return startingMatrix; }
            set
            {
                startingMatrix = matrix;
            }
        }

        public string[,] SolvedMatrix
        {
            get { return solvedMatrix; }
            set
            {
                solvedMatrix = value;
            }
        }

        /// <summary>
        /// Gets the elapsed time from the timer class.
        /// </summary>
        public string ElapsedTime
        {
            get
            {
                if (GameInProgress)                         // Is the game in progress
                {
                    if (_timer == null)                     // Yes, is the timer variable null?
                        return "";                          // Yes, then return a blank string
                    return _timer.ElapsedTime;              // No, return the timer's elapsed time
                }
                else
                    return "";                              // No game, so return a blank string
            }
            private set
            {
                OnPropertyChanged("ElapsedTime");                        // If set, raise the property change flag
            }
        }

        public string GameTimeElapsed
        {
            get
            {
                return _gameTimeElapsed;
            }
            private set
            {
                _gameTimeElapsed = string.Format("Your time is {0}.", value);
            }
        }

        public Stack<Tuple<Tuple<int, int>, string>> Moves
        {
            get { return moves; }
            set
            {
                moves = value;
            }
        }

        public Stack<Tuple<Tuple<int, int>, string>> MovesRedo
        {
            get { return movesRedo; }
            set
            {
                movesRedo = value;
            }
        }

        public Stack<Tuple<Tuple<int, int>, string>> MovesCopy
        {
            get { return movesCopy; }
            set
            {
                movesCopy = value;
            }
        }

        public Stack<Tuple<Tuple<int, int>, string>> MovesRedoCopy
        {
            get { return movesRedoCopy; }
            set
            {
                movesRedoCopy = value;
            }
        }

        private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        #region Private Properties for cells
        private string get00;
        private string get01;
        private string get02;
        private string get03;
        private string get04;
        private string get05;
        private string get06;
        private string get07;
        private string get08;
        private string get10;
        private string get11;
        private string get12;
        private string get13;
        private string get14;
        private string get15;
        private string get16;
        private string get17;
        private string get18;
        private string get20;
        private string get21;
        private string get22;
        private string get23;
        private string get24;
        private string get25;
        private string get26;
        private string get27;
        private string get28;
        private string get30;
        private string get31;
        private string get32;
        private string get33;
        private string get34;
        private string get35;
        private string get36;
        private string get37;
        private string get38;
        private string get40;
        private string get41;
        private string get42;
        private string get43;
        private string get44;
        private string get45;
        private string get46;
        private string get47;
        private string get48;
        private string get50;
        private string get51;
        private string get52;
        private string get53;
        private string get54;
        private string get55;
        private string get56;
        private string get57;
        private string get58;
        private string get60;
        private string get61;
        private string get62;
        private string get63;
        private string get64;
        private string get65;
        private string get66;
        private string get67;
        private string get68;
        private string get70;
        private string get71;
        private string get72;
        private string get73;
        private string get74;
        private string get75;
        private string get76;
        private string get77;
        private string get78;
        private string get80;
        private string get81;
        private string get82;
        private string get83;
        private string get84;
        private string get85;
        private string get86;
        private string get87;
        private string get88;
        #endregion


        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private bool IsEnabled00 = true;
        private bool IsEnabled01 = true;
        private bool IsEnabled02 = true;
        private bool IsEnabled03 = true;
        private bool IsEnabled04 = true;
        private bool IsEnabled05 = true;
        private bool IsEnabled06 = true;
        private bool IsEnabled07 = true;
        private bool IsEnabled08 = true;
        private bool IsEnabled10 = true;
        private bool IsEnabled11 = true;
        private bool IsEnabled12 = true;
        private bool IsEnabled13 = true;
        private bool IsEnabled14 = true;
        private bool IsEnabled15 = true;
        private bool IsEnabled16 = true;
        private bool IsEnabled17 = true;
        private bool IsEnabled18 = true;
        private bool IsEnabled20 = true;
        private bool IsEnabled21 = true;
        private bool IsEnabled22 = true;
        private bool IsEnabled23 = true;
        private bool IsEnabled24 = true;
        private bool IsEnabled25 = true;
        private bool IsEnabled26 = true;
        private bool IsEnabled27 = true;
        private bool IsEnabled28 = true;
        private bool IsEnabled30 = true;
        private bool IsEnabled31 = true;
        private bool IsEnabled32 = true;
        private bool IsEnabled33 = true;
        private bool IsEnabled34 = true;
        private bool IsEnabled35 = true;
        private bool IsEnabled36 = true;
        private bool IsEnabled37 = true;
        private bool IsEnabled38 = true;
        private bool IsEnabled40 = true;
        private bool IsEnabled41 = true;
        private bool IsEnabled42 = true;
        private bool IsEnabled43 = true;
        private bool IsEnabled44 = true;
        private bool IsEnabled45 = true;
        private bool IsEnabled46 = true;
        private bool IsEnabled47 = true;
        private bool IsEnabled48 = true;
        private bool IsEnabled50 = true;
        private bool IsEnabled51 = true;
        private bool IsEnabled52 = true;
        private bool IsEnabled53 = true;
        private bool IsEnabled54 = true;
        private bool IsEnabled55 = true;
        private bool IsEnabled56 = true;
        private bool IsEnabled57 = true;
        private bool IsEnabled58 = true;
        private bool IsEnabled60 = true;
        private bool IsEnabled61 = true;
        private bool IsEnabled62 = true;
        private bool IsEnabled63 = true;
        private bool IsEnabled64 = true;
        private bool IsEnabled65 = true;
        private bool IsEnabled66 = true;
        private bool IsEnabled67 = true;
        private bool IsEnabled68 = true;
        private bool IsEnabled70 = true;
        private bool IsEnabled71 = true;
        private bool IsEnabled72 = true;
        private bool IsEnabled73 = true;
        private bool IsEnabled74 = true;
        private bool IsEnabled75 = true;
        private bool IsEnabled76 = true;
        private bool IsEnabled77 = true;
        private bool IsEnabled78 = true;
        private bool IsEnabled80 = true;
        private bool IsEnabled81 = true;
        private bool IsEnabled82 = true;
        private bool IsEnabled83 = true;
        private bool IsEnabled84 = true;
        private bool IsEnabled85 = true;
        private bool IsEnabled86 = true;
        private bool IsEnabled87 = true;
        private bool IsEnabled88 = true;

        private string isVisiblePausedButton = "Visible";
        private string isVisibleResumeButton = "Hidden";

        private string isVisibleTopLeftRectangle = "Visible";
        private string isVisibleToMiddleRectangle = "Visible";
        private string isVisibleTopRightRectangle = "Visible";
        private string isVisibleMiddleLeftRectangle = "Visible";
        private string isVisibleMiddleMiddleRectangle = "Visible";
        private string isVisibleMiddleRightRectangle = "Visible";
        private string isVisibleBottomLeftRectangle = "Visible";
        private string isVisibleBottomMiddleRectangle = "Visible";
        private string isVisibleBottomRightRectangle = "Visible";

        private bool isEnabledPausedButton = false;
        private bool isEnabledResetButton = false;
        private bool isEnabledCheckedButton = false;

        #region IsEnabled Public
        public bool IsEnabledCheckedButton
        {
            get { return isEnabledCheckedButton; }
            set
            {
                isEnabledCheckedButton = value;
                OnPropertyChanged("IsEnabledCheckedButton");
            }
        }
        public bool IsEnabledResetButton
        {
            get { return isEnabledResetButton; }
            set
            {
                isEnabledResetButton = value;
                OnPropertyChanged("IsEnabledResetButton");
            }
        }
        public bool IsEnabledPausedButton
        {
            get { return isEnabledPausedButton; }
            set
            {
                isEnabledPausedButton = value;
                OnPropertyChanged("IsEnabledPausedButton");
            }
        }
        public bool TextBoxEnabled00
        {
            get { return IsEnabled00; }
            set
            {
                IsEnabled00 = value;
                NotifyPropertyChanged("TextBoxEnabled00");
            }
        }
        public bool TextBoxEnabled01
        {
            get { return IsEnabled01; }

            set
            {
                IsEnabled01 = value;
                NotifyPropertyChanged("TextBoxEnabled01");
            }
        }
        public bool TextBoxEnabled02
        {
            get { return IsEnabled02; }
            set
            {
                IsEnabled02 = value;
                NotifyPropertyChanged("TextBoxEnabled02");
            }
        }
        public bool TextBoxEnabled03
        {
            get { return IsEnabled03; }
            set
            {
                IsEnabled03 = value;
                NotifyPropertyChanged("TextBoxEnabled03");
            }
        }
        public bool TextBoxEnabled04
        {
            get { return IsEnabled04; }

            set
            {
                IsEnabled04 = value;
                NotifyPropertyChanged("TextBoxEnabled04");
            }
        }
        public bool TextBoxEnabled05
        {
            get { return IsEnabled05; }

            set
            {
                IsEnabled05 = value;
                NotifyPropertyChanged("TextBoxEnabled05");
            }
        }
        public bool TextBoxEnabled06
        {
            get { return IsEnabled06; }

            set
            {
                IsEnabled06 = value;
                NotifyPropertyChanged("TextBoxEnabled06");
            }
        }
        public bool TextBoxEnabled07
        {
            get { return IsEnabled07; }

            set
            {
                IsEnabled07 = value;
                NotifyPropertyChanged("TextBoxEnabled07");
            }
        }
        public bool TextBoxEnabled08
        {
            get { return IsEnabled08; }

            set
            {
                IsEnabled08 = value;
                NotifyPropertyChanged("TextBoxEnabled08");
            }
        }
        public bool TextBoxEnabled10
        {
            get { return IsEnabled10; }
            set
            {
                IsEnabled10 = value;
                NotifyPropertyChanged("TextBoxEnabled10");
            }
        }
        public bool TextBoxEnabled11
        {
            get { return IsEnabled11; }

            set
            {
                IsEnabled11 = value;
                NotifyPropertyChanged("TextBoxEnabled11");
            }
        }
        public bool TextBoxEnabled12
        {
            get { return IsEnabled12; }
            set
            {
                IsEnabled12 = value;
                NotifyPropertyChanged("TextBoxEnabled12");
            }
        }
        public bool TextBoxEnabled13
        {
            get { return IsEnabled13; }
            set
            {
                IsEnabled13 = value;
                NotifyPropertyChanged("TextBoxEnabled13");
            }
        }
        public bool TextBoxEnabled14
        {
            get { return IsEnabled14; }

            set
            {
                IsEnabled14 = value;
                NotifyPropertyChanged("TextBoxEnabled14");
            }
        }
        public bool TextBoxEnabled15
        {
            get { return IsEnabled15; }

            set
            {
                IsEnabled15 = value;
                NotifyPropertyChanged("TextBoxEnabled15");
            }
        }
        public bool TextBoxEnabled16
        {
            get { return IsEnabled16; }

            set
            {
                IsEnabled16 = value;
                NotifyPropertyChanged("TextBoxEnabled16");
            }
        }
        public bool TextBoxEnabled17
        {
            get { return IsEnabled17; }

            set
            {
                IsEnabled17 = value;
                NotifyPropertyChanged("TextBoxEnabled17");
            }
        }
        public bool TextBoxEnabled18
        {
            get { return IsEnabled18; }

            set
            {
                IsEnabled18 = value;
                NotifyPropertyChanged("TextBoxEnabled18");
            }
        }
        public bool TextBoxEnabled20
        {
            get { return IsEnabled20; }
            set
            {
                IsEnabled20 = value;
                NotifyPropertyChanged("TextBoxEnabled20");
            }
        }
        public bool TextBoxEnabled21
        {
            get { return IsEnabled21; }

            set
            {
                IsEnabled21 = value;
                NotifyPropertyChanged("TextBoxEnabled21");
            }
        }
        public bool TextBoxEnabled22
        {
            get { return IsEnabled22; }
            set
            {
                IsEnabled22 = value;
                NotifyPropertyChanged("TextBoxEnabled22");
            }
        }
        public bool TextBoxEnabled23
        {
            get { return IsEnabled23; }
            set
            {
                IsEnabled23 = value;
                NotifyPropertyChanged("TextBoxEnabled23");
            }
        }
        public bool TextBoxEnabled24
        {
            get { return IsEnabled24; }

            set
            {
                IsEnabled24 = value;
                NotifyPropertyChanged("TextBoxEnabled24");
            }
        }
        public bool TextBoxEnabled25
        {
            get { return IsEnabled25; }

            set
            {
                IsEnabled25 = value;
                NotifyPropertyChanged("TextBoxEnabled25");
            }
        }
        public bool TextBoxEnabled26
        {
            get { return IsEnabled26; }

            set
            {
                IsEnabled26 = value;
                NotifyPropertyChanged("TextBoxEnabled26");
            }
        }
        public bool TextBoxEnabled27
        {
            get { return IsEnabled27; }

            set
            {
                IsEnabled27 = value;
                NotifyPropertyChanged("TextBoxEnabled27");
            }
        }
        public bool TextBoxEnabled28
        {
            get { return IsEnabled28; }

            set
            {
                IsEnabled28 = value;
                NotifyPropertyChanged("TextBoxEnabled28");
            }
        }
        public bool TextBoxEnabled30
        {
            get { return IsEnabled30; }
            set
            {
                IsEnabled30 = value;
                NotifyPropertyChanged("TextBoxEnabled30");
            }
        }
        public bool TextBoxEnabled31
        {
            get { return IsEnabled31; }

            set
            {
                IsEnabled31 = value;
                NotifyPropertyChanged("TextBoxEnabled31");
            }
        }
        public bool TextBoxEnabled32
        {
            get { return IsEnabled32; }
            set
            {
                IsEnabled32 = value;
                NotifyPropertyChanged("TextBoxEnabled32");
            }
        }
        public bool TextBoxEnabled33
        {
            get { return IsEnabled33; }
            set
            {
                IsEnabled33 = value;
                NotifyPropertyChanged("TextBoxEnabled33");
            }
        }
        public bool TextBoxEnabled34
        {
            get { return IsEnabled34; }

            set
            {
                IsEnabled34 = value;
                NotifyPropertyChanged("TextBoxEnabled34");
            }
        }
        public bool TextBoxEnabled35
        {
            get { return IsEnabled35; }

            set
            {
                IsEnabled35 = value;
                NotifyPropertyChanged("TextBoxEnabled35");
            }
        }
        public bool TextBoxEnabled36
        {
            get { return IsEnabled36; }

            set
            {
                IsEnabled36 = value;
                NotifyPropertyChanged("TextBoxEnabled36");
            }
        }
        public bool TextBoxEnabled37
        {
            get { return IsEnabled37; }

            set
            {
                IsEnabled37 = value;
                NotifyPropertyChanged("TextBoxEnabled37");
            }
        }
        public bool TextBoxEnabled38
        {
            get { return IsEnabled38; }

            set
            {
                IsEnabled38 = value;
                NotifyPropertyChanged("TextBoxEnabled38");
            }
        }
        public bool TextBoxEnabled40
        {
            get { return IsEnabled40; }
            set
            {
                IsEnabled40 = value;
                NotifyPropertyChanged("TextBoxEnabled40");
            }
        }
        public bool TextBoxEnabled41
        {
            get { return IsEnabled41; }

            set
            {
                IsEnabled41 = value;
                NotifyPropertyChanged("TextBoxEnabled41");
            }
        }
        public bool TextBoxEnabled42
        {
            get { return IsEnabled42; }
            set
            {
                IsEnabled42 = value;
                NotifyPropertyChanged("TextBoxEnabled42");
            }
        }
        public bool TextBoxEnabled43
        {
            get { return IsEnabled43; }
            set
            {
                IsEnabled43 = value;
                NotifyPropertyChanged("TextBoxEnabled43");
            }
        }
        public bool TextBoxEnabled44
        {
            get { return IsEnabled44; }

            set
            {
                IsEnabled44 = value;
                NotifyPropertyChanged("TextBoxEnabled44");
            }
        }
        public bool TextBoxEnabled45
        {
            get { return IsEnabled45; }

            set
            {
                IsEnabled45 = value;
                NotifyPropertyChanged("TextBoxEnabled45");
            }
        }
        public bool TextBoxEnabled46
        {
            get { return IsEnabled46; }

            set
            {
                IsEnabled46 = value;
                NotifyPropertyChanged("TextBoxEnabled46");
            }
        }
        public bool TextBoxEnabled47
        {
            get { return IsEnabled47; }

            set
            {
                IsEnabled47 = value;
                NotifyPropertyChanged("TextBoxEnabled47");
            }
        }
        public bool TextBoxEnabled48
        {
            get { return IsEnabled48; }

            set
            {
                IsEnabled48 = value;
                NotifyPropertyChanged("TextBoxEnabled48");
            }
        }
        public bool TextBoxEnabled50
        {
            get { return IsEnabled50; }
            set
            {
                IsEnabled50 = value;
                NotifyPropertyChanged("TextBoxEnabled50");
            }
        }
        public bool TextBoxEnabled51
        {
            get { return IsEnabled51; }

            set
            {
                IsEnabled51 = value;
                NotifyPropertyChanged("TextBoxEnabled51");
            }
        }
        public bool TextBoxEnabled52
        {
            get { return IsEnabled52; }
            set
            {
                IsEnabled52 = value;
                NotifyPropertyChanged("TextBoxEnabled52");
            }
        }
        public bool TextBoxEnabled53
        {
            get { return IsEnabled53; }
            set
            {
                IsEnabled53 = value;
                NotifyPropertyChanged("TextBoxEnabled53");
            }
        }
        public bool TextBoxEnabled54
        {
            get { return IsEnabled54; }

            set
            {
                IsEnabled54 = value;
                NotifyPropertyChanged("TextBoxEnabled54");
            }
        }
        public bool TextBoxEnabled55
        {
            get { return IsEnabled55; }

            set
            {
                IsEnabled55 = value;
                NotifyPropertyChanged("TextBoxEnabled55");
            }
        }
        public bool TextBoxEnabled56
        {
            get { return IsEnabled56; }

            set
            {
                IsEnabled56 = value;
                NotifyPropertyChanged("TextBoxEnabled56");
            }
        }
        public bool TextBoxEnabled57
        {
            get { return IsEnabled57; }

            set
            {
                IsEnabled57 = value;
                NotifyPropertyChanged("TextBoxEnabled57");
            }
        }
        public bool TextBoxEnabled58
        {
            get { return IsEnabled58; }

            set
            {
                IsEnabled58 = value;
                NotifyPropertyChanged("TextBoxEnabled58");
            }
        }

        public bool TextBoxEnabled60
        {
            get { return IsEnabled60; }
            set
            {
                IsEnabled60 = value;
                NotifyPropertyChanged("TextBoxEnabled60");
            }
        }
        public bool TextBoxEnabled61
        {
            get { return IsEnabled61; }

            set
            {
                IsEnabled61 = value;
                NotifyPropertyChanged("TextBoxEnabled61");
            }
        }
        public bool TextBoxEnabled62
        {
            get { return IsEnabled62; }
            set
            {
                IsEnabled62 = value;
                NotifyPropertyChanged("TextBoxEnabled62");
            }
        }
        public bool TextBoxEnabled63
        {
            get { return IsEnabled63; }
            set
            {
                IsEnabled63 = value;
                NotifyPropertyChanged("TextBoxEnabled63");
            }
        }
        public bool TextBoxEnabled64
        {
            get { return IsEnabled64; }

            set
            {
                IsEnabled64 = value;
                NotifyPropertyChanged("TextBoxEnabled64");
            }
        }
        public bool TextBoxEnabled65
        {
            get { return IsEnabled65; }

            set
            {
                IsEnabled65 = value;
                NotifyPropertyChanged("TextBoxEnabled65");
            }
        }
        public bool TextBoxEnabled66
        {
            get { return IsEnabled66; }

            set
            {
                IsEnabled66 = value;
                NotifyPropertyChanged("TextBoxEnabled66");
            }
        }
        public bool TextBoxEnabled67
        {
            get { return IsEnabled67; }

            set
            {
                IsEnabled67 = value;
                NotifyPropertyChanged("TextBoxEnabled67");
            }
        }
        public bool TextBoxEnabled68
        {
            get { return IsEnabled68; }

            set
            {
                IsEnabled68 = value;
                NotifyPropertyChanged("TextBoxEnabled68");
            }
        }
        public bool TextBoxEnabled70
        {
            get { return IsEnabled70; }
            set
            {
                IsEnabled70 = value;
                NotifyPropertyChanged("TextBoxEnabled70");
            }
        }
        public bool TextBoxEnabled71
        {
            get { return IsEnabled71; }

            set
            {
                IsEnabled71 = value;
                NotifyPropertyChanged("TextBoxEnabled71");
            }
        }
        public bool TextBoxEnabled72
        {
            get { return IsEnabled72; }
            set
            {
                IsEnabled72 = value;
                NotifyPropertyChanged("TextBoxEnabled72");
            }
        }
        public bool TextBoxEnabled73
        {
            get { return IsEnabled73; }
            set
            {
                IsEnabled73 = value;
                NotifyPropertyChanged("TextBoxEnabled73");
            }
        }
        public bool TextBoxEnabled74
        {
            get { return IsEnabled74; }

            set
            {
                IsEnabled74 = value;
                NotifyPropertyChanged("TextBoxEnabled74");
            }
        }
        public bool TextBoxEnabled75
        {
            get { return IsEnabled75; }

            set
            {
                IsEnabled75 = value;
                NotifyPropertyChanged("TextBoxEnabled75");
            }
        }
        public bool TextBoxEnabled76
        {
            get { return IsEnabled76; }

            set
            {
                IsEnabled76 = value;
                NotifyPropertyChanged("TextBoxEnabled76");
            }
        }
        public bool TextBoxEnabled77
        {
            get { return IsEnabled77; }

            set
            {
                IsEnabled77 = value;
                NotifyPropertyChanged("TextBoxEnabled77");
            }
        }
        public bool TextBoxEnabled78
        {
            get { return IsEnabled78; }

            set
            {
                IsEnabled78 = value;
                NotifyPropertyChanged("TextBoxEnabled78");
            }
        }

        public bool TextBoxEnabled80
        {
            get { return IsEnabled80; }
            set
            {
                IsEnabled80 = value;
                NotifyPropertyChanged("TextBoxEnabled80");
            }
        }
        public bool TextBoxEnabled81
        {
            get { return IsEnabled81; }

            set
            {
                IsEnabled81 = value;
                NotifyPropertyChanged("TextBoxEnabled81");
            }
        }
        public bool TextBoxEnabled82
        {
            get { return IsEnabled82; }
            set
            {
                IsEnabled82 = value;
                NotifyPropertyChanged("TextBoxEnabled82");
            }
        }
        public bool TextBoxEnabled83
        {
            get { return IsEnabled83; }
            set
            {
                IsEnabled83 = value;
                NotifyPropertyChanged("TextBoxEnabled83");
            }
        }
        public bool TextBoxEnabled84
        {
            get { return IsEnabled84; }

            set
            {
                IsEnabled84 = value;
                NotifyPropertyChanged("TextBoxEnabled84");
            }
        }
        public bool TextBoxEnabled85
        {
            get { return IsEnabled85; }

            set
            {
                IsEnabled85 = value;
                NotifyPropertyChanged("TextBoxEnabled85");
            }
        }
        public bool TextBoxEnabled86
        {
            get { return IsEnabled86; }

            set
            {
                IsEnabled86 = value;
                NotifyPropertyChanged("TextBoxEnabled86");
            }
        }
        public bool TextBoxEnabled87
        {
            get { return IsEnabled87; }

            set
            {
                IsEnabled87 = value;
                NotifyPropertyChanged("TextBoxEnabled87");
            }
        }
        public bool TextBoxEnabled88
        {
            get { return IsEnabled88; }

            set
            {
                IsEnabled88 = value;
                NotifyPropertyChanged("TextBoxEnabled88");
            }
        }
        #region Public Getters and Setters for the cell properties

        private bool getThisIsEnabledVal(int row, int col)
        {
            string isEnabledProp = "TextBoxEnabled" + row + col;

            // Get the Type object corresponding to Sudoku.
            Type myType = typeof(Sudoku);
            // Get the PropertyInfo object by passing the property name.
            PropertyInfo myIsEnableProp = myType.GetProperty(isEnabledProp);
            // Update the property name.
            var res = myIsEnableProp.GetValue(this, null);
            bool resBoolean = (bool)res;
            return resBoolean;
        }

        private void createPushTupple(int row, int col, string value)
        {
            bool isThisTextCellEnabled = getThisIsEnabledVal(row, col);
            if (!isThisTextCellEnabled && value != "")
            {
                Tuple<int, int> pos = new Tuple<int, int>(row, col);
                Tuple<Tuple<int, int>, string> insideTuple = new Tuple<Tuple<int, int>, string>(pos, value);

                string propertyName = "Last" + row + col;

                try
                {
                    // Get the Type object corresponding to Sudoku.
                    Type myType = typeof(Sudoku);
                    // Get the PropertyInfo object by passing the property name.
                    PropertyInfo myTextBoxInfoCellProp = myType.GetProperty(propertyName);
                    // Update the property name.
                    var res = myTextBoxInfoCellProp.GetValue(this, null);

                    List<string> currentStack = (List<string>)res;
                    currentStack.Add(value);
                    myTextBoxInfoCellProp.SetValue(this, currentStack);
                }
                catch (NullReferenceException e)
                {
                    MessageBox.Show("The property does not exist in Sudoku class." + e.Message);
                }

                Moves.Push(insideTuple);
            }
        }

        #endregion
        #region Get00       
        public string Get00
        {
            get { return get00; }
            set
            {
                if (String.IsNullOrEmpty(Get00) || Get00.Length > 0)
                {
                    get00 = "";
                }
                if (IsTextAllowed(value))
                {
                    get00 = value;

                    createPushTupple(0, 0, value);
                    Matrix[0, 0] = value;
                    OnPropertyChanged("Get00");
                }
            }
        }
        #endregion

        #region Get01
        public string Get01
        {
            get { return get01; }
            set
            {
                if (String.IsNullOrEmpty(Get01) || Get01.Length > 0)
                {
                    get01 = "";
                }
                if (IsTextAllowed(value))
                {
                    bool isThisTextCellEnabled = getThisIsEnabledVal(0, 1);
                    if (!isThisTextCellEnabled && value != "")
                    {
                        Tuple<int, int> pos = new Tuple<int, int>(0, 1);
                        Tuple<Tuple<int, int>, string> insideTuple = new Tuple<Tuple<int, int>, string>(pos, value);
                        Moves.Push(insideTuple);
                    }
                    Matrix[0, 1] = value;
                    get01 = value;
                    OnPropertyChanged("Get01");
                }
            }
        }
        #endregion

        #region Get02
        public string Get02
        {
            get { return get02; }
            set
            {
                if (String.IsNullOrEmpty(Get02) || Get02.Length > 0)
                {
                    get02 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(0, 2, value);
                    Matrix[0, 2] = value;
                    get02 = value;
                    OnPropertyChanged("Get02");
                }
            }
        }
        #endregion

        #region Get03
        public string Get03
        {
            get { return get03; }
            set
            {
                if (String.IsNullOrEmpty(Get03) || Get03.Length > 0)
                {
                    get03 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(0, 3, value);
                    get03 = value;
                    Matrix[0, 3] = value;
                    OnPropertyChanged("Get03");
                }
            }
        }

        #endregion

        #region Get04
        public string Get04
        {
            get { return get04; }
            set
            {
                if (String.IsNullOrEmpty(Get04) || Get04.Length > 0)
                {
                    get04 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(0, 4, value);
                    get04 = value;
                    Matrix[0, 4] = value;
                    OnPropertyChanged("Get04");
                }
            }
        }
        #endregion

        #region Get05
        public string Get05
        {
            get { return get05; }
            set
            {
                if (String.IsNullOrEmpty(Get05) || Get05.Length > 0)
                {
                    get05 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(0, 5, value);
                    get05 = value;
                    Matrix[0, 5] = value;
                    OnPropertyChanged("Get05");
                }
            }
        }
        #endregion

        #region Get06
        public string Get06
        {
            get { return get06; }
            set
            {
                if (String.IsNullOrEmpty(Get06) || Get06.Length > 0)
                {
                    get06 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(0, 6, value);
                    Matrix[0, 6] = value;
                    get06 = value;
                    OnPropertyChanged("Get06");
                }
            }
        }
        #endregion

        #region Get07
        public string Get07
        {
            get { return get07; }
            set
            {
                if (String.IsNullOrEmpty(Get07) || Get07.Length > 0)
                {
                    get07 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(0, 7, value);
                    get07 = value;
                    Matrix[0, 7] = value;
                    OnPropertyChanged("Get07");
                }
            }
        }
        #endregion

        #region Get08
        public string Get08
        {
            get { return get08; }
            set
            {
                if (String.IsNullOrEmpty(Get08) || Get08.Length > 0)
                {
                    get08 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(0, 8, value);
                    get08 = value;
                    Matrix[0, 8] = value;
                    OnPropertyChanged("Get08");
                }
            }
        }
        #endregion
        public string Get10
        {
            get { return get10; }
            set
            {
                if (String.IsNullOrEmpty(Get10) || Get10.Length > 0)
                {
                    get10 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(1, 0, value);
                    get10 = value;
                    Matrix[1, 0] = value;
                    OnPropertyChanged("Get10");
                }
            }
        }

        public string Get11
        {
            get { return get11; }
            set
            {
                if (String.IsNullOrEmpty(Get11) || Get11.Length > 0)
                {
                    get11 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(1, 1, value);
                    get11 = value;
                    Matrix[1, 1] = value;
                    OnPropertyChanged("Get11");
                }
            }
        }

        public string Get12
        {
            get { return get12; }
            set
            {
                if (String.IsNullOrEmpty(Get12) || Get12.Length > 0)
                {
                    get12 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(1, 2, value);
                    get12 = value;
                    Matrix[1, 2] = value;
                    OnPropertyChanged("Get12");
                }
            }
        }

        public string Get13
        {
            get { return get13; }
            set
            {
                if (String.IsNullOrEmpty(Get13) || Get13.Length > 0)
                {
                    get13 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(1, 3, value);
                    get13 = value;
                    Matrix[1, 3] = value;
                    OnPropertyChanged("Get13");
                }
            }
        }

        public string Get14
        {
            get { return get14; }
            set
            {
                if (String.IsNullOrEmpty(Get14) || Get14.Length > 0)
                {
                    get14 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(1, 4, value);
                    get14 = value;
                    Matrix[1, 4] = value;
                    OnPropertyChanged("Get14");
                }
            }
        }

        public string Get15
        {
            get { return get15; }
            set
            {
                if (String.IsNullOrEmpty(Get15) || Get15.Length > 0)
                {
                    get15 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(1, 5, value);
                    get15 = value;
                    Matrix[1, 5] = value;
                    OnPropertyChanged("Get15");
                }
            }
        }

        public string Get16
        {
            get { return get16; }
            set
            {
                if (String.IsNullOrEmpty(Get16) || Get16.Length > 0)
                {
                    get16 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(1, 6, value);
                    get16 = value;
                    Matrix[1, 6] = value;
                    OnPropertyChanged("Get16");
                }
            }
        }

        public string Get17
        {
            get { return get17; }
            set
            {
                if (String.IsNullOrEmpty(Get17) || Get17.Length > 0)
                {
                    get17 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(1, 7, value);
                    get17 = value;
                    Matrix[1, 7] = value;
                    OnPropertyChanged("Get17");
                }
            }
        }

        public string Get18
        {
            get { return get18; }
            set
            {
                if (String.IsNullOrEmpty(Get18) || Get18.Length > 0)
                {
                    get18 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(1, 8, value);
                    get18 = value;
                    Matrix[1, 8] = value;
                    OnPropertyChanged("Get18");
                }
            }
        }
        public string Get20
        {
            get { return get20; }
            set
            {
                if (String.IsNullOrEmpty(Get20) || Get20.Length > 0)
                {
                    get20 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(2, 0, value);
                    get20 = value;
                    Matrix[2, 0] = value;
                    OnPropertyChanged("Get20");
                }
            }
        }

        public string Get21
        {
            get { return get21; }
            set
            {
                if (String.IsNullOrEmpty(Get21) || Get21.Length > 0)
                {
                    get21 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(2, 1, value);
                    get21 = value;
                    Matrix[2, 1] = value;
                    OnPropertyChanged("Get21");
                }
            }
        }

        public string Get22
        {
            get { return get22; }
            set
            {
                if (String.IsNullOrEmpty(Get22) || Get22.Length > 0)
                {
                    get22 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(2, 2, value);
                    get22 = value;
                    Matrix[2, 2] = value;
                    OnPropertyChanged("Get22");
                }
            }
        }

        public string Get23
        {
            get { return get23; }
            set
            {
                if (String.IsNullOrEmpty(Get23) || Get23.Length > 0)
                {
                    get23 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(2, 3, value);
                    get23 = value;
                    Matrix[2, 3] = value;
                    OnPropertyChanged("Get23");
                }
            }
        }

        public string Get24
        {
            get { return get24; }
            set
            {
                if (String.IsNullOrEmpty(Get24) || Get24.Length > 0)
                {
                    get24 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(2, 4, value);
                    get24 = value;
                    Matrix[2, 4] = value;
                    OnPropertyChanged("Get24");
                }
            }
        }

        public string Get25
        {
            get { return get25; }
            set
            {
                if (String.IsNullOrEmpty(Get25) || Get25.Length > 0)
                {
                    get25 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(2, 5, value);
                    get25 = value;
                    Matrix[2, 5] = value;
                    OnPropertyChanged("Get25");
                }
            }
        }

        public string Get26
        {
            get { return get26; }
            set
            {
                if (String.IsNullOrEmpty(Get26) || Get26.Length > 0)
                {
                    get26 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(2, 6, value);
                    get26 = value;
                    Matrix[2, 6] = value;
                    OnPropertyChanged("Get26");
                }
            }
        }

        public string Get27
        {
            get { return get27; }
            set
            {
                if (String.IsNullOrEmpty(Get27) || Get27.Length > 0)
                {
                    get27 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(2, 7, value);
                    get27 = value;
                    Matrix[2, 7] = value;
                    OnPropertyChanged("Get27");
                }
            }
        }

        public string Get28
        {
            get { return get28; }
            set
            {
                if (String.IsNullOrEmpty(Get28) || Get28.Length > 0)
                {
                    get28 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(2, 8, value);
                    get28 = value;
                    Matrix[2, 8] = value;
                    OnPropertyChanged("Get28");
                }
            }
        }

        public string Get30
        {
            get { return get30; }
            set
            {
                if (String.IsNullOrEmpty(Get30) || Get30.Length > 0)
                {
                    get30 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(3, 0, value);
                    get30 = value;
                    Matrix[3, 0] = value;
                    OnPropertyChanged("Get30");
                }
            }
        }

        public string Get31
        {
            get { return get31; }
            set
            {
                if (String.IsNullOrEmpty(Get31) || Get31.Length > 0)
                {
                    get31 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(3, 1, value);
                    get31 = value;
                    Matrix[3, 1] = value;
                    OnPropertyChanged("Get31");
                }
            }
        }

        public string Get32
        {
            get { return get32; }
            set
            {
                if (String.IsNullOrEmpty(Get32) || Get32.Length > 0)
                {
                    get32 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(3, 2, value);
                    get32 = value;
                    Matrix[3, 2] = value;
                    OnPropertyChanged("Get32");
                }
            }
        }

        public string Get33
        {
            get { return get33; }
            set
            {
                if (String.IsNullOrEmpty(Get33) || Get33.Length > 0)
                {
                    get33 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(3, 3, value);
                    get33 = value;
                    Matrix[3, 3] = value;
                    OnPropertyChanged("Get33");
                }
            }
        }

        public string Get34
        {
            get { return get34; }
            set
            {
                if (String.IsNullOrEmpty(Get34) || Get34.Length > 0)
                {
                    get34 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(3, 4, value);
                    get34 = value;
                    Matrix[3, 4] = value;
                    OnPropertyChanged("Get34");
                }
            }
        }

        public string Get35
        {
            get { return get35; }
            set
            {
                if (String.IsNullOrEmpty(Get35) || Get35.Length > 0)
                {
                    get35 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(3, 5, value);
                    get35 = value;
                    Matrix[3, 5] = value;
                    OnPropertyChanged("Get35");
                }
            }
        }

        public string Get36
        {
            get { return get36; }
            set
            {
                if (String.IsNullOrEmpty(Get36) || Get36.Length > 0)
                {
                    get36 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(3, 6, value);
                    get36 = value;
                    Matrix[3, 6] = value;
                    OnPropertyChanged("Get36");
                }
            }
        }

        public string Get37
        {
            get { return get37; }
            set
            {
                if (String.IsNullOrEmpty(Get37) || Get37.Length > 0)
                {
                    get37 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(3, 7, value);
                    get37 = value;
                    Matrix[3, 7] = value;
                    OnPropertyChanged("Get37");
                }
            }
        }

        public string Get38
        {
            get { return get38; }
            set
            {
                if (String.IsNullOrEmpty(Get38) || Get38.Length > 0)
                {
                    get38 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(3, 8, value);
                    get38 = value;
                    Matrix[3, 8] = value;
                    OnPropertyChanged("Get38");
                }
            }
        }

        public string Get40
        {
            get { return get40; }
            set
            {
                if (String.IsNullOrEmpty(Get40) || Get40.Length > 0)
                {
                    get40 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(4, 0, value);
                    get40 = value;
                    Matrix[4, 0] = value;
                    OnPropertyChanged("Get40");
                }
            }
        }

        public string Get41
        {
            get { return get41; }
            set
            {
                if (String.IsNullOrEmpty(Get41) || Get41.Length > 0)
                {
                    get41 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(4, 1, value);
                    get41 = value;
                    Matrix[4, 1] = value;
                    OnPropertyChanged("Get41");
                }
            }
        }

        public string Get42
        {
            get { return get42; }
            set
            {
                if (String.IsNullOrEmpty(Get42) || Get42.Length > 0)
                {
                    get42 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(4, 2, value);
                    get42 = value;
                    Matrix[4, 2] = value;
                    OnPropertyChanged("Get42");
                }
            }
        }

        public string Get43
        {
            get { return get43; }
            set
            {
                if (String.IsNullOrEmpty(Get43) || Get43.Length > 0)
                {
                    get43 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(4, 3, value);
                    get43 = value;
                    Matrix[4, 3] = value;
                    OnPropertyChanged("Get43");
                }
            }
        }

        public string Get44
        {
            get { return get44; }
            set
            {
                if (String.IsNullOrEmpty(Get44) || Get44.Length > 0)
                {
                    get44 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(4, 4, value);
                    get44 = value;
                    Matrix[4, 4] = value;
                    OnPropertyChanged("Get44");
                }
            }
        }

        public string Get45
        {
            get { return get45; }
            set
            {
                if (String.IsNullOrEmpty(Get45) || Get45.Length > 0)
                {
                    get45 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(4, 5, value);
                    get45 = value;
                    Matrix[4, 5] = value;
                    OnPropertyChanged("Get45");
                }
            }
        }

        public string Get46
        {
            get { return get46; }
            set
            {
                if (String.IsNullOrEmpty(Get46) || Get46.Length > 0)
                {
                    get46 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(4, 6, value);
                    get46 = value;
                    Matrix[4, 6] = value;
                    OnPropertyChanged("Get46");
                }
            }
        }

        public string Get47
        {
            get { return get47; }
            set
            {
                if (String.IsNullOrEmpty(Get47) || Get47.Length > 0)
                {
                    get47 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(4, 7, value);
                    get47 = value;
                    Matrix[4, 7] = value;
                    OnPropertyChanged("Get47");
                }
            }
        }

        public string Get48
        {
            get { return get48; }
            set
            {
                if (String.IsNullOrEmpty(Get48) || Get48.Length > 0)
                {
                    get48 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(4, 8, value);
                    get48 = value;
                    Matrix[4, 8] = value;
                    OnPropertyChanged("Get48");
                }
            }
        }

        public string Get50
        {
            get { return get50; }
            set
            {
                if (String.IsNullOrEmpty(Get50) || Get50.Length > 0)
                {
                    get50 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(5, 0, value);
                    get50 = value;
                    Matrix[5, 0] = value;
                    OnPropertyChanged("Get50");
                }
            }
        }

        public string Get51
        {
            get { return get51; }
            set
            {
                if (String.IsNullOrEmpty(Get51) || Get51.Length > 0)
                {
                    get51 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(5, 1, value);
                    get51 = value;
                    Matrix[5, 1] = value;
                    OnPropertyChanged("Get51");
                }
            }
        }

        public string Get52
        {
            get { return get52; }
            set
            {
                if (String.IsNullOrEmpty(Get52) || Get52.Length > 0)
                {
                    get52 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(5, 2, value);
                    get52 = value;
                    Matrix[5, 2] = value;
                    OnPropertyChanged("Get52");
                }
            }
        }

        public string Get53
        {
            get { return get53; }
            set
            {
                if (String.IsNullOrEmpty(Get53) || Get53.Length > 0)
                {
                    get53 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(5, 3, value);
                    get53 = value;
                    Matrix[5, 3] = value;
                    OnPropertyChanged("Get53");
                }
            }
        }

        public string Get54
        {
            get { return get54; }
            set
            {
                if (String.IsNullOrEmpty(Get54) || Get54.Length > 0)
                {
                    get54 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(5, 4, value);
                    get54 = value;
                    Matrix[5, 4] = value;
                    OnPropertyChanged("Get54");
                }
            }
        }

        public string Get55
        {
            get { return get55; }
            set
            {
                if (String.IsNullOrEmpty(Get55) || Get55.Length > 0)
                {
                    get55 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(5, 5, value);
                    get55 = value;
                    Matrix[5, 5] = value;
                    OnPropertyChanged("Get55");
                }
            }
        }

        public string Get56
        {
            get { return get56; }
            set
            {
                if (String.IsNullOrEmpty(Get56) || Get56.Length > 0)
                {
                    get56 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(5, 6, value);
                    get56 = value;
                    Matrix[5, 6] = value;
                    OnPropertyChanged("Get56");
                }
            }
        }

        public string Get57
        {
            get { return get57; }
            set
            {
                if (String.IsNullOrEmpty(Get57) || Get57.Length > 0)
                {
                    get57 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(5, 7, value);
                    get57 = value;
                    Matrix[5, 7] = value;
                    OnPropertyChanged("Get57");
                }
            }
        }

        public string Get58
        {
            get { return get58; }
            set
            {
                if (String.IsNullOrEmpty(Get58) || Get58.Length > 0)
                {
                    get58 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(5, 8, value);
                    get58 = value;
                    Matrix[5, 8] = value;
                    OnPropertyChanged("Get58");
                }
            }
        }

        public string Get60
        {
            get { return get60; }
            set
            {
                if (String.IsNullOrEmpty(Get60) || Get60.Length > 0)
                {
                    get60 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(6, 0, value);
                    get60 = value;
                    Matrix[6, 0] = value;
                    OnPropertyChanged("Get60");
                }
            }
        }

        public string Get61
        {
            get { return get61; }
            set
            {
                if (String.IsNullOrEmpty(Get61) || Get61.Length > 0)
                {
                    get61 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(6, 1, value);
                    get61 = value;
                    Matrix[6, 1] = value;
                    OnPropertyChanged("Get61");
                }
            }
        }

        public string Get62
        {
            get { return get62; }
            set
            {
                if (String.IsNullOrEmpty(Get62) || Get62.Length > 0)
                {
                    get62 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(6, 2, value);
                    get62 = value;
                    Matrix[6, 2] = value;
                    OnPropertyChanged("Get62");
                }
            }
        }

        public string Get63
        {
            get { return get63; }
            set
            {
                if (String.IsNullOrEmpty(Get63) || Get63.Length > 0)
                {
                    get63 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(6, 3, value);
                    get63 = value;
                    Matrix[6, 3] = value;
                    OnPropertyChanged("Get63");
                }
            }
        }

        public string Get64
        {
            get { return get64; }
            set
            {
                if (String.IsNullOrEmpty(Get64) || Get64.Length > 0)
                {
                    get64 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(6, 4, value);
                    get64 = value;
                    Matrix[6, 4] = value;
                    OnPropertyChanged("Get64");
                }
            }
        }

        public string Get65
        {
            get { return get65; }
            set
            {
                if (String.IsNullOrEmpty(Get65) || Get65.Length > 0)
                {
                    get65 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(6, 5, value);
                    get65 = value;
                    Matrix[6, 5] = value;
                    OnPropertyChanged("Get65");
                }
            }
        }

        public string Get66
        {
            get { return get66; }
            set
            {
                if (String.IsNullOrEmpty(Get66) || Get66.Length > 0)
                {
                    get66 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(6, 6, value);
                    get66 = value;
                    Matrix[6, 6] = value;
                    OnPropertyChanged("Get66");
                }
            }
        }

        public string Get67
        {
            get { return get67; }
            set
            {
                if (String.IsNullOrEmpty(Get67) || Get67.Length > 0)
                {
                    get67 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(6, 7, value);
                    get67 = value;
                    Matrix[6, 7] = value;
                    OnPropertyChanged("Get67");
                }
            }
        }

        public string Get68
        {
            get { return get68; }
            set
            {
                if (String.IsNullOrEmpty(Get68) || Get68.Length > 0)
                {
                    get68 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(6, 8, value);
                    get68 = value;
                    Matrix[6, 8] = value;
                    OnPropertyChanged("Get68");
                }
            }
        }

        public string Get70
        {
            get { return get70; }
            set
            {
                if (String.IsNullOrEmpty(Get70) || Get70.Length > 0)
                {
                    get70 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(7, 0, value);
                    get70 = value;
                    Matrix[7, 0] = value;
                    OnPropertyChanged("Get70");
                }
            }
        }

        public string Get71
        {
            get { return get71; }
            set
            {
                if (String.IsNullOrEmpty(Get71) || Get71.Length > 0)
                {
                    get71 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(7, 1, value);
                    get71 = value;
                    Matrix[7, 1] = value;
                    OnPropertyChanged("Get71");
                }
            }
        }

        public string Get72
        {
            get { return get72; }
            set
            {
                if (String.IsNullOrEmpty(Get72) || Get72.Length > 0)
                {
                    get72 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(7, 2, value);
                    get72 = value;
                    Matrix[7, 2] = value;
                    OnPropertyChanged("Get72");
                }
            }
        }

        public string Get73
        {
            get { return get73; }
            set
            {
                if (String.IsNullOrEmpty(Get73) || Get73.Length > 0)
                {
                    get73 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(7, 3, value);
                    get73 = value;
                    Matrix[7, 3] = value;
                    OnPropertyChanged("Get73");
                }
            }
        }

        public string Get74
        {
            get { return get74; }
            set
            {
                if (String.IsNullOrEmpty(Get74) || Get74.Length > 0)
                {
                    get74 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(7, 4, value);
                    get74 = value;
                    Matrix[7, 4] = value;
                    OnPropertyChanged("Get74");
                }
            }
        }

        public string Get75
        {
            get { return get75; }
            set
            {
                if (String.IsNullOrEmpty(Get75) || Get75.Length > 0)
                {
                    get75 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(7, 5, value);
                    get75 = value;
                    Matrix[7, 5] = value;
                    OnPropertyChanged("Get75");
                }
            }
        }

        public string Get76
        {
            get { return get76; }
            set
            {
                if (String.IsNullOrEmpty(Get76) || Get76.Length > 0)
                {
                    get76 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(7, 6, value);
                    get76 = value;
                    Matrix[7, 6] = value;
                    OnPropertyChanged("Get76");
                }
            }
        }

        public string Get77
        {
            get { return get77; }
            set
            {
                if (String.IsNullOrEmpty(Get77) || Get77.Length > 0)
                {
                    get77 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(7, 7, value);
                    get77 = value;
                    Matrix[7, 7] = value;
                    OnPropertyChanged("Get77");
                }
            }
        }

        public string Get78
        {
            get { return get78; }
            set
            {
                if (String.IsNullOrEmpty(Get78) || Get78.Length > 0)
                {
                    get78 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(7, 8, value);
                    get78 = value;
                    Matrix[7, 8] = value;
                    OnPropertyChanged("Get78");
                }
            }
        }

        public string Get80
        {
            get { return get80; }
            set
            {
                if (String.IsNullOrEmpty(Get80) || Get80.Length > 0)
                {
                    get80 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(8, 0, value);
                    get80 = value;
                    Matrix[8, 0] = value;
                    OnPropertyChanged("Get80");
                }
            }
        }

        public string Get81
        {
            get { return get81; }
            set
            {
                if (String.IsNullOrEmpty(Get81) || Get81.Length > 0)
                {
                    get81 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(8, 1, value);
                    get81 = value;
                    Matrix[8, 1] = value;
                    OnPropertyChanged("Get81");
                }
            }
        }

        public string Get82
        {
            get { return get82; }
            set
            {
                if (String.IsNullOrEmpty(Get82) || Get82.Length > 0)
                {
                    get82 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(8, 2, value);
                    get82 = value;
                    Matrix[8, 2] = value;
                    OnPropertyChanged("Get82");
                }
            }
        }

        public string Get83
        {
            get { return get83; }
            set
            {
                if (String.IsNullOrEmpty(Get83) || Get83.Length > 0)
                {
                    get83 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(8, 3, value);
                    get83 = value;
                    Matrix[8, 3] = value;
                    OnPropertyChanged("Get83");
                }
            }
        }

        public string Get84
        {
            get { return get84; }
            set
            {
                if (String.IsNullOrEmpty(Get84) || Get84.Length > 0)
                {
                    get84 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(8, 4, value);
                    get84 = value;
                    Matrix[8, 4] = value;
                    OnPropertyChanged("Get84");
                }
            }
        }

        public string Get85
        {
            get { return get85; }
            set
            {
                if (String.IsNullOrEmpty(Get85) || Get85.Length > 0)
                {
                    get85 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(8, 5, value);
                    get85 = value;
                    Matrix[8, 5] = value;
                    OnPropertyChanged("Get85");
                }
            }
        }

        public string Get86
        {
            get { return get86; }
            set
            {
                if (String.IsNullOrEmpty(Get86) || Get86.Length > 0)
                {
                    get86 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(8, 6, value);
                    get86 = value;
                    Matrix[8, 6] = value;
                    OnPropertyChanged("Get86");
                }
            }
        }

        public string Get87
        {
            get { return get87; }
            set
            {
                if (String.IsNullOrEmpty(Get87) || Get87.Length > 0)
                {
                    get87 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(8, 7, value);
                    get87 = value;
                    Matrix[8, 7] = value;
                    OnPropertyChanged("Get87");
                }
            }
        }
        #endregion

        public string Get88
        {
            get { return get88; }
            set
            {
                if (String.IsNullOrEmpty(Get88) || Get88.Length > 0)
                {
                    get88 = "";
                }
                if (IsTextAllowed(value))
                {
                    createPushTupple(8, 8, value);
                    get88 = value;
                    Matrix[8, 8] = value;
                    OnPropertyChanged("Get88");
                }
            }
        }

        public string IsVisiblePausedButton
        {
            get { return isVisiblePausedButton; }
            set
            {
                isVisiblePausedButton = value;
                OnPropertyChanged("IsVisiblePausedButton");
            }
        }
        public string IsVisibleResumeButton
        {
            get { return isVisibleResumeButton; }
            set
            {
                isVisibleResumeButton = value;
                OnPropertyChanged("IsVisibleResumeButton");
            }
        }



        public string IsVisibleTopLeftRectangle
        {
            get { return isVisibleTopLeftRectangle; }
            set
            {
                isVisibleTopLeftRectangle = value;
                OnPropertyChanged("IsVisibleTopLeftRectangle");
            }
        }

        public string IsVisibleToMiddleRectangle
        {
            get { return isVisibleToMiddleRectangle; }
            set
            {
                isVisibleToMiddleRectangle = value;
                OnPropertyChanged("IsVisibleToMiddleRectangle");
            }
        }

        public string IsVisibleTopRightRectangle
        {
            get { return isVisibleTopRightRectangle; }
            set
            {
                isVisibleTopRightRectangle = value;
                OnPropertyChanged("IsVisibleTopRightRectangle");
            }
        }

        public string IsVisibleMiddleLeftRectangle
        {
            get { return isVisibleMiddleLeftRectangle; }
            set
            {
                isVisibleMiddleLeftRectangle = value;
                OnPropertyChanged("IsVisibleMiddleLeftRectangle");
            }
        }

        public string IsVisibleMiddleMiddleRectangle
        {
            get { return isVisibleMiddleMiddleRectangle; }
            set
            {
                isVisibleMiddleMiddleRectangle = value;
                OnPropertyChanged("IsVisibleMiddleMiddleRectangle");
            }
        }

        public string IsVisibleMiddleRightRectangle
        {
            get { return isVisibleMiddleRightRectangle; }
            set
            {
                isVisibleMiddleRightRectangle = value;
                OnPropertyChanged("IsVisibleMiddleRightRectangle");
            }
        }

        public string IsVisibleBottomLeftRectangle
        {
            get { return isVisibleBottomLeftRectangle; }
            set
            {
                isVisibleBottomLeftRectangle = value;
                OnPropertyChanged("IsVisibleBottomLeftRectangle");
            }
        }

        public string IsVisibleBottomMiddleRectangle
        {
            get { return isVisibleBottomMiddleRectangle; }
            set
            {
                isVisibleBottomMiddleRectangle = value;
                OnPropertyChanged("IsVisibleBottomMiddleRectangle");
            }
        }

        public string IsVisibleBottomRightRectangle
        {
            get { return isVisibleBottomRightRectangle; }
            set
            {
                isVisibleBottomRightRectangle = value;
                OnPropertyChanged("IsVisibleBottomRightRectangle");
            }
        }

        public Sudoku()
        {

        }

        public static Sudoku GetInstance(MainWindow window)
        {
            if (_instance == null)                          // Is the instance variable null?
            {
                if (_instance == null)                  // Check again if the instance variable is null
                {
                    _instance = new Sudoku();   // It is.  So instantiate it
                    _instance.InitSudoku(window);        // Initialize it
                }

            }
            return _instance;                               // Return a pointer to the instance
        }

        /// <summary>
        /// Process the cell click event.
        /// </summary>
        internal void CellClicked(int row, int col)
        {

            ProcessNumberPad(row, col, _view.ShowNumberPad());  // Yes, display the number pad and process it
        }

        private void ProcessNumberPad(int row, int col, string value)
        {
            switch (value)
            {
                case "1":                                           // Selected 1
                case "2":                                           // Selected 2
                case "3":                                           // Selected 3
                case "4":                                           // Selected 4
                case "5":                                           // Selected 5
                case "6":                                           // Selected 6
                case "7":                                           // Selected 7
                case "8":                                           // Selected 8
                case "9": ProcessAnswer(row, col, value); break;    // Selected 9
                case "0": ProccessClearCell(row, col); break;        // Selected Clear
            }
        }

        private void ProccessClearCell(int row, int col)
        {
            string value = "";
            matrix[row, row] = value;    // Save user's answer
            string propertyName = "Get" + row + col;

            try
            {
                // Get the Type object corresponding to Sudoku.
                Type myType = typeof(Sudoku);
                // Get the PropertyInfo object by passing the property name.
                PropertyInfo myTextBoxInfoCellProp = myType.GetProperty(propertyName);
                // Update the property name.
                myTextBoxInfoCellProp.SetValue(this, value);
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("The property does not exist in Sudoku class." + e.Message);
            }
        }

        private void ProcessAnswer(int row, int col, string value)
        {
            matrix[row, row] = value;                                // Save user's answer
            string propertyName = "Get" + row + col;

            try
            {
                // Get the Type object corresponding to Sudoku.
                Type myType = typeof(Sudoku);
                // Get the PropertyInfo object by passing the property name.
                PropertyInfo myTextBoxInfoCellProp = myType.GetProperty(propertyName);
                // Update the property name.
                myTextBoxInfoCellProp.SetValue(this, value);
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("The property does not exist in Sudoku class." + e.Message);
            }
        }

        private void InitSudoku(MainWindow window)
        {
            this._view = window;
            hideGrid();
            _timer = new TimerClass();                               // Instantiate a new timer class
            _timer.GameTimerEvent += GameTimerEventHandler;         // Set the timer event handler
            GameInProgress = false;
        }

        private void GameTimerEventHandler(object sender, GameTimerEventArgs e)
        {
            ElapsedTime = e.ElapsedTime;                    // Save the elapsed time string from the timer class
        }

        int convertDificultyStringInInt(string dificulty)
        {
            int result = 0;
            switch (dificulty)
            {
                case "Very Easy": result = 1; break;
                case "Easy": result = 2; break;
                case "Medium": result = 3; break;
                case "Hard": result = 4; break;
                case "Expert": result = 5; break;
            }

            return result;
        }

        int getBlankedCellsNum(string dificulty)
        {
            int returnedNumber = convertDificultyStringInInt(dificulty);
            int result = 0;
            switch (returnedNumber)
            {
                case 1: result = 24; break;
                case 2: result = 35; break;
                case 3: result = 40; break;
                case 4: result = 45; break;
                case 5: result = 50; break;
            }

            return result;
        }

        private void clearAllCells()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    string propertyName = "Get" + row + col;

                    try
                    {
                        // Get the Type object corresponding to Sudoku.
                        Type myType = typeof(Sudoku);
                        // Get the PropertyInfo object by passing the property name.
                        PropertyInfo myTextBoxInfoCellProp = myType.GetProperty(propertyName);
                        // Update the property name.
                        myTextBoxInfoCellProp.SetValue(this, "");

                    }
                    catch (NullReferenceException e)
                    {
                        MessageBox.Show("The property does not exist in Sudoku class." + e.Message);
                    }
                }
            }
        }

        public void PauseGame()
        {
            hideGrid();
            _timer.PauseTimer();
            IsVisiblePausedButton = "Hidden";
            IsVisibleResumeButton = "Visible";
            IsEnabledCheckedButton = false;
            IsEnabledResetButton = false;
            // Pause the timer
            //EnableGameControls(false, false);                       // Disable the game controls and hide the grid
        }

        public void ResumeGame()
        {
            showGrid();
            _timer.ReсsumeTimer();
            IsVisibleResumeButton = "Hidden";
            IsVisiblePausedButton = "Visible";
            IsEnabledCheckedButton = true;
            IsEnabledResetButton = true;
        }

        public void ResetGame()
        {
            clearAllCells();
            _timer.ResetTimer();                                // Reset the timer
            IsEnabledCheckedButton = true;

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    string currentElement = StartingMatrix[row, col];
                    if (currentElement == "0")
                    {
                        //Get the name of the isEnabled with the row and col possition
                        string isEnabledProp = "TextBoxEnabled" + row + col;

                        // Get the Type object corresponding to Sudoku.
                        Type myType = typeof(Sudoku);
                        // Get the PropertyInfo object by passing the property name.
                        PropertyInfo myIsEnableProp = myType.GetProperty(isEnabledProp);
                        // Update the property name.
                        myIsEnableProp.SetValue(this, false);
                    }
                    else
                    {
                        string propertyName = "Get" + row + col;

                        //Matrix[row, col] = currentElement;

                        try
                        {
                            // Get the Type object corresponding to Sudoku.
                            Type myType = typeof(Sudoku);
                            // Get the PropertyInfo object by passing the property name.
                            PropertyInfo myTextBoxInfoCellProp = myType.GetProperty(propertyName);
                            // Update the property name.
                            myTextBoxInfoCellProp.SetValue(this, currentElement);
                        }
                        catch (NullReferenceException e)
                        {
                            MessageBox.Show("The property does not exist in Sudoku class." + e.Message);
                        }

                        string sds = "asdasd";
                        /*PropertyInfo pinfo = typeof(YourType).GetProperty("YourProperty");
                        object value = pinfo.GetValue(YourInstantiatedObject, null);*/
                    }
                }
            }
        }

        private void buildSudukuByMatrix()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    string currentElement = Matrix[row, col];
                    if (currentElement == "0")
                    {
                        //Get the name of the isEnabled with the row and col possition
                        string isEnabledProp = "TextBoxEnabled" + row + col;

                        // Get the Type object corresponding to Sudoku.
                        Type myType = typeof(Sudoku);
                        // Get the PropertyInfo object by passing the property name.
                        PropertyInfo myIsEnableProp = myType.GetProperty(isEnabledProp);
                        // Update the property name.
                        myIsEnableProp.SetValue(this, false);


                    }
                    else
                    {
                        string propertyName = "Get" + row + col;

                        Matrix[row, col] = currentElement;

                        try
                        {
                            // Get the Type object corresponding to Sudoku.
                            Type myType = typeof(Sudoku);
                            // Get the PropertyInfo object by passing the property name.
                            PropertyInfo myTextBoxInfoCellProp = myType.GetProperty(propertyName);
                            // Update the property name.
                            if (currentElement == "-2")
                                myTextBoxInfoCellProp.SetValue(this, "");
                            else
                                myTextBoxInfoCellProp.SetValue(this, currentElement);
                        }
                        catch (NullReferenceException e)
                        {
                            MessageBox.Show("The property does not exist in Sudoku class." + e.Message);
                        }

                        string sds = "asdasd";
                        /*PropertyInfo pinfo = typeof(YourType).GetProperty("YourProperty");
                        object value = pinfo.GetValue(YourInstantiatedObject, null);*/
                    }
                }
            }


            MovesRedo = MovesRedoCopy;
            Moves = new Stack<Tuple<Tuple<int, int>, string>>(movesCopy);
            MovesCopy = null;
            MovesRedoCopy = null;
        }

        public void UndoClicked()
        {
            if (Moves.Count == 0)
            {
                MessageBox.Show("There no undo!");
            }
            else
            {
                var lastMove = Moves.Pop();

                var tupLast = lastMove.Item1;
                int rowLast = tupLast.Item1;
                int colLast = tupLast.Item2;

                if (Moves.Count == 0)
                {
                    MovesRedo.Push(lastMove);
                    Matrix[rowLast, colLast] = "-2";
                }
                else
                {
                    var beforeLastEl = Moves.Pop();

                    var tupBeforeLast = beforeLastEl.Item1;
                    int rowBeforeLast = tupBeforeLast.Item1;
                    int colBeforeLast = tupBeforeLast.Item2;
                    string valBeforeLast = beforeLastEl.Item2;


                    string propertyName = "Last" + rowLast + colLast;
                    var currStack = new List<string>();

                    try
                    {
                        // Get the Type object corresponding to Sudoku.
                        Type myType = typeof(Sudoku);
                        // Get the PropertyInfo object by passing the property name.
                        PropertyInfo myTextBoxInfoCellProp = myType.GetProperty(propertyName);
                        // Update the property name.
                        var stack = myTextBoxInfoCellProp.GetValue(this, null);

                        currStack = (List<string>)stack;

                    }
                    catch (NullReferenceException e)
                    {
                        MessageBox.Show("The property does not exist in Sudoku class." + e.Message);
                    }

                    if (currStack.Count > 0)
                    {
                        currStack = currStack.Distinct().ToList();

                        string currSwap = currStack[currStack.Count - 1];
                        string firstEl = currStack[0];

                        Tuple<int, int> posTup = new Tuple<int, int>(rowLast, colLast);
                        Tuple<Tuple<int, int>, string> inTup = new Tuple<Tuple<int, int>, string>(posTup, currSwap);

                        MovesRedo.Push(inTup);
                        Moves.Push(beforeLastEl);
                        currStack.RemoveAt(currStack.Count - 1);

                        if (currStack.Count == 0)
                        {
                            Matrix[rowLast, colLast] = "-2";
                        }
                        else
                        {
                            string lastVersionOfTheCell = currStack[currStack.Count - 1];
                            Tuple<int, int> rowsCols01 = new Tuple<int, int>(rowLast, colLast);
                            Tuple<Tuple<int, int>, string> ds1 = new Tuple<Tuple<int, int>, string>(rowsCols01, lastVersionOfTheCell);

                            if (!Moves.Contains(ds1))
                            {
                                Matrix[rowLast, colLast] = "-2";
                                MovesRedo.Pop();
                                inTup = new Tuple<Tuple<int, int>, string>(posTup, firstEl);
                                MovesRedo.Push(inTup);
                            }
                            else
                                Matrix[rowLast, colLast] = lastVersionOfTheCell;
                        }
                    }
                    else
                    {
                        //string lastVersionOfTheCell = currStack[currStack.Count - 1];
                        Tuple<int, int> rowsCols01 = new Tuple<int, int>(rowLast, colLast);
                        Tuple<Tuple<int, int>, string> ds1 = new Tuple<Tuple<int, int>, string>(rowsCols01, Matrix[rowLast, colLast]);

                        MovesRedo.Push(ds1);
                        Matrix[rowLast, colLast] = "-2";
                    }


                }
            }

            MovesCopy = new Stack<Tuple<Tuple<int, int>, string>>(Moves);
            MovesRedoCopy = MovesRedo;
            MovesNumber = Moves.Count;
            buildSudukuByMatrix();
        }

        public void RedoClicked()
        {
            if (MovesRedo.Count == 0)
            {
                MessageBox.Show("There no redo!");
            }
            else
            {
                var lastMoveRedo = movesRedo.Pop();

                var tupLast = lastMoveRedo.Item1;
                int rowLast = tupLast.Item1;
                int colLast = tupLast.Item2;
                string tupVal = lastMoveRedo.Item2;

                Tuple<int, int> posThis = new Tuple<int, int>(rowLast, colLast);
                Tuple<Tuple<int, int>, string> outTup = new Tuple<Tuple<int, int>, string>(posThis, tupVal);

                Matrix[rowLast, colLast] = tupVal;

                Moves.Push(lastMoveRedo);

                MovesCopy = new Stack<Tuple<Tuple<int, int>, string>>(Moves);
                MovesRedoCopy = MovesRedo ;
                
                buildSudukuByMatrix();
            }
        }

        public void startNewGame(string dificulty)
        {
            if (GameInProgress)
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure you want stop a active game and start a new one?", "Start New Game", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    newGame(dificulty);
                    IsEnabledPausedButton = true;
                    IsEnabledResetButton = true;
                    IsEnabledCheckedButton = true;
                }

            }
            else
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure you want to start a new game?", "Start New Game", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    newGame(dificulty);
                    IsEnabledPausedButton = true;
                    IsEnabledResetButton = true;
                    IsEnabledCheckedButton = true;
                }
            }
        }

        private void showGrid()
        {
            IsVisibleTopLeftRectangle = "Visible";
            IsVisibleToMiddleRectangle = "Visible";
            IsVisibleTopRightRectangle = "Visible";
            IsVisibleMiddleLeftRectangle = "Visible";
            IsVisibleMiddleMiddleRectangle = "Visible";
            IsVisibleMiddleRightRectangle = "Visible";
            IsVisibleBottomLeftRectangle = "Visible";
            IsVisibleBottomMiddleRectangle = "Visible";
            IsVisibleBottomRightRectangle = "Visible";
        }

        private void hideGrid()
        {
            IsVisibleTopLeftRectangle = "Hidden";
            IsVisibleToMiddleRectangle = "Hidden";
            IsVisibleTopRightRectangle = "Hidden";
            IsVisibleMiddleLeftRectangle = "Hidden";
            IsVisibleMiddleMiddleRectangle = "Hidden";
            IsVisibleMiddleRightRectangle = "Hidden";
            IsVisibleBottomLeftRectangle = "Hidden";
            IsVisibleBottomMiddleRectangle = "Hidden";
            IsVisibleBottomRightRectangle = "Hidden";
        }

        public void CheckResult()
        {
            bool isFinished = false;
            int numberOfRightAnswers = 0;
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (Matrix[row, col] == SolvedMatrix[row, col])
                    {
                        numberOfRightAnswers++;
                    }
                }
            }

            if (numberOfRightAnswers == 81)                  //The Puzzle is solved correctly
            {
                GameTimeElapsed = _timer.ElapsedTime;               // Save the elapsed time
                _timer.StopTimer();
                IsEnabledPausedButton = false;
                IsEnabledResetButton = false;
                IsEnabledCheckedButton = false;
                _view.ShowGameCompletedDialog();
            }
        }

        public void newGame(string dificulty)
        {
            showGrid();
            // Clear all the cells
            Moves.Clear();
            clearAllCells();

            GameInProgress = true;
            _timer.StartTimer();
            // Getting the number of blank spaces, depanding of the difficulty of the game
            int blankCells = this.getBlankedCellsNum(dificulty);

            // Creating new instance of the game, using the algoritm for creation of puzzles
            NewGamePuzzle newGamePuzzle = new NewGamePuzzle(9, blankCells);
            // Filling a matrix with the new created sudoku
            newGamePuzzle.fillValues();

            Matrix = newGamePuzzle.Mat;

            /* Matrix = new string[9,9] { { "8", "7", "1", "2", "4", "3", "6", "5", "9" },
                                                           { "4", "3", "6", "7", "5", "9", "2", "8", "1" },
                                                           { "2", "9", "5", "6", "1", "8", "3", "4", "7" },
                                                           { "1", "2", "3", "5", "9", "7", "8", "6", "4" },
                                                           { "9", "8", "4", "1", "3", "6", "7", "2", "5" },
                                                           { "5", "6", "7", "8", "2", "4", "1", "9", "3" },
                                                           { "3", "1", "2", "9", "8", "5", "4", "7", "6" },
                                                           { "6", "5", "8", "4", "7", "1", "9", "3", "2" },
                                                           { "7", "4", "9", "3", "6", "2", "5", "1", "8" } };*/

            StartingMatrix = Matrix;
            SolvedMatrix = newGamePuzzle.SolvedMatrix;

            /*SolvedMatrix = new string[9, 9]{ { "8", "7", "1", "2", "4", "3", "6", "5", "9" },
                                                          { "4", "3", "6", "7", "5", "9", "2", "8", "1" },
                                                          { "2", "9", "5", "6", "1", "8", "3", "4", "7" },
                                                          { "1", "2", "3", "5", "9", "7", "8", "6", "4" },
                                                          { "9", "8", "4", "1", "3", "6", "7", "2", "5" },
                                                          { "5", "6", "7", "8", "2", "4", "1", "9", "3" },
                                                          { "3", "1", "2", "9", "8", "5", "4", "7", "6" },
                                                          { "6", "5", "8", "4", "7", "1", "9", "3", "2" },
                                                          { "7", "4", "9", "3", "6", "2", "5", "1", "8" } };
*/

            string result = "";

            for (int i = 0; i < 9; i++)
            {
                result += "{ ";
                for (int j = 0; j < 9; j++)
                {
                    if (j == 9 - 1)
                    {
                        if (SolvedMatrix[i, j] == "0")
                            result += $"\'.\'";
                        else
                            result += $"\'{SolvedMatrix[i, j]}\'";
                    }
                    else
                    {
                        if (SolvedMatrix[i, j] == "0")
                            result += $"\'.\', ";
                        else
                            result += $"\'{SolvedMatrix[i, j]}\'," + " ";
                    }
                }
                result += " }";
                result += "\n";
            }
            result += "\n";

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    string currentElement = newGamePuzzle.Mat[row, col];
                    if (currentElement == "0")
                    {
                        //Get the name of the isEnabled with the row and col possition
                        string isEnabledProp = "TextBoxEnabled" + row + col;

                        // Get the Type object corresponding to Sudoku.
                        Type myType = typeof(Sudoku);
                        // Get the PropertyInfo object by passing the property name.
                        PropertyInfo myIsEnableProp = myType.GetProperty(isEnabledProp);
                        // Update the property name.
                        myIsEnableProp.SetValue(this, false);
                    }
                    else
                    {
                        string propertyName = "Get" + row + col;

                        Matrix[row, col] = currentElement;

                        try
                        {
                            // Get the Type object corresponding to Sudoku.
                            Type myType = typeof(Sudoku);
                            // Get the PropertyInfo object by passing the property name.
                            PropertyInfo myTextBoxInfoCellProp = myType.GetProperty(propertyName);
                            // Update the property name.
                            myTextBoxInfoCellProp.SetValue(this, currentElement);
                        }
                        catch (NullReferenceException e)
                        {
                            MessageBox.Show("The property does not exist in Sudoku class." + e.Message);
                        }

                        string sds = "asdasd";
                        /*PropertyInfo pinfo = typeof(YourType).GetProperty("YourProperty");
                        object value = pinfo.GetValue(YourInstantiatedObject, null);*/
                    }
                }
            }

        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
