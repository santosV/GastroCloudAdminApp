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
using GastroCloud.Models;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GastroCloud.Views.Area
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Index : Page
    {
        public Index()
        {
            this.InitializeComponent();
            GastroCloud.Models.Area area = new Models.Area();
            gridAreas.ItemsSource = area.getDescuento();
        }

        private void btnIndexSelection(object sender, PointerRoutedEventArgs e)
        {
            Grid gridClicked = sender as Grid;
            MessageDialog msj = new MessageDialog("Se manda el id: " + gridClicked.Tag.ToString());
            msj.ShowAsync();
            this.Frame.Navigate(typeof(Views.Area.Form));

        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Area.Form));
        }
    }
}
