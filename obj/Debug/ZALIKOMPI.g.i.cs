﻿#pragma checksum "..\..\ZALIKOMPI.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6672E7E8D3937FE35B3E67F346BDDC7CE5D6490A7EA3FD641F33FE45000B3A77"
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
    /// ZALIKOMPI
    /// </summary>
    public partial class ZALIKOMPI : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\ZALIKOMPI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DT;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ZALIKOMPI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dob;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ZALIKOMPI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button del;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ZALIKOMPI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izm;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ZALIKOMPI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ZALIKOMPI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb1;
        
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
            System.Uri resourceLocater = new System.Uri("/PC_klub;component/zalikompi.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ZALIKOMPI.xaml"
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
            this.DT = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\ZALIKOMPI.xaml"
            this.DT.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DT_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dob = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\ZALIKOMPI.xaml"
            this.dob.Click += new System.Windows.RoutedEventHandler(this.dob_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.del = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\ZALIKOMPI.xaml"
            this.del.Click += new System.Windows.RoutedEventHandler(this.del_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.izm = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\ZALIKOMPI.xaml"
            this.izm.Click += new System.Windows.RoutedEventHandler(this.izm_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cb1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

