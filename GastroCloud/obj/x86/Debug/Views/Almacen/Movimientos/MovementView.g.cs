﻿#pragma checksum "C:\Users\Santos Vega\Documents\GitHub\GastroCloudAdminApp\GastroCloud\Views\Almacen\Movimientos\MovementView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BAF8C07D262416992D2CC54C0904D474"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GastroCloud.Views.Almacen.Movimientos
{
    partial class MovementView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.itemsViewSource = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 2:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 3:
                {
                    this.mainContent = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                    #line 54 "..\..\..\..\..\Views\Almacen\Movimientos\MovementView.xaml"
                    ((global::Windows.UI.Xaml.Controls.FlipView)this.mainContent).SelectionChanged += this.FlipView_SelectionChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.salidaTab = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 298 "..\..\..\..\..\Views\Almacen\Movimientos\MovementView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.salidaTab).PointerPressed += this.indicator_PointerPressed;
                    #line default
                }
                break;
            case 5:
                {
                    this.entradaTab = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 308 "..\..\..\..\..\Views\Almacen\Movimientos\MovementView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.entradaTab).PointerPressed += this.indicator_PointerPressed;
                    #line default
                }
                break;
            case 6:
                {
                    this.presentacionTab = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 318 "..\..\..\..\..\Views\Almacen\Movimientos\MovementView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.presentacionTab).PointerPressed += this.indicator_PointerPressed;
                    #line default
                }
                break;
            case 7:
                {
                    this.presentationIndicator = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 8:
                {
                    this.inputIndicator = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 9:
                {
                    this.outputIndicator = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 10:
                {
                    this.salidaView = (global::Windows.UI.Xaml.Controls.FlipViewItem)(target);
                }
                break;
            case 11:
                {
                    this.entradaView = (global::Windows.UI.Xaml.Controls.FlipViewItem)(target);
                }
                break;
            case 12:
                {
                    this.presentationView = (global::Windows.UI.Xaml.Controls.FlipViewItem)(target);
                }
                break;
            case 13:
                {
                    this.gridInsumos = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 14:
                {
                    global::Windows.UI.Xaml.Controls.Grid element14 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 243 "..\..\..\..\..\Views\Almacen\Movimientos\MovementView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element14).PointerPressed += this.selection_PointerPressed;
                    #line default
                }
                break;
            case 15:
                {
                    this.txtBuscadorP = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 16:
                {
                    this.gridAlmacenE = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 17:
                {
                    this.txtBuscadorAE = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 18:
                {
                    this.gridAlmacenS = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 19:
                {
                    this.txtBuscadorAS = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

