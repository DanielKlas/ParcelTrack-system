﻿#pragma checksum "..\..\..\..\Business layer\Parcel Track.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C8F08FB1965D87A6BDBD632DD15CB690C67B90EE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ParcelTrack;
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


namespace ParcelTrack {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Business layer\Parcel Track.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_output;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Business layer\Parcel Track.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_displayDelivery;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Business layer\Parcel Track.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_courierDetails;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Business layer\Parcel Track.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_targetID;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Business layer\Parcel Track.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_destinationID;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Business layer\Parcel Track.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_parcelTransferID;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ParcelTrack;V1.0.0.0;component/business%20layer/parcel%20track.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Business layer\Parcel Track.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\..\Business layer\Parcel Track.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_ShowAllCouriers);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\..\..\Business layer\Parcel Track.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_AddParcelOrCourier);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\..\..\Business layer\Parcel Track.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_TransferParcel);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 17 "..\..\..\..\Business layer\Parcel Track.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_SaveExit);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtbox_output = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btn_displayDelivery = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\Business layer\Parcel Track.xaml"
            this.btn_displayDelivery.Click += new System.Windows.RoutedEventHandler(this.btn_DisplayDelivery);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtbox_courierDetails = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtbox_targetID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtbox_destinationID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtbox_parcelTransferID = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

