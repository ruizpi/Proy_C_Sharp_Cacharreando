﻿#pragma checksum "..\..\..\Views\Usuarios.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DC332E260E9C6B3C01F4AEDF5F599EF7374528828A012E2C87EC809545AB2DFA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using PuntoDeVenta_Completo_Ago2023.Views;
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


namespace PuntoDeVenta_Completo_Ago2023.Views {
    
    
    /// <summary>
    /// Usuarios
    /// </summary>
    public partial class Usuarios : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 20 "..\..\..\Views\Usuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridUsuarios;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\Usuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameUsuarios;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\Usuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Contenido;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Views\Usuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbBuscar;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Views\Usuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCrearUsuario;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\Views\Usuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridDatos;
        
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
            System.Uri resourceLocater = new System.Uri("/PuntoDeVenta_Completo_Ago2023;component/views/usuarios.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Usuarios.xaml"
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
            this.GridUsuarios = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.FrameUsuarios = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.Contenido = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.tbBuscar = ((System.Windows.Controls.TextBox)(target));
            
            #line 88 "..\..\..\Views\Usuarios.xaml"
            this.tbBuscar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Buscando);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnCrearUsuario = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\Views\Usuarios.xaml"
            this.BtnCrearUsuario.Click += new System.Windows.RoutedEventHandler(this.Agregar);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GridDatos = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 147 "..\..\..\Views\Usuarios.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickConsultar);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 157 "..\..\..\Views\Usuarios.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickEditar);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 166 "..\..\..\Views\Usuarios.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickEliminar);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

