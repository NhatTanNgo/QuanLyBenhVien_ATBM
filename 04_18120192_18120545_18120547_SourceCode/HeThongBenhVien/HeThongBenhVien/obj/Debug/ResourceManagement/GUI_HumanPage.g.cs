#pragma checksum "..\..\..\ResourceManagement\GUI_HumanPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6BD8FF713B4EAB0E11CFC7ED8CBDAFC477C607646EBCA367BF85ADF478D622E3"
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
    /// GUI_HumanPage
    /// </summary>
    public partial class GUI_HumanPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\ResourceManagement\GUI_HumanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RefreshButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\ResourceManagement\GUI_HumanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddHumanButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\ResourceManagement\GUI_HumanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteHumanButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\ResourceManagement\GUI_HumanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid HumanDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/HeThongBenhVien;component/resourcemanagement/gui_humanpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ResourceManagement\GUI_HumanPage.xaml"
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
            this.RefreshButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\ResourceManagement\GUI_HumanPage.xaml"
            this.RefreshButton.Click += new System.Windows.RoutedEventHandler(this.RefreshButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddHumanButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\ResourceManagement\GUI_HumanPage.xaml"
            this.AddHumanButton.Click += new System.Windows.RoutedEventHandler(this.AddHumanButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteHumanButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\ResourceManagement\GUI_HumanPage.xaml"
            this.DeleteHumanButton.Click += new System.Windows.RoutedEventHandler(this.DeleteHumanButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.HumanDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

