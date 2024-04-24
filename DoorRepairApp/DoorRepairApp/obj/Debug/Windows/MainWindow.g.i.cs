﻿#pragma checksum "..\..\..\Windows\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BA7DE014628C85F5FBBB7F18B42243CD25B19CAB61DDDFA2A3830AB424AA1A4A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DoorRepairApp;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace DoorRepairApp {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnQuests;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnServices;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBooking;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUsers;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMyBooking;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMyAccount;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockUser;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEnter;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon IconBtnKey;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/DoorRepairApp;component/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MainWindow.xaml"
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
            
            #line 12 "..\..\..\Windows\MainWindow.xaml"
            ((DoorRepairApp.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.WindowClosing);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Windows\MainWindow.xaml"
            ((DoorRepairApp.MainWindow)(target)).Closed += new System.EventHandler(this.WindowClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnQuests = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Windows\MainWindow.xaml"
            this.BtnQuests.Click += new System.Windows.RoutedEventHandler(this.BtnQuests_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnServices = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Windows\MainWindow.xaml"
            this.BtnServices.Click += new System.Windows.RoutedEventHandler(this.BtnServices_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnBooking = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Windows\MainWindow.xaml"
            this.BtnBooking.Click += new System.Windows.RoutedEventHandler(this.BtnBooking_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnUsers = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Windows\MainWindow.xaml"
            this.BtnUsers.Click += new System.Windows.RoutedEventHandler(this.BtnUsers_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnMyBooking = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Windows\MainWindow.xaml"
            this.BtnMyBooking.Click += new System.Windows.RoutedEventHandler(this.BtnMyOrders_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\Windows\MainWindow.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBackClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnMyAccount = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Windows\MainWindow.xaml"
            this.BtnMyAccount.Click += new System.Windows.RoutedEventHandler(this.BtnMyAccount_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TextBlockUser = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.BtnEnter = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Windows\MainWindow.xaml"
            this.BtnEnter.Click += new System.Windows.RoutedEventHandler(this.BtnEnter_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.IconBtnKey = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 12:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            
            #line 84 "..\..\..\Windows\MainWindow.xaml"
            this.MainFrame.ContentRendered += new System.EventHandler(this.MainFrameContentRendered);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

