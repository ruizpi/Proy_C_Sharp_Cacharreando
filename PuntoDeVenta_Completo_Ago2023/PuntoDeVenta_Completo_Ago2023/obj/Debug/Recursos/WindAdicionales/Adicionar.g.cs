﻿#pragma checksum "..\..\..\..\Recursos\WindAdicionales\Adicionar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FB7F058817B4488E663FBAA68F2203182A4FBA248E45EA35A5904BB6D3161DF3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using PuntoDeVenta_Completo_Ago2023.Recursos.WindAdicionales;
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


namespace PuntoDeVenta_Completo_Ago2023.Recursos.WindAdicionales {
    
    
    /// <summary>
    /// Adicionar
    /// </summary>
    public partial class Adicionar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Recursos\WindAdicionales\Adicionar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCantidad;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Recursos\WindAdicionales\Adicionar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOk;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Recursos\WindAdicionales\Adicionar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/PuntoDeVenta_Completo_Ago2023;component/recursos/windadicionales/adicionar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Recursos\WindAdicionales\Adicionar.xaml"
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
            this.tbCantidad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BtnOk = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Recursos\WindAdicionales\Adicionar.xaml"
            this.BtnOk.Click += new System.Windows.RoutedEventHandler(this.AceptarCantidad);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Recursos\WindAdicionales\Adicionar.xaml"
            this.BtnCancelar.Click += new System.Windows.RoutedEventHandler(this.CancelarCantidad);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

