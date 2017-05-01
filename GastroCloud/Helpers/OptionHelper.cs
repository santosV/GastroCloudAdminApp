using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GastroCloud.GridResizable;
namespace GastroCloud.Helpers
{
    class OptionHelper
    {
        public List<Options> optionsGroup
        {
            get
            {
                List<Options> results = new List<Options>();

                results.Add(new Options() { Name = "Mesas", Height = 0, Width = 2, ImagePath = "https://source.unsplash.com/collection/778907", Icon = "", Tag = "GrupoMesa" });
                results.Add(new Options() { Name = "Insumos", Height = 2, Width = 2, ImagePath = "https://source.unsplash.com/collection/778920", Icon = "", Tag = "GrupoInsumo" });
                results.Add(new Options() { Name = "Promociones", Height = 1, Width = 3, ImagePath = "https://source.unsplash.com/collection/779034", Icon = "", Tag = "GrupoPromocion" });
                results.Add(new Options() { Name = "Ingredientes compuestos", Height = 2, Width = 3, ImagePath = "https://source.unsplash.com/collection/779043", Icon = "", Tag = "GrupoICompuesto" });
                results.Add(new Options() { Name = "Productos", Height = 1, Width = 2, ImagePath = "https://source.unsplash.com/collection/778940", Icon = "", Tag = "GrupoProducto" });
                results.Add(new Options() { Name = "Producto Personalizado", Height = 2, Width = 2, ImagePath = "https://source.unsplash.com/collection/779021", Icon = "", Tag = "GrupoPPersonalizado" });
                results.Add(new Options() { Name = "Paquetes", Height = 3, Width = 1, ImagePath = "https://source.unsplash.com/collection/779062", Icon = "", Tag = "GrupoPaquete" });
                return results;
            }
        }

        public List<Options> optionsStorage
        {
            get
            {
                List<Options> results = new List<Options>();

                results.Add(new Options() { Name = "Almacenes", Height = 3, Width = 3, ImagePath = "https://source.unsplash.com/collection/781608", Icon = "",Tag="Almacen" });
                results.Add(new Options() { Name = "Entrada de Almacen", Height = 1, Width = 2, ImagePath = "https://source.unsplash.com/collection/781608", Icon = "",Tag="Entrada" });
                results.Add(new Options() { Name = "Salida de Almacen", Height = 2, Width = 2, ImagePath = "https://source.unsplash.com/collection/781608", Icon = "",Tag="Salida" });
                results.Add(new Options() { Name = "Traspaso de Almacen", Height = 3, Width = 3, ImagePath = "https://source.unsplash.com/collection/781608", Icon = "" ,Tag="Traspaso"});


                return results;
            }
        }


        public List<Options> optionsProducts
        {
            get
            {
                List<Options> results = new List<Options>();

                results.Add(new Options() { Name = "Promociones", Height = 1, Width = 4, ImagePath = "https://source.unsplash.com/collection/779034", Icon = "",Tag="Promocion" });
                results.Add(new Options() { Name = "Paquetes", Height = 2, Width = 4, ImagePath = "https://source.unsplash.com/collection/779062", Icon = "",Tag="Paquete" });
                results.Add(new Options() { Name = "Productos", Height = 2, Width = 4, ImagePath = "https://source.unsplash.com/collection/778940", Icon = "",Tag="Producto" });
                results.Add(new Options() { Name = "Productos Personalizados", Height = 1, Width = 4, ImagePath = "https://source.unsplash.com/collection/779021", Icon = "", Tag = "PPersonalizado" });


                return results;
            }
        }

        public List<Options> optionsSupplies
        {
            get
            {
                List<Options> results = new List<Options>();

                results.Add(new Options() { Name = "Insumos", Height = 3, Width = 4, ImagePath = "https://source.unsplash.com/collection/778920", Icon = "",Tag="Insumo" });
                results.Add(new Options() { Name = "Ingredientes Compuestos", Height = 3, Width = 4, ImagePath = "https://source.unsplash.com/collection/779043", Icon = "", Tag = "ICompuesto" });
                results.Add(new Options() { Name = "Ingredientes Extras", Height = 3, Width = 4, ImagePath = "https://source.unsplash.com/collection/783629", Icon = "", Tag = "ICompuesto" });

                return results;
            }
        }

        public List<Options> optionsPurchases
        {
            get
            {
                List<Options> results = new List<Options>();

                results.Add(new Options() { Name = "Promociones", Height = 3, Width = 3, ImagePath = "https://source.unsplash.com/collection/779034", Icon = "" });
                results.Add(new Options() { Name = "Paquetes", Height = 3, Width = 3, ImagePath = "https://source.unsplash.com/collection/779062", Icon = "" });
                results.Add(new Options() { Name = "Productos", Height = 2, Width = 6, ImagePath = "https://source.unsplash.com/collection/778940", Icon = "" });
                return results;
            }
        }

        public List<Options> optionsAreas
        {
            get
            {
                List<Options> results = new List<Options>();

                results.Add(new Options() { Name = "Areas de Disponibilidad", Height = 3, Width = 4, ImagePath = "https://source.unsplash.com/collection/783922", Icon = "", Tag = "AreaDisponibilidad" });
                results.Add(new Options() { Name = "Areas de Preparacion", Height = 3, Width = 4, ImagePath = "https://source.unsplash.com/collection/783919", Icon = "", Tag = "AreaPreparacion" });

                return results;
            }
        }

    }
}
