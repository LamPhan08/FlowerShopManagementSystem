﻿#pragma checksum "..\..\..\Suppliers\AddSupplierForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0B83C3EC0FF273EEFD43D2F82B70A3F18098E5F676F21808D9EB11F4BD499BCE"
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


namespace FlowerShopManagementSystem.Suppliers {
    
    
    /// <summary>
    /// AddSupplierForm
    /// </summary>
    public partial class AddSupplierForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\Suppliers\AddSupplierForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxSupplierName;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Suppliers\AddSupplierForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxSupplierPhone;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Suppliers\AddSupplierForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxSupplierHouseNumber;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Suppliers\AddSupplierForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxSupplierStreet;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Suppliers\AddSupplierForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbSupplierWard;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Suppliers\AddSupplierForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbSupplierCity;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Suppliers\AddSupplierForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbSupplierProvince;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Suppliers\AddSupplierForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSupplier;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Suppliers\AddSupplierForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBackAddSupplier;
        
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
            System.Uri resourceLocater = new System.Uri("/FlowerShopManagementSystem;component/suppliers/addsupplierform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Suppliers\AddSupplierForm.xaml"
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
            this.tbxSupplierName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbxSupplierPhone = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\..\Suppliers\AddSupplierForm.xaml"
            this.tbxSupplierPhone.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbxSupplierPhone_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbxSupplierHouseNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbxSupplierStreet = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cbbSupplierWard = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cbbSupplierCity = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.cbbSupplierProvince = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnAddSupplier = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\Suppliers\AddSupplierForm.xaml"
            this.btnAddSupplier.Click += new System.Windows.RoutedEventHandler(this.btnAddSupplier_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnBackAddSupplier = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\Suppliers\AddSupplierForm.xaml"
            this.btnBackAddSupplier.Click += new System.Windows.RoutedEventHandler(this.btnBackAddSupplier_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

