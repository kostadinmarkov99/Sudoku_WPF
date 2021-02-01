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
        private string[,] matrix;
        private MainWindow _view;
        private static Sudoku _instance;

        public event PropertyChangedEventHandler PropertyChanged;

        public string[,] Matrix
        {
            get { return matrix; }
            set
            {
                matrix = value;
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
                NotifyPropertyChanged("TextBoxEnabled14");
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

        #region Get00       
        public string Get00
        {
            get { return get00; }
            set
            {
                if(String.IsNullOrEmpty(Get00) || Get00.Length > 0 )
                {
                    get00 = "";
                }
                if (IsTextAllowed(value))
                {
                    get00 = value;
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
                    get03 = value;
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
                    get04 = value;
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
                    get05 = value;
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
                    get07 = value;
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
                    get08 = value;
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
                    get10 = value;
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
                    get11 = value;
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
                    get12 = value;
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
                    get13 = value;
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
                    get14 = value;
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
                    get15 = value;
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
                    get16 = value;
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
                    get17 = value;
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
                    get18 = value;
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
                    get20 = value;
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
                    get21 = value;
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
                    get22 = value;
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
                    get23 = value;
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
                    get24 = value;
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
                    get25 = value;
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
                    get26 = value;
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
                    get27 = value;
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
                    get28 = value;
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
                    get30 = value;
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
                    get31 = value;
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
                    get32 = value;
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
                    get33 = value;
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
                    get34 = value;
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
                    get35 = value;
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
                    get36 = value;
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
                    get37 = value;
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
                    get38 = value;
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
                    get40 = value;
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
                    get41 = value;
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
                    get42 = value;
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
                    get43 = value;
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
                    get44 = value;
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
                    get45 = value;
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
                    get46 = value;
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
                    get47 = value;
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
                    get48 = value;
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
                    get50 = value;
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
                    get51 = value;
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
                    get52 = value;
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
                    get53 = value;
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
                    get54 = value;
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
                    get55 = value;
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
                    get56 = value;
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
                    get57 = value;
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
                    get58 = value;
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
                    get60 = value;
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
                    get61 = value;
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
                    get62 = value;
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
                    get63 = value;
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
                    get64 = value;
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
                    get65 = value;
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
                    get66 = value;
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
                    get67 = value;
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
                    get68 = value;
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
                    get70 = value;
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
                    get71 = value;
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
                    get72 = value;
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
                    get73 = value;
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
                    get74 = value;
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
                    get75 = value;
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
                    get76 = value;
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
                    get77 = value;
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
                    get78 = value;
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
                    get80 = value;
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
                    get81 = value;
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
                    get82 = value;
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
                    get83 = value;
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
                    get84 = value;
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
                    get85 = value;
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
                    get86 = value;
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
                    get87 = value;
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
                    get88 = value;
                    OnPropertyChanged("Get88");
                }
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
                case "0": ProccessClearCell(row, col);break;        // Selected Clear
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
                case 1: result = 40; break;
                case 2: result = 43; break;
                case 3: result = 45; break;
                case 4: result = 47; break;
                case 5: result = 49; break;
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

        public void newGame(string dificulty)
        {
            // Clear all the cells
            clearAllCells();

            // Getting the number of blank spaces, depanding of the difficulty of the game
            int blankCells = this.getBlankedCellsNum(dificulty);

            // Creating new instance of the game, using the algoritm for creation of puzzles
            NewGamePuzzle newGamePuzzle = new NewGamePuzzle(9, blankCells);
            // Filling a matrix with the new created sudoku
            newGamePuzzle.fillValues();

            Matrix = newGamePuzzle.Mat;

            /*string[,] newGamePuzzle = new string[9, 9]{ { "0", "2", "5", "0", "0", "4", "7", "0", "9" },
                                                        { "0", "7", "0", "0", "0", "9", "3", "0", "6" },
                                                        { "0", "0", "0", "3", "8", "0", "0", "0", "1" },
                                                        { "0", "3", "0", "9", "7", "0", "8", "6", "5" },
                                                        { "0", "9", "0", "5", "0", "1", "4", "0", "2" },
                                                        { "0", "5", "0", "0", "0", "6", "9", "0", "3" },
                                                        { "0", "0", "0", "7", "2", "8", "0", "0", "4" },
                                                        { "9", "0", "0", "4", "1", "0", "0", "5", "7" },
                                                        { "0", "4", "0", "6", "9", "0", "1", "0", "8" } };*/

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    string currentElement = newGamePuzzle.Mat[row, col];
                    if(currentElement == "0")
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
