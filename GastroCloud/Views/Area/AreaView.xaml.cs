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

namespace GastroCloud.Views.Area
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AreaView : Page
    {
        public AreaView()
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
            mainView.SelectedIndex = 1;

        }


        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            mainView.SelectedIndex = 0;
        }

        int cont = 0;
        private void mainView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cont > 0)
            {
                indexIndicator.Visibility = Visibility.Collapsed;
                formIndicator.Visibility = Visibility.Collapsed;
                switch (mainView.SelectedIndex)
                {
                    case 0:
                        indexIndicator.Visibility = Visibility.Visible;
                        break;
                    case 1:
                        formIndicator.Visibility = Visibility.Visible;
                        break;
                    default:
                        break;
                }
            }
            cont++;

        }

        private void btnViewSelector(object sender, PointerRoutedEventArgs e)
        {
            Grid gridClicked = sender as Grid;
            mainView.SelectedIndex = Convert.ToInt32(gridClicked.Tag.ToString());
        }
    }
}
