﻿#pragma checksum "..\..\LOGPAROL.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AB65E7B552E0851F97E5025C11477744DC140199AE9C091E2846DA261410322B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using PC_klub;
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


namespace PC_klub {
    
    
    /// <summary>
    /// LOGPAROL
    /// </summary>
    public partial class LOGPAROL : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\LOGPAROL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dt1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\LOGPAROL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dob;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\LOGPAROL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button del;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\LOGPAROL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izm;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\LOGPAROL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\LOGPAROL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_Copy;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\LOGPAROL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_Copy1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\LOGPAROL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_Copy2;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\LOGPAROL.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Combo;
        
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
            System.Uri resourceLocater = new System.Uri("/PC_klub;component/logparol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LOGPAROL.xaml"
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
            this.dt1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\LOGPAROL.xaml"
            this.dt1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dob = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\LOGPAROL.xaml"
            this.dob.Click += new System.Windows.RoutedEventHandler(this.dob_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.del = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\LOGPAROL.xaml"
            this.del.Click += new System.Windows.RoutedEventHandler(this.del_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.izm = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\LOGPAROL.xaml"
            this.izm.Click += new System.Windows.RoutedEventHandler(this.izm_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbx_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbx_Copy1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbx_Copy2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Combo = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

