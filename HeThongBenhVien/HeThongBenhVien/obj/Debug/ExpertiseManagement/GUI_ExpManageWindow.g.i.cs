﻿#pragma checksum "..\..\..\ExpertiseManagement\GUI_ExpManageWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3F994E790A5A01AA527CD97DDC3EA2E4307B45EC6719A2262467469544F11BC6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HeThongBenhVien.ExpertiseManagement;
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


namespace HeThongBenhVien.ExpertiseManagement {
    
    
    /// <summary>
    /// GUI_ExpManageWindow
    /// </summary>
    public partial class GUI_ExpManageWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\ExpertiseManagement\GUI_ExpManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MenuTab;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\ExpertiseManagement\GUI_ExpManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageExpertiseButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ExpertiseManagement\GUI_ExpManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OtherButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\ExpertiseManagement\GUI_ExpManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush AvatarIcon;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\ExpertiseManagement\GUI_ExpManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LoginUsernameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\ExpertiseManagement\GUI_ExpManageWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/HeThongBenhVien;component/expertisemanagement/gui_expmanagewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ExpertiseManagement\GUI_ExpManageWindow.xaml"
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
            
            #line 9 "..\..\..\ExpertiseManagement\GUI_ExpManageWindow.xaml"
            ((HeThongBenhVien.ExpertiseManagement.GUI_ExpManageWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MenuTab = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ManageExpertiseButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\ExpertiseManagement\GUI_ExpManageWindow.xaml"
            this.ManageExpertiseButton.Click += new System.Windows.RoutedEventHandler(this.ManageExpertiseButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OtherButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\ExpertiseManagement\GUI_ExpManageWindow.xaml"
            this.OtherButton.Click += new System.Windows.RoutedEventHandler(this.OtherButton_Click);
            
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

