﻿#pragma checksum "..\..\..\MainDemo\Encrypt_InsertMedicalRecord.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6AD494604998C59463A6335FD71642A151D3E7E19977997F04C1AA6050A45B59"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HeThongBenhVien.MainDemo;
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


namespace HeThongBenhVien.MainDemo {
    
    
    /// <summary>
    /// Encrypt_InsertMedicalRecord
    /// </summary>
    public partial class Encrypt_InsertMedicalRecord : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\MainDemo\Encrypt_InsertMedicalRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_medicalRecordID;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainDemo\Encrypt_InsertMedicalRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_patientID;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\MainDemo\Encrypt_InsertMedicalRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_symptompsID;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\MainDemo\Encrypt_InsertMedicalRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_diagnoseID;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\MainDemo\Encrypt_InsertMedicalRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_doctorID;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\MainDemo\Encrypt_InsertMedicalRecord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertButton;
        
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
            System.Uri resourceLocater = new System.Uri("/HeThongBenhVien;component/maindemo/encrypt_insertmedicalrecord.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainDemo\Encrypt_InsertMedicalRecord.xaml"
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
            this.txtbox_medicalRecordID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtbox_patientID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtbox_symptompsID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtbox_diagnoseID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtbox_doctorID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.InsertButton = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\MainDemo\Encrypt_InsertMedicalRecord.xaml"
            this.InsertButton.Click += new System.Windows.RoutedEventHandler(this.InsertButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

