﻿#pragma checksum "..\..\mainwindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EF1777FAD03D0BA9448CA68959685E04425B9D10E068276F34FC04FF46339B63"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Case_study_test2;
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


namespace Case_study_test2 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid_Student;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid_CurrentCourses;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid_AcademicHistory;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_EditProfile;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddCourses;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_DropCourses;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Refresh;
        
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
            System.Uri resourceLocater = new System.Uri("/Case_study_test2;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\mainwindow.xaml"
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
            this.grid_Student = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.grid_CurrentCourses = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\mainwindow.xaml"
            this.grid_CurrentCourses.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.grid_DropCourse_DoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.grid_AcademicHistory = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.btn_EditProfile = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\mainwindow.xaml"
            this.btn_EditProfile.Click += new System.Windows.RoutedEventHandler(this.btn_EditProfile_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_AddCourses = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\mainwindow.xaml"
            this.btn_AddCourses.Click += new System.Windows.RoutedEventHandler(this.btn_AddCourses_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_DropCourses = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\mainwindow.xaml"
            this.btn_DropCourses.Click += new System.Windows.RoutedEventHandler(this.btn_DropCourse_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Refresh = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\mainwindow.xaml"
            this.btn_Refresh.Click += new System.Windows.RoutedEventHandler(this.MainWindow_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
