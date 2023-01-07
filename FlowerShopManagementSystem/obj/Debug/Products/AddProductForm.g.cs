﻿#pragma checksum "..\..\..\Products\AddProductForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "40B21F09CF2E2ACA633DBB95994A3DFC2706EC3D0E49DFAD32E66B733F766766"
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


namespace FlowerShopManagementSystem.Products {
    
    
    /// <summary>
    /// AddProductForm
    /// </summary>
    public partial class AddProductForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\..\Products\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxProductID;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Products\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxProductType;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Products\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxEvent;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Products\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxProductName;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\Products\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbSuppier;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Products\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxProductPrice;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\Products\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uploadProductImageBtn;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\Products\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image productImage;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\Products\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock notify;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\Products\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddProduct;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\Products\AddProductForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBackAddProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/FlowerShopManagementSystem;component/products/addproductform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Products\AddProductForm.xaml"
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
            this.tbxProductID = ((System.Windows.Controls.TextBox)(target));
            
            #line 62 "..\..\..\Products\AddProductForm.xaml"
            this.tbxProductID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbxProductID_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbxProductType = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\Products\AddProductForm.xaml"
            this.tbxProductType.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbxProductType_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbxEvent = ((System.Windows.Controls.TextBox)(target));
            
            #line 82 "..\..\..\Products\AddProductForm.xaml"
            this.tbxEvent.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbxEvent_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbxProductName = ((System.Windows.Controls.TextBox)(target));
            
            #line 102 "..\..\..\Products\AddProductForm.xaml"
            this.tbxProductName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbxProductName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbbSuppier = ((System.Windows.Controls.ComboBox)(target));
            
            #line 112 "..\..\..\Products\AddProductForm.xaml"
            this.cbbSuppier.DropDownOpened += new System.EventHandler(this.cbbSuppier_DropDownOpened);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbxProductPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 129 "..\..\..\Products\AddProductForm.xaml"
            this.tbxProductPrice.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbxProductPrice_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 130 "..\..\..\Products\AddProductForm.xaml"
            this.tbxProductPrice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbxProductPrice_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.uploadProductImageBtn = ((System.Windows.Controls.Button)(target));
            
            #line 142 "..\..\..\Products\AddProductForm.xaml"
            this.uploadProductImageBtn.Click += new System.Windows.RoutedEventHandler(this.uploadProductImageBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.productImage = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.notify = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.btnAddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 168 "..\..\..\Products\AddProductForm.xaml"
            this.btnAddProduct.Click += new System.Windows.RoutedEventHandler(this.btnAddProduct_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnBackAddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 171 "..\..\..\Products\AddProductForm.xaml"
            this.btnBackAddProduct.Click += new System.Windows.RoutedEventHandler(this.btnBackAddProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

