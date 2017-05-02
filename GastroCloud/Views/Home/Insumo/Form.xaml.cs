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

namespace GastroCloud.Views.Insumo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Form : Page
    {
        public Form()
        {
            this.InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Insumo.IndexInsumos));
        }

        private void indicator_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Grid indicatorClicked = sender as Grid;
            mainContent.SelectedIndex = Convert.ToInt32(indicatorClicked.Tag.ToString());
        }
    }
}
