﻿#pragma checksum "C:\Users\Santos Vega\Documents\GitHub\GastroCloudAdminApp\GastroCloud\Views\Grupo\Personalizado\ItemDetailRecipeView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "86EE563B4F0C0D8941EB564950607A58"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GastroCloud.Views.Grupo.Personalizado
{
    partial class ItemDetailRecipeView : 
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
                    this.guardar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 87 "..\..\..\..\..\Views\Grupo\Personalizado\ItemDetailRecipeView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.guardar).Click += this.guardar_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.cancelar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 88 "..\..\..\..\..\Views\Grupo\Personalizado\ItemDetailRecipeView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancelar).Click += this.guardar_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.txtCantidad = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
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

