using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace GastroCloud.Layout
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class OptionsLayout : Page
    {
        public OptionsLayout()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            GridResizable.OptionsViewModel option = new GridResizable.OptionsViewModel();
            Helpers.OptionHelper opcion = new Helpers.OptionHelper();

            var parameter = e.Parameter as String;
            switch (parameter)
            {
                case "Group":
                    option.setOption(opcion.optionsGroup);
                    break;
                case "Supplies":
                    option.setOption(opcion.optionsSupplies);
                    break;
                case "Storage":
                    option.setOption(opcion.optionsStorage);
                    break;
                case "Product":
                    option.setOption(opcion.optionsProducts);
                    break;
                case "Purchase":
                    option.setOption(opcion.optionsPurchases);
                    break;
                default:
                    break;
            }
            
                
            
            



        }
    }
}
