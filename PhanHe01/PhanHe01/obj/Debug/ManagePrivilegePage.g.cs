﻿#pragma checksum "..\..\ManagePrivilegePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "183608888174939A8AB2F6BF7EB96BB5D39398F7C4499F6BB403C89BE8377B58"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PhanHe01;
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


namespace PhanHe01 {
    
    
    /// <summary>
    /// ManagePrivilegePage
    /// </summary>
    public partial class ManagePrivilegePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\ManagePrivilegePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GrantPrivilegeButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ManagePrivilegePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GrantRoleToUserButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ManagePrivilegePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SeeRoleOfUserButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ManagePrivilegePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame SubFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/PhanHe01;component/manageprivilegepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManagePrivilegePage.xaml"
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
            
            #line 10 "..\..\ManagePrivilegePage.xaml"
            ((PhanHe01.ManagePrivilegePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GrantPrivilegeButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\ManagePrivilegePage.xaml"
            this.GrantPrivilegeButton.Click += new System.Windows.RoutedEventHandler(this.GrantPrivilegeButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GrantRoleToUserButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\ManagePrivilegePage.xaml"
            this.GrantRoleToUserButton.Click += new System.Windows.RoutedEventHandler(this.GrantRoleToUserButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SeeRoleOfUserButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\ManagePrivilegePage.xaml"
            this.SeeRoleOfUserButton.Click += new System.Windows.RoutedEventHandler(this.SeeRoleOfUserButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SubFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
