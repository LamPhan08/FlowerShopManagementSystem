﻿#pragma checksum "..\..\..\NotificationBox\CannotDeleteBox.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "296306BC074A6B900965CA4B7A5A7CA3B0BB581470746EF4D853ACF8ADC69B4E"
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


namespace FlowerShopManagementSystem.NotificationBox {
    
    
    /// <summary>
    /// CannotDeleteBox
    /// </summary>
    public partial class CannotDeleteBox : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\NotificationBox\CannotDeleteBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitCannotDeleteBoxBtn;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\NotificationBox\CannotDeleteBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseBox;
        
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
            System.Uri resourceLocater = new System.Uri("/FlowerShopManagementSystem;component/notificationbox/cannotdeletebox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NotificationBox\CannotDeleteBox.xaml"
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
            
            #line 8 "..\..\..\NotificationBox\CannotDeleteBox.xaml"
            ((FlowerShopManagementSystem.NotificationBox.CannotDeleteBox)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.exitCannotDeleteBoxBtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\NotificationBox\CannotDeleteBox.xaml"
            this.exitCannotDeleteBoxBtn.Click += new System.Windows.RoutedEventHandler(this.exitCannotDeleteBoxBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCloseBox = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\NotificationBox\CannotDeleteBox.xaml"
            this.btnCloseBox.Click += new System.Windows.RoutedEventHandler(this.btnCloseBox_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

