﻿#pragma checksum "..\..\..\Dominici_LoginWPF.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C0A96A9C0C234B7BE375969F8F867201C8CA026E9190DD807B3F28A7BC8D5FD1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
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


namespace Login_WPF {
    
    
    /// <summary>
    /// Welcome
    /// </summary>
    public partial class Welcome : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\Dominici_LoginWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WelcomeHeading;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\Dominici_LoginWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockName;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\Dominici_LoginWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SeAdmin_textBlock;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\Dominici_LoginWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Utenti_Listbox;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Dominici_LoginWPF.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdminSelect;
        
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
            System.Uri resourceLocater = new System.Uri("/Login_WPF;component/dominici_loginwpf.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dominici_LoginWPF.xaml"
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
            this.WelcomeHeading = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TextBlockName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.SeAdmin_textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Utenti_Listbox = ((System.Windows.Controls.ListBox)(target));
            
            #line 9 "..\..\..\Dominici_LoginWPF.xaml"
            this.Utenti_Listbox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Utenti_Listbox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAdminSelect = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Dominici_LoginWPF.xaml"
            this.btnAdminSelect.Click += new System.Windows.RoutedEventHandler(this.btnAdminSelect_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
