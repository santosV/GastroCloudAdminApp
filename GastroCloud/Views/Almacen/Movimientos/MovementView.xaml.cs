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

namespace GastroCloud.Views.Almacen.Movimientos
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MovementView : Page
    {
        public MovementView()
        {
            this.InitializeComponent();
            GastroCloud.Models.Almacen almacen = new Models.Almacen();
            gridAlmacenS.ItemsSource = almacen.getDescuento();
            gridAlmacenE.ItemsSource = almacen.getDescuento();
            GastroCloud.Models.Insumo insumo = new Models.Insumo();
            gridInsumos.ItemsSource = insumo.getDescuento();

        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            int vista = Convert.ToInt32(e.Parameter);
            switch (vista)
            {
                case 0:
                    entradaView.Visibility = Visibility.Collapsed;
                    entradaTab.Visibility = Visibility.Collapsed;
                    presentacionTab.Tag = 1;
                    salidaTab.Tag = 0;
                    break;
                case 1:
                    salidaView.Visibility = Visibility.Collapsed;
                    salidaTab.Visibility = Visibility.Collapsed;
                    presentacionTab.Tag = 1;
                    entradaSalida = true;
                    inputIndicator.Visibility = Visibility.Visible;
                    break;
                default:
                    vistaM = false;
                    break;
            }
        }
        bool vistaM = true;
        bool entradaSalida = false;
        int permiso = 0;
        int recordador = 0;
        private void FlipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (permiso > 0)
            {
                outputIndicator.Visibility = Visibility.Collapsed;
                inputIndicator.Visibility = Visibility.Collapsed;
                presentationIndicator.Visibility = Visibility.Collapsed;
                int index = mainContent.SelectedIndex;
                if (vistaM)
                {
                    if (recordador < index)
                    {
                        index = index + 1;
                    }else
                    {
                        if (entradaSalida)
                        {
                            index = index + 1;
                        }
                    }

                }
                switch (index)
                {
                   
                    case 0:
                        outputIndicator.Visibility = Visibility.Visible;
                        break;
                    case 1:
                        inputIndicator.Visibility = Visibility.Visible;
                        break;
                    case 2:
                        presentationIndicator.Visibility = Visibility.Visible;
                        break;
                    default:
                        break;
                }

                recordador = mainContent.SelectedIndex;
            }
            permiso++;

        }

        private void indicator_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Grid indicatorClicked = sender as Grid;
            mainContent.SelectedIndex = Convert.ToInt32(indicatorClicked.Tag.ToString());
        }

        private void selection_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MovePresentationView));
        }
    }
}
