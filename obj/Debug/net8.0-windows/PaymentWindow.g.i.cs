﻿#pragma checksum "..\..\..\PaymentWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "603F50F67A4EACA8CADDC3E6A8316615F9209D02"
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
using System.Windows.Controls.Ribbon;
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
using WpfIPLTicketHub;


namespace WpfIPLTicketHub {
    
    
    /// <summary>
    /// PaymentWindow
    /// </summary>
    public partial class PaymentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CardNumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox CVVTextBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\PaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ExpiryDateTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfIPLTicketHub;component/paymentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PaymentWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CardNumberTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\PaymentWindow.xaml"
            this.CardNumberTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CardNumberTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CVVTextBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 63 "..\..\..\PaymentWindow.xaml"
            this.CVVTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CVVTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ExpiryDateTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 77 "..\..\..\PaymentWindow.xaml"
            this.ExpiryDateTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ExpiryDateTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 89 "..\..\..\PaymentWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PayNowButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

