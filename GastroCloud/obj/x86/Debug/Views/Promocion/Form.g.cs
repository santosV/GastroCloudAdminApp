﻿#pragma checksum "C:\Users\Santos Vega\Documents\GitHub\GastroCloudAdminApp\GastroCloud\Views\Promocion\Form.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3549099C70261F55F63808F33E0BD66D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GastroCloud.Views.Promocion
{
    partial class Form : 
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
                    #line 52 "..\..\..\..\Views\Promocion\Form.xaml"
                    ((global::Windows.UI.Xaml.Controls.FlipView)this.mainContent).SelectionChanged += this.FlipView_SelectionChanged;
                    #line default
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.Grid element4 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 251 "..\..\..\..\Views\Promocion\Form.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element4).PointerPressed += this.indicator_PointerPressed;
                    #line default
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Grid element5 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 261 "..\..\..\..\Views\Promocion\Form.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element5).PointerPressed += this.indicator_PointerPressed;
                    #line default
                }
                break;
            case 6:
                {
                    this.recipeIndicator = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 7:
                {
                    this.formIndicator = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 8:
                {
                    this.gridAlmacen = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 9:
                {
                    this.txtBuscador = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 166 "..\..\..\..\Views\Promocion\Form.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtBuscador).GotFocus += this.txtBuscador_GotFocus;
                    #line default
                }
                break;
            case 10:
                {
                    this.eliminar = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 11:
                {
                    this.guardar = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 12:
                {
                    this.cancelar = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 13:
                {
                    this.chkExtraIVA = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 14:
                {
                    this.comboGrupo = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 15:
                {
                    this.a = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.dateA = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 17:
                {
                    this.de = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.dateDe = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 19:
                {
                    this.txtPrecio = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 20:
                {
                    this.txtNombre = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 21:
                {
                    this.imgAlmacen = (global::Windows.UI.Xaml.Controls.Image)(target);
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

