﻿using System;
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

namespace GastroCloud.Views.Promocion
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class IndexPromocion : Page
    {
        public IndexPromocion()
        {
            this.InitializeComponent();
            GastroCloud.Models.Promocion promocion = new Models.Promocion();
            gridPromociones.ItemsSource = promocion.getDescuento();
        }
        private void btnIndexSelection(object sender, PointerRoutedEventArgs e)
        {
            Grid gridClicked = sender as Grid;
            MessageDialog msj = new MessageDialog("Se manda el id: " + gridClicked.Tag.ToString());
            msj.ShowAsync();
            this.Frame.Navigate(typeof(Views.Promocion.DetailsPromocion));

        }
        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Promocion.Form));
        }

        
    }
}