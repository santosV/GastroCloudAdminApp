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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GastroCloud.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainLayout : Page
    {

        string status = "closed";
        public MainLayout()
        {
            this.InitializeComponent();

            btnHome_Click(null,null);
            MainFrame.Focus(FocusState.Programmatic);
        }

      

        

        private void View_BackRequested(object sender, Windows.UI.Core.BackRequestedEventArgs e)
        {
            //if (contentFrame.CanGoBack)
           
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnHome.Content.ToString();

            MainFrame.Navigate(typeof(Views.Grupo.Personalizado.FormPortion));
        }

        private void btnGrupos_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnGrupos.Content.ToString();

            MainFrame.Navigate(typeof(Layout.OptionsLayout),"Group");
        }

        private void btnAlmacenes_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnAlmacenes.Content.ToString();
            MainFrame.Navigate(typeof(Layout.OptionsLayout), "Storage");
        }

        private void btnInsumos_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnInsumos.Content.ToString();
            MainFrame.Navigate(typeof(Layout.OptionsLayout), "Supplies");
        }

        private void btnProveedores_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnProveedores.Content.ToString();
     
            MainFrame.Navigate(typeof(Views.Proveedor.IndexProveedor));
        }


        private void btnProductos_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnProductos.Content.ToString();

            MainFrame.Navigate(typeof(Layout.OptionsLayout), "Product");
        }

        private void btnCompras_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnCompras.Content.ToString();
           
        }

        private void btnReportes_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnReportes.Content.ToString();
        
        }

        private void btnExtras_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnDescuentos_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnDescuentos.Content.ToString();
         
            MainFrame.Navigate(typeof(Views.Descuento.Index));
        }

        private void btnPuestos_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnPuestos.Content.ToString();
            MainFrame.Navigate(typeof(Views.Puesto.IndexPuestos));
        }

        private void btnUMedida_Click(object sender, RoutedEventArgs e)
        {
            headerTitle.Text = btnUMedida.Content.ToString();
            MainFrame.Navigate(typeof(Views.UnidadMedida.Index));
        }


        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (status.Equals("closed"))
            {
                CloseHamburguer.Stop();
                OpenHamburguer.Stop();
                AnimationOpen.SetValue(Storyboard.TargetNameProperty, stackHmbgr.Name);
                OpenHamburguer.Begin();
                scroll.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
                status = "open";
            }
            else
            {
                AnimationClose.SetValue(Storyboard.TargetNameProperty, stackHmbgr.Name);
                CloseHamburguer.Begin();
                scroll.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
                status = "closed";
            }
        }

    }
}
