﻿#pragma checksum "..\..\InterfazPrincipal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F4C34C666F80D230EEF045D52ADAE9F4F05A1A7B740AB38C4183BF1CB573C172"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Senderismo;
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


namespace Senderismo {
    
    
    /// <summary>
    /// InterfazPrincipal
    /// </summary>
    public partial class InterfazPrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabGeneral;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabSenderistas;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstSenderistas;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Annadir_Senderias;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Eliminar_Sendrista;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lblNombre;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stackPersonalInfo;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuardar;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabRutas;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabGuias;
        
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
            System.Uri resourceLocater = new System.Uri("/Senderismo;component/interfazprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InterfazPrincipal.xaml"
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
            this.tabGeneral = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.tabSenderistas = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.lstSenderistas = ((System.Windows.Controls.ListBox)(target));
            
            #line 21 "..\..\InterfazPrincipal.xaml"
            this.lstSenderistas.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstSenderistas_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Annadir_Senderias = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\InterfazPrincipal.xaml"
            this.Annadir_Senderias.Click += new System.Windows.RoutedEventHandler(this.annadir_senderias_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Eliminar_Sendrista = ((System.Windows.Controls.MenuItem)(target));
            
            #line 29 "..\..\InterfazPrincipal.xaml"
            this.Eliminar_Sendrista.Click += new System.Windows.RoutedEventHandler(this.Eliminar_senderista_click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.stackPersonalInfo = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.btnGuardar = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.tabRutas = ((System.Windows.Controls.TabItem)(target));
            return;
            case 10:
            this.tabGuias = ((System.Windows.Controls.TabItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

