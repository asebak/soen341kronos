﻿#pragma checksum "C:\Users\ahmadsebak\Documents\GitHub\soen341kronos\Kronos\TimeTableDesign\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6684ED8FA5BE1BCB8779F68D3A08024A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace TimeTableDesign {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.DataGrid TimeTable;
        
        internal System.Windows.Controls.ComboBox ParamterList;
        
        internal System.Windows.Controls.CheckBox Fall_checkbox;
        
        internal System.Windows.Controls.CheckBox Winter_checkbox;
        
        internal System.Windows.Controls.CheckBox Summer_checkbox;
        
        internal System.Windows.Controls.AutoCompleteBox Course_textbox;
        
        internal System.Windows.Controls.Button Course_entered;
        
        internal System.Windows.Controls.Button save_button;
        
        internal System.Windows.Controls.DataPager generated_schedule_page;
        
        internal System.Windows.Controls.Button generate_schedule_button;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/TimeTableDesign;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TimeTable = ((System.Windows.Controls.DataGrid)(this.FindName("TimeTable")));
            this.ParamterList = ((System.Windows.Controls.ComboBox)(this.FindName("ParamterList")));
            this.Fall_checkbox = ((System.Windows.Controls.CheckBox)(this.FindName("Fall_checkbox")));
            this.Winter_checkbox = ((System.Windows.Controls.CheckBox)(this.FindName("Winter_checkbox")));
            this.Summer_checkbox = ((System.Windows.Controls.CheckBox)(this.FindName("Summer_checkbox")));
            this.Course_textbox = ((System.Windows.Controls.AutoCompleteBox)(this.FindName("Course_textbox")));
            this.Course_entered = ((System.Windows.Controls.Button)(this.FindName("Course_entered")));
            this.save_button = ((System.Windows.Controls.Button)(this.FindName("save_button")));
            this.generated_schedule_page = ((System.Windows.Controls.DataPager)(this.FindName("generated_schedule_page")));
            this.generate_schedule_button = ((System.Windows.Controls.Button)(this.FindName("generate_schedule_button")));
        }
    }
}

