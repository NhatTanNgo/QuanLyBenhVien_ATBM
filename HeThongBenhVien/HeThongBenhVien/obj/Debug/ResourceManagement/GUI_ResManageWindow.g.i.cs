﻿#pragma checksum "..\..\..\ResourceManagement\GUI_ResManageWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "075B8AD4703DFDB5C020723A1FA1ADDE1A9B9884ED1E6FB03CE8302985DF232C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HeThongBenhVien.ResourceManagement;
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


namespace HeThongBenhVien.ResourceManagement {
    
    
    /// <summary>
    /// GUI_ResManageWindow
    /// </summary>
    public partial class GUI_ResManageWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\ResourceManagement\GUI_ResManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MenuTab;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ResourceManagement\GUI_ResManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageRoomButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\ResourceManagement\GUI_ResManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageHumanButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\ResourceManagement\GUI_ResManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageScheduleButton;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\ResourceManagement\GUI_ResManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush AvatarIcon;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\ResourceManagement\GUI_ResManageWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LoginUsernameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\ResourceManagement\GUI_ResManageWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/HeThongBenhVien;component/resourcemanagement/gui_resmanagewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ResourceManagement\GUI_ResManageWindow.xaml"
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
            
            #line 9 "..\..\..\ResourceManagement\GUI_ResManageWindow.xaml"
            ((HeThongBenhVien.ResourceManagement.GUI_ResManageWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MenuTab = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ManageRoomButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\ResourceManagement\GUI_ResManageWindow.xaml"
            this.ManageRoomButton.Click += new System.Windows.RoutedEventHandler(this.ManageRoomButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ManageHumanButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\ResourceManagement\GUI_ResManageWindow.xaml"
            this.ManageHumanButton.Click += new System.Windows.RoutedEventHandler(this.ManageHumanButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ManageScheduleButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\ResourceManagement\GUI_ResManageWindow.xaml"
            this.ManageScheduleButton.Click += new System.Windows.RoutedEventHandler(this.ManageScheduleButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AvatarIcon = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 7:
            this.LoginUsernameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

