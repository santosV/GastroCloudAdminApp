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

namespace GastroCloud.Views.PasoPersonalizado
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class FormPersonalizado : Page
    {
        int permiso = 0;

        public FormPersonalizado()
        {
            this.InitializeComponent();

            GastroCloud.Models.Extra extra = new Models.Extra();
            GastroCloud.Models.Insumo insumo = new Models.Insumo();
            ListaInsumos.ItemsSource = insumo.getDescuento();
            ListExtras.ItemsSource = extra.getDescuento();

        }

        private void chkExtras_Click(object sender, RoutedEventArgs e)
        {
            var chk = e.OriginalSource as CheckBox;

           

            if ((bool)chk.IsChecked)
            {

                stackExtras.Visibility = Visibility.Visible;
            }
            else
            {
                stackExtras.Visibility = Visibility.Collapsed;
            }
        }
    }
}
