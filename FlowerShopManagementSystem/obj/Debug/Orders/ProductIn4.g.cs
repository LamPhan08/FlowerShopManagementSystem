﻿#pragma checksum "..\..\..\Orders\ProductIn4.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5F84DCD75924E2451C9948EE62772075ABE7A9E84B52D8887CF33CEC7FF5CB56"
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


namespace FlowerShopManagementSystem.Orders {
    
    
    /// <summary>
    /// ProductIn4
    /// </summary>
    public partial class ProductIn4 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 100 "..\..\..\Orders\ProductIn4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtblckProductID;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Orders\ProductIn4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtblckProductPrice;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\Orders\ProductIn4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtblckProductName;
        
        #line default
        #line hidden
        
        /// <summary>
        /// tb_main Name Field
        /// </summary>
        
        #line 167 "..\..\..\Orders\ProductIn4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.TextBox tb_main;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\..\Orders\ProductIn4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.Button cmdUp;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\..\Orders\ProductIn4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.Button cmdDown;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\Orders\ProductIn4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brdBrush;
        
        #line default
        #line hidden
        
        
        #line 235 "..\..\..\Orders\ProductIn4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image viewProductImage;
        
        #line default
        #line hidden
        
        
        #line 247 "..\..\..\Orders\ProductIn4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBackProductIn4;
        
        #line default
        #line hidden
        
        
        #line 250 "..\..\..\Orders\ProductIn4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConfirm;
        
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
            System.Uri resourceLocater = new System.Uri("/FlowerShopManagementSystem;component/orders/productin4.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Orders\ProductIn4.xaml"
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
            this.txtblckProductID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtblckProductPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtblckProductName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.tb_main = ((System.Windows.Controls.TextBox)(target));
            
            #line 178 "..\..\..\Orders\ProductIn4.xaml"
            this.tb_main.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_main_TextChanged);
            
            #line default
            #line hidden
            
            #line 179 "..\..\..\Orders\ProductIn4.xaml"
            this.tb_main.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tb_main_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmdUp = ((System.Windows.Controls.Button)(target));
            
            #line 188 "..\..\..\Orders\ProductIn4.xaml"
            this.cmdUp.Click += new System.Windows.RoutedEventHandler(this.cmdUp_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cmdDown = ((System.Windows.Controls.Button)(target));
            
            #line 205 "..\..\..\Orders\ProductIn4.xaml"
            this.cmdDown.Click += new System.Windows.RoutedEventHandler(this.cmdDown_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.brdBrush = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.viewProductImage = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.btnBackProductIn4 = ((System.Windows.Controls.Button)(target));
            
            #line 248 "..\..\..\Orders\ProductIn4.xaml"
            this.btnBackProductIn4.Click += new System.Windows.RoutedEventHandler(this.btnBackProductIn4_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnConfirm = ((System.Windows.Controls.Button)(target));
            
            #line 251 "..\..\..\Orders\ProductIn4.xaml"
            this.btnConfirm.Click += new System.Windows.RoutedEventHandler(this.btnConfirm_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

