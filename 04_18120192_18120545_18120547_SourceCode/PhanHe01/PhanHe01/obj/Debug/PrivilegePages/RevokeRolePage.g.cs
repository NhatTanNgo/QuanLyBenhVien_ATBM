﻿#pragma checksum "..\..\..\PrivilegePages\RevokeRolePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9A3B5A252FCEC16344F1B46C6DB9195C45A5C72589F45FC55B0DD3198E68D8B2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PhanHe01.PrivilegePages;
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


namespace PhanHe01.PrivilegePages {
    
    
    /// <summary>
    /// RevokeRolePage
    /// </summary>
    public partial class RevokeRolePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\PrivilegePages\RevokeRolePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RoleNameComboBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\PrivilegePages\RevokeRolePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UsernameComboBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\PrivilegePages\RevokeRolePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConfirmButton;
        
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
            System.Uri resourceLocater = new System.Uri("/PhanHe01;component/privilegepages/revokerolepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PrivilegePages\RevokeRolePage.xaml"
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
            
            #line 10 "..\..\..\PrivilegePages\RevokeRolePage.xaml"
            ((PhanHe01.PrivilegePages.RevokeRolePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RoleNameComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.UsernameComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\PrivilegePages\RevokeRolePage.xaml"
            this.UsernameComboBox.DropDownClosed += new System.EventHandler(this.UsernameComboBox_DropDownClosed);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\PrivilegePages\RevokeRolePage.xaml"
            this.UsernameComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UsernameComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ConfirmButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\PrivilegePages\RevokeRolePage.xaml"
            this.ConfirmButton.Click += new System.Windows.RoutedEventHandler(this.ConfirmButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

