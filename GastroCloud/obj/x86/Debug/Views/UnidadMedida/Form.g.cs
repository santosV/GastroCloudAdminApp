﻿#pragma checksum "C:\Users\Santos Vega\Documents\GitHub\GastroCloudAdminApp\GastroCloud\Views\UnidadMedida\Form.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9C061FCC1FD482825DC6F1678E520090"
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
                    this.txtNombre = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.btnC = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 39 "..\..\..\..\Views\UnidadMedida\Form.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.btnC).Click += this.btnCancelar_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnCar = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 4:
                {
                    this.title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

