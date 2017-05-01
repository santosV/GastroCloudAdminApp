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
    public sealed partial class FormAlmacen : Page
    {
        public FormAlmacen()
        {
            this.InitializeComponent();
            GastroCloud.Models.Almacen almacen = new Models.Almacen();
            gridAlmacen.ItemsSource = almacen.getDescuento();
        }

        int permiso = 0;
        private void FlipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (permiso > 0)
            {
                formIndicator.Visibility = Visibility.Collapsed;
                recipeIndicator.Visibility = Visibility.Collapsed;
                switch (mainContent.SelectedIndex)
                {
                    case 0:
                        formIndicator.Visibility = Visibility.Visible;
                        break;
                    case 1:
                        recipeIndicator.Visibility = Visibility.Visible;
                        break;
                    default:
                        break;
                }
            }
            permiso++;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            int indicator = Convert.ToInt32(e.Parameter);
            mainContent.SelectedIndex = indicator;
        }

        private void indicator_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Grid indicatorClicked = sender as Grid;
            mainContent.SelectedIndex = Convert.ToInt32(indicatorClicked.Tag.ToString());
        }

        private void txtBuscador_GotFocus(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Almacen.SearchRecipeView));
        }
    }
}
