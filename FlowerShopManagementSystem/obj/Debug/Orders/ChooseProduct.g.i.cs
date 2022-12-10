﻿#pragma checksum "..\..\..\Orders\ChooseProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C0EA0711E15322E5FE9E8D323DBDE36ED5943ED923F3CE8260D3EAD76DC6412"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FlowerShopManagementSystem.Orders;
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


namespace FlowerShopManagementSystem.Orders {
    
    
    /// <summary>
    /// ChooseProduct
    /// </summary>
    public partial class ChooseProduct : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\..\Orders\ChooseProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExitChooseProduct;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Orders\ChooseProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxFilter;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Orders\ChooseProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFindProduct;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Orders\ChooseProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl ListProductsChoose;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\..\Orders\ChooseProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/FlowerShopManagementSystem;component/orders/chooseproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Orders\ChooseProduct.xaml"
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
            this.btnExitChooseProduct = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\Orders\ChooseProduct.xaml"
            this.btnExitChooseProduct.Click += new System.Windows.RoutedEventHandler(this.btnExitChooseProduct_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBoxFilter = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnFindProduct = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\Orders\ChooseProduct.xaml"
            this.btnFindProduct.Click += new System.Windows.RoutedEventHandler(this.btnFindProduct_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListProductsChoose = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 5:
            this.confirmBtn = ((System.Windows.Controls.Button)(target));
            
            #line 208 "..\..\..\Orders\ChooseProduct.xaml"
            this.confirmBtn.Click += new System.Windows.RoutedEventHandler(this.confirmBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

