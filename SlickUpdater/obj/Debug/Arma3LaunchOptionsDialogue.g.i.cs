﻿#pragma checksum "..\..\Arma3LaunchOptionsDialogue.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2FFF31154F5C35AEF891B62D3259F5A6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace SlickUpdater {
    
    
    /// <summary>
    /// Arma3LaunchOptionsDialogue
    /// </summary>
    public partial class Arma3LaunchOptionsDialogue : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Arma3LaunchOptionsDialogue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox window;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\Arma3LaunchOptionsDialogue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox nosplash;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\Arma3LaunchOptionsDialogue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox skipIntro;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Arma3LaunchOptionsDialogue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox world;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Arma3LaunchOptionsDialogue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox noLogs;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Arma3LaunchOptionsDialogue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox noPause;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Arma3LaunchOptionsDialogue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox showScriptErrors;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Arma3LaunchOptionsDialogue.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customParams;
        
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
            System.Uri resourceLocater = new System.Uri("/Slick Updater Beta;component/arma3launchoptionsdialogue.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Arma3LaunchOptionsDialogue.xaml"
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
            
            #line 4 "..\..\Arma3LaunchOptionsDialogue.xaml"
            ((SlickUpdater.Arma3LaunchOptionsDialogue)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.window = ((System.Windows.Controls.CheckBox)(target));
            
            #line 6 "..\..\Arma3LaunchOptionsDialogue.xaml"
            this.window.Click += new System.Windows.RoutedEventHandler(this.window_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nosplash = ((System.Windows.Controls.CheckBox)(target));
            
            #line 7 "..\..\Arma3LaunchOptionsDialogue.xaml"
            this.nosplash.Click += new System.Windows.RoutedEventHandler(this.nosplash_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.skipIntro = ((System.Windows.Controls.CheckBox)(target));
            
            #line 8 "..\..\Arma3LaunchOptionsDialogue.xaml"
            this.skipIntro.Click += new System.Windows.RoutedEventHandler(this.skipIntro_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.world = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\Arma3LaunchOptionsDialogue.xaml"
            this.world.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.world_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.noLogs = ((System.Windows.Controls.CheckBox)(target));
            
            #line 11 "..\..\Arma3LaunchOptionsDialogue.xaml"
            this.noLogs.Click += new System.Windows.RoutedEventHandler(this.noLogs_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.noPause = ((System.Windows.Controls.CheckBox)(target));
            
            #line 12 "..\..\Arma3LaunchOptionsDialogue.xaml"
            this.noPause.Click += new System.Windows.RoutedEventHandler(this.noPause_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.showScriptErrors = ((System.Windows.Controls.CheckBox)(target));
            
            #line 13 "..\..\Arma3LaunchOptionsDialogue.xaml"
            this.showScriptErrors.Click += new System.Windows.RoutedEventHandler(this.showScriptErrors_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.customParams = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\Arma3LaunchOptionsDialogue.xaml"
            this.customParams.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.customParams_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

