﻿#pragma checksum "..\..\..\Pages\AnalysePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F69ED793C261B1A9AE67410FC403FB4D6405D325"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using HelixGen.Pages;
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.Charts;
using Microsoft.Research.DynamicDataDisplay.Charts.Axes;
using Microsoft.Research.DynamicDataDisplay.Charts.Navigation;
using Microsoft.Research.DynamicDataDisplay.Charts.Shapes;
using Microsoft.Research.DynamicDataDisplay.Common.Palettes;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.Navigation;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
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


namespace HelixGen.Pages {
    
    
    /// <summary>
    /// AnalysePage
    /// </summary>
    public partial class AnalysePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 59 "..\..\..\Pages\AnalysePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rongjie;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\AnalysePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.ChartPlotter pcrplotter;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Pages\AnalysePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.Charts.Axes.HorizontalIntegerAxis pcrdateAxis;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Pages\AnalysePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.ChartPlotter plotter;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Pages\AnalysePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.Charts.Axes.HorizontalIntegerAxis dateAxis;
        
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
            System.Uri resourceLocater = new System.Uri("/HelixGen;component/pages/analysepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AnalysePage.xaml"
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
            
            #line 26 "..\..\..\Pages\AnalysePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_SelectData);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 31 "..\..\..\Pages\AnalysePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click1);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 36 "..\..\..\Pages\AnalysePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rongjie = ((System.Windows.Controls.RadioButton)(target));
            
            #line 59 "..\..\..\Pages\AnalysePage.xaml"
            this.rongjie.Checked += new System.Windows.RoutedEventHandler(this.OnCheckedEnlarge);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 60 "..\..\..\Pages\AnalysePage.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 61 "..\..\..\Pages\AnalysePage.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.pcrplotter = ((Microsoft.Research.DynamicDataDisplay.ChartPlotter)(target));
            return;
            case 8:
            this.pcrdateAxis = ((Microsoft.Research.DynamicDataDisplay.Charts.Axes.HorizontalIntegerAxis)(target));
            return;
            case 9:
            
            #line 85 "..\..\..\Pages\AnalysePage.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.catrigeButton_Checked_1);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 86 "..\..\..\Pages\AnalysePage.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.catrigeButton_Checked_2);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 87 "..\..\..\Pages\AnalysePage.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.catrigeButton_Checked_3);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 88 "..\..\..\Pages\AnalysePage.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.catrigeButton_Checked_4);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 89 "..\..\..\Pages\AnalysePage.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.catrigeButton_Checked_5);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 90 "..\..\..\Pages\AnalysePage.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.catrigeButton_Checked_6);
            
            #line default
            #line hidden
            return;
            case 15:
            this.plotter = ((Microsoft.Research.DynamicDataDisplay.ChartPlotter)(target));
            return;
            case 16:
            this.dateAxis = ((Microsoft.Research.DynamicDataDisplay.Charts.Axes.HorizontalIntegerAxis)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

