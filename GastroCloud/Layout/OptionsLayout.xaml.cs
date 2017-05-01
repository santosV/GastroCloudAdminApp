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

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace GastroCloud.Layout
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class OptionsLayout : Page
    {
        public OptionsLayout()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            GridResizable.OptionsViewModel option = new GridResizable.OptionsViewModel();
            Helpers.OptionHelper opcion = new Helpers.OptionHelper();

            var parameter = e.Parameter as String;
            switch (parameter)
            {
                case "Group":
                    option.setOption(opcion.optionsGroup);
                    break;
                case "Supplies":
                    option.setOption(opcion.optionsSupplies);
                    break;
                case "Storage":
                    option.setOption(opcion.optionsStorage);
                    break;
                case "Product":
                    option.setOption(opcion.optionsProducts);
                    break;
                case "Purchase":
                    option.setOption(opcion.optionsPurchases);
                    break;
                default:
                    break;
            }

            //option.setItemSize(calculateItemSize());
            //option.setMaximumRowsOrColums("1");




        }

        //private double calculateItemSize()
        //{
        //    //double result=((Helpers.Global.width+Helpers.Global.height)*150)/1800;
        //    //return result;
        //}

        private void Grid_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Grid gridOptions = sender as Grid;
            String option = gridOptions.Tag.ToString();
            switch (option)
            {
                case "GrupoMesa":
                    this.Frame.Navigate(typeof(Views.Grupo.IndexGrupo));
                    break;
                case "GrupoInsumo":
                    this.Frame.Navigate(typeof(Views.Grupo.IndexGrupo));
                    break;
                case "GrupoPromocion":
                    this.Frame.Navigate(typeof(Views.Grupo.IndexGrupo));
                    break;
                case "GrupoICompuesto":
                    this.Frame.Navigate(typeof(Views.Grupo.IndexGrupo));
                    break;
                case "GrupoProducto":
                    this.Frame.Navigate(typeof(Views.Grupo.IndexGrupo));
                    break;
                case "GrupoPaquete":
                    this.Frame.Navigate(typeof(Views.Grupo.IndexGrupo));
                    break;
                case "GrupoPPersonalizado":
                    this.Frame.Navigate(typeof(Views.Grupo.Personalizado.CustomGroup));
                    break;
                case "Almacen":
                    this.Frame.Navigate(typeof(Views.Almacen.IndexAlmacen));
                    break;
                case "Entrada":
                    this.Frame.Navigate(typeof(Views.Almacen.Movimientos.MovementView),1);
                    break;
                case "Salida":
                    this.Frame.Navigate(typeof(Views.Almacen.Movimientos.MovementView),0);
                    break;
                case "Traspaso":
                    this.Frame.Navigate(typeof(Views.Almacen.Movimientos.MovementView),2);
                    break;
                case "Promocion":
                    this.Frame.Navigate(typeof(Views.Promocion.IndexPromocion));
                    break;
                case "Paquete":
                    this.Frame.Navigate(typeof(Views.Paquete.IndexPaquetes));
                    break;
                case "Producto":
                    this.Frame.Navigate(typeof(Views.Producto.IndexProductos));
                    break;
                case "Insumo":
                    this.Frame.Navigate(typeof(Views.Insumo.IndexInsumos));
                    break;
                case "ICompuesto":
                    this.Frame.Navigate(typeof(Views.Insumo.IndexInsumos));
                    break;

                default:
                    break;
            }

        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //Helpers.Global.width = e.NewSize.Width;
            //Helpers.Global.height = e.NewSize.Height;
        }
    }
}
