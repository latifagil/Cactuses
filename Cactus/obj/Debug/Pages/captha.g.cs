﻿#pragma checksum "..\..\..\Pages\captha.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F81DB1702075B3A0DBF6B2F5A9569A78B5B30F200D6EC13A483D2FB7BF6BE346"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Cactus.Pages;
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


namespace Cactus.Pages {
    
    
    /// <summary>
    /// captha
    /// </summary>
    public partial class captha : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Pages\captha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SPanelSymbols;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\captha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas CanvasNoise;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\captha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCapch;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\captha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\captha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpdateCaptcha;
        
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
            System.Uri resourceLocater = new System.Uri("/Cactus;component/pages/captha.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\captha.xaml"
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
            this.SPanelSymbols = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.CanvasNoise = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.TxtCapch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtnButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Pages\captha.xaml"
            this.BtnButton.Click += new System.Windows.RoutedEventHandler(this.BtnButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnUpdateCaptcha = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Pages\captha.xaml"
            this.BtnUpdateCaptcha.Click += new System.Windows.RoutedEventHandler(this.BtnUpdateCaptcha_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

