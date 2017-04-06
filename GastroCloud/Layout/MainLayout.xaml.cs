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
        }

        private void btnHeaderNav_Click(object sender, RoutedEventArgs e)
        {
            HeaderNav.IsPaneOpen = !HeaderNav.IsPaneOpen;
        }

        private void View_BackRequested(object sender, Windows.UI.Core.BackRequestedEventArgs e)
        {
            if (contentFrame.CanGoBack)
            {
                e.Handled = true;
                contentFrame.GoBack();
            }
        }
    }
}
