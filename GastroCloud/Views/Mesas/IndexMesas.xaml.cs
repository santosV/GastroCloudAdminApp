using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GastroCloud.Views.Mesas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class IndexMesas : Page
    {
        public IndexMesas()
        {
            this.InitializeComponent();
            GastroCloud.Models.Mesas mesa = new Models.Mesas();
            gridMesas.ItemsSource = mesa.getDescuento();
        }
        private void btnIndexSelection(object sender, PointerRoutedEventArgs e)
        {
            Grid gridClicked = sender as Grid;
            MessageDialog msj = new MessageDialog("Se manda el id: " + gridClicked.Tag.ToString());
            msj.ShowAsync();
            this.Frame.Navigate(typeof(Views.Mesas.Form));

        }

        private void StackPanel_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Mesas.Form));
        }


        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Mesas.Form));
        }
    }
}
