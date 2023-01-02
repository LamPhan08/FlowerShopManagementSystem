﻿#pragma checksum "..\..\..\Dashboard\DashboardView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AAF523E58834023951275703EDB8A3F5A7BBF461F09790A01B4C3A398805DB70"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FlowerShopManagementSystem;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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


namespace FlowerShopManagementSystem.Dashboard {
    
    
    /// <summary>
    /// DashboardView
    /// </summary>
    public partial class DashboardView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 34 "..\..\..\Dashboard\DashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button shiftLeft;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Dashboard\DashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scroll;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Dashboard\DashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stkpnl;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Dashboard\DashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button shiftRight;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Dashboard\DashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxFilter;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Dashboard\DashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl DashboardProductsList;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\Dashboard\DashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFirstPage;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\Dashboard\DashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPreviousPage;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\Dashboard\DashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNextPage;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\Dashboard\DashboardView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLastPage;
        
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
            System.Uri resourceLocater = new System.Uri("/FlowerShopManagementSystem;component/dashboard/dashboardview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dashboard\DashboardView.xaml"
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
            this.shiftLeft = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Dashboard\DashboardView.xaml"
            this.shiftLeft.Click += new System.Windows.RoutedEventHandler(this.shiftLeft_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.scroll = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 3:
            this.stkpnl = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.shiftRight = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\Dashboard\DashboardView.xaml"
            this.shiftRight.Click += new System.Windows.RoutedEventHandler(this.shiftRight_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBoxFilter = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DashboardProductsList = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 9:
            this.btnFirstPage = ((System.Windows.Controls.Button)(target));
            
            #line 164 "..\..\..\Dashboard\DashboardView.xaml"
            this.btnFirstPage.Click += new System.Windows.RoutedEventHandler(this.btnFirstPage_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnPreviousPage = ((System.Windows.Controls.Button)(target));
            
            #line 168 "..\..\..\Dashboard\DashboardView.xaml"
            this.btnPreviousPage.Click += new System.Windows.RoutedEventHandler(this.btnPreviousPage_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnNextPage = ((System.Windows.Controls.Button)(target));
            
            #line 180 "..\..\..\Dashboard\DashboardView.xaml"
            this.btnNextPage.Click += new System.Windows.RoutedEventHandler(this.btnNextPage_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnLastPage = ((System.Windows.Controls.Button)(target));
            
            #line 184 "..\..\..\Dashboard\DashboardView.xaml"
            this.btnLastPage.Click += new System.Windows.RoutedEventHandler(this.btnLastPage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 129 "..\..\..\Dashboard\DashboardView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDashboardProductIn4_Click);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 133 "..\..\..\Dashboard\DashboardView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnShopping_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

