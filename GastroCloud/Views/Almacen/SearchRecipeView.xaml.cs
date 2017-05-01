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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GastroCloud.Views.Almacen
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SearchRecipeView : Page
    {
        public SearchRecipeView()
        {
            this.InitializeComponent();
            GastroCloud.Models.Almacen almacen = new Models.Almacen();
            gridAlmacen.ItemsSource = almacen.getDescuento();
            txtBuscador.Focus(FocusState.Programmatic);
        }

        private void selection_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Almacen.ItemDetailRecipeView));
        }

        private void cancel(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Almacen.FormAlmacen), 1);
        }
    }
}
