﻿#pragma checksum "..\..\..\Pages\ShowOrderPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "61349EA7435405B5B7FEAD6E0B5CC7FDC82F9E88EC6C5B9EECFE1992E4FE7EDD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DoorRepairApp.Pages;
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


namespace DoorRepairApp.Pages {
    
    
    /// <summary>
    /// ShowOrderPage
    /// </summary>
    public partial class ShowOrderPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\Pages\ShowOrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockOrderNumber;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\ShowOrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockOrderCreateDate;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Pages\ShowOrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridDoorsOrder;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Pages\ShowOrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridServicesOrder;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Pages\ShowOrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockTotalCost;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\Pages\ShowOrderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSavePDF;
        
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
            System.Uri resourceLocater = new System.Uri("/DoorRepairApp;component/pages/showorderpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ShowOrderPage.xaml"
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
            this.TextBlockOrderNumber = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TextBlockOrderCreateDate = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.DataGridDoorsOrder = ((System.Windows.Controls.DataGrid)(target));
            
            #line 62 "..\..\..\Pages\ShowOrderPage.xaml"
            this.DataGridDoorsOrder.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.DataGridGoodLoadingRow);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DataGridServicesOrder = ((System.Windows.Controls.DataGrid)(target));
            
            #line 113 "..\..\..\Pages\ShowOrderPage.xaml"
            this.DataGridServicesOrder.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.DataGridGoodLoadingRow);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TextBlockTotalCost = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.BtnSavePDF = ((System.Windows.Controls.Button)(target));
            
            #line 143 "..\..\..\Pages\ShowOrderPage.xaml"
            this.BtnSavePDF.Click += new System.Windows.RoutedEventHandler(this.BtnSavePDF_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

