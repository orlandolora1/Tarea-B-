﻿#pragma checksum "..\..\..\..\Ejercicios\Ejercicio_2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "509CA66D220AFA0CA655796CADBC8AC9F0392851"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Capitulo_6.Ejercicios;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Capitulo_6.Ejercicios {
    
    
    /// <summary>
    /// Ejercicio_2
    /// </summary>
    public partial class Ejercicio_2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Ejercicios\Ejercicio_2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CursosTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Ejercicios\Ejercicio_2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AgregarCursoButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Ejercicios\Ejercicio_2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AregarCalificaionesButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Ejercicios\Ejercicio_2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ResultadosListView;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Ejercicios\Ejercicio_2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResultadoButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Ejercicios\Ejercicio_2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CalificacionesListView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Capitulo_6;component/ejercicios/ejercicio_2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Ejercicios\Ejercicio_2.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CursosTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.AgregarCursoButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Ejercicios\Ejercicio_2.xaml"
            this.AgregarCursoButton.Click += new System.Windows.RoutedEventHandler(this.AgregarCursoButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AregarCalificaionesButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Ejercicios\Ejercicio_2.xaml"
            this.AregarCalificaionesButton.Click += new System.Windows.RoutedEventHandler(this.AregarCalificaionesButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ResultadosListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.ResultadoButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Ejercicios\Ejercicio_2.xaml"
            this.ResultadoButton.Click += new System.Windows.RoutedEventHandler(this.ResultadoButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CalificacionesListView = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

