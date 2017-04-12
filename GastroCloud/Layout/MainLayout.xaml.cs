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

namespace GastroCloud.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainLayout : Page
    {
        public MainLayout()
        {
            this.InitializeComponent();

            btnHome_Click(null,null);
            
        }

      

        private void btnHeaderNav_Click(object sender, RoutedEventArgs e)
        {
            HeaderNav.IsPaneOpen = !HeaderNav.IsPaneOpen;
        }

        private void View_BackRequested(object sender, Windows.UI.Core.BackRequestedEventArgs e)
        {
            //if (contentFrame.CanGoBack)
            //{
            //    e.Handled = true;
            //    contentFrame.GoBack();
            //}
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnHome.Content.ToString();
            headerIcon.Text = btnHome.Tag.ToString();
            MainFrame.Navigate(typeof(Views.Promocion.Form));
        }

        private void btnGrupos_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnGrupos.Content.ToString();
            headerIcon.Text = btnGrupos.Tag.ToString();
            MainFrame.Navigate(typeof(Layout.OptionsLayout),"Group");
        }

        private void btnAlmacenes_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnAlmacenes.Content.ToString();
            headerIcon.Text = btnAlmacenes.Tag.ToString();
            MainFrame.Navigate(typeof(Layout.OptionsLayout), "Storage");
        }

        private void btnInsumos_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnInsumos.Content.ToString();
            headerIcon.Text = btnInsumos.Tag.ToString();
            MainFrame.Navigate(typeof(Layout.OptionsLayout), "Supplies");
        }

        private void btnProveedores_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnProveedores.Content.ToString();
            headerIcon.Text = btnProveedores.Tag.ToString();
        }

        private void btnPresentaciones_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnPresentaciones.Content.ToString();
            headerIcon.Text = btnPresentaciones.Tag.ToString();
        }

        private void btnProductos_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnProductos.Content.ToString();
            headerIcon.Text = btnProductos.Tag.ToString();
            MainFrame.Navigate(typeof(Layout.OptionsLayout), "Product");
        }

        private void btnCompras_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnCompras.Content.ToString();
            headerIcon.Text = btnCompras.Tag.ToString();
            MainFrame.Navigate(typeof(Layout.OptionsLayout), "Purchase");
        }

        private void btnReportes_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnReportes.Content.ToString();
            headerIcon.Text = btnReportes.Tag.ToString();
        }
    }
}
