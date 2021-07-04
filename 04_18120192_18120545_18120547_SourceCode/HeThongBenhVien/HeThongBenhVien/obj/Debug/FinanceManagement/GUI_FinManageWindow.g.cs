﻿#pragma checksum "..\..\..\FinanceManagement\GUI_FinManageWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EC1B39CED31ECD533275F19E9F67A77075F94A474659BFF5BC68F7F596A20D1A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Media.Animation;
using HandyControl.Media.Effects;
using HandyControl.Properties.Langs;
using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Converter;
using HandyControl.Tools.Extension;
using HeThongBenhVien.FinanceManagement;
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


namespace HeThongBenhVien.FinanceManagement {
    
    
    /// <summary>
    /// GUI_FinManageWindow
    /// </summary>
    public partial class GUI_FinManageWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\FinanceManagement\GUI_FinManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MenuTab;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\FinanceManagement\GUI_FinManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageFinStaffButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\FinanceManagement\GUI_FinManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageServiceButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\FinanceManagement\GUI_FinManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush AvatarIcon;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\FinanceManagement\GUI_FinManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LoginUsernameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\FinanceManagement\GUI_FinManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/HeThongBenhVien;component/financemanagement/gui_finmanagewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FinanceManagement\GUI_FinManageWindow.xaml"
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
            
            #line 10 "..\..\..\FinanceManagement\GUI_FinManageWindow.xaml"
            ((HeThongBenhVien.FinanceManagement.GUI_FinManageWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MenuTab = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ManageFinStaffButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\FinanceManagement\GUI_FinManageWindow.xaml"
            this.ManageFinStaffButton.Click += new System.Windows.RoutedEventHandler(this.ManageFinStaffButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ManageServiceButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\FinanceManagement\GUI_FinManageWindow.xaml"
            this.ManageServiceButton.Click += new System.Windows.RoutedEventHandler(this.ManageServiceButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AvatarIcon = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 6:
            this.LoginUsernameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

