﻿#pragma checksum "..\..\..\Doctor\GUI_DoctorMedicalRecord.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF06892052A4E9FA8D0B0D830CAAD5296EB0607FA68528064D2954CB2432030F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HeThongBenhVien.Doctor;
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


namespace HeThongBenhVien.Doctor {
    
    
    /// <summary>
    /// GUI_DoctorMedicalRecord
    /// </summary>
    public partial class GUI_DoctorMedicalRecord : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Doctor\GUI_DoctorMedicalRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaBN;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Doctor\GUI_DoctorMedicalRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TenBN;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Doctor\GUI_DoctorMedicalRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NgayKham;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Doctor\GUI_DoctorMedicalRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TrieuChung;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Doctor\GUI_DoctorMedicalRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GioiTinhBN;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Doctor\GUI_DoctorMedicalRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NgaySinh;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Doctor\GUI_DoctorMedicalRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ChanDoan;
        
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
            System.Uri resourceLocater = new System.Uri("/HeThongBenhVien;component/doctor/gui_doctormedicalrecord.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Doctor\GUI_DoctorMedicalRecord.xaml"
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
            
            #line 21 "..\..\..\Doctor\GUI_DoctorMedicalRecord.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MaBN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TenBN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.NgayKham = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TrieuChung = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.GioiTinhBN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.NgaySinh = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ChanDoan = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

