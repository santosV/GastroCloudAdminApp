﻿#pragma checksum "C:\Users\Santos Vega\Documents\GitHub\GastroCloudAdminApp\GastroCloud\Views\UnidadMedida\Form.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "406A62D83CC619C0558BF16A56725668"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GastroCloud.Views.UnidadMedida
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
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.Grid element4 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 119 "..\..\..\..\Views\UnidadMedida\Form.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element4).PointerPressed += this.indicator_PointerPressed;
                    #line default
                }
                break;
            case 5:
                {
                    this.formIndicator = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 6:
                {
                    this.eliminar = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7:
                {
                    this.guardar = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 8:
                {
                    this.cancelar = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 9:
                {
                    this.txtNombre = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
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

