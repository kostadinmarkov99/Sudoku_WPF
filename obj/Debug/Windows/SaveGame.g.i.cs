﻿#pragma checksum "..\..\..\Windows\SaveGame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BE90286488887BD17057441FA56CD4A16BAB47392AA44C3CD98D4BE956EEB50F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfApp4;


namespace WpfApp4 {
    
    
    /// <summary>
    /// SaveGame
    /// </summary>
    public partial class SaveGame : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Windows\SaveGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxFileName;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\SaveGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveGame;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\SaveGame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCanselSaveGame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp4;component/windows/savegame.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\SaveGame.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbxFileName = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\Windows\SaveGame.xaml"
            this.tbxFileName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbx_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSaveGame = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Windows\SaveGame.xaml"
            this.btnSaveGame.Click += new System.Windows.RoutedEventHandler(this.btnSaveGame_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCanselSaveGame = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Windows\SaveGame.xaml"
            this.btnCanselSaveGame.Click += new System.Windows.RoutedEventHandler(this.btnCanselSaveGame_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

