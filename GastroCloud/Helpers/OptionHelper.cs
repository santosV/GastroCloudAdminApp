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

                results.Add(new Options() { Name = "Mesas", Height = 1, Width = 2, ImagePath = @"/Assets/LOGO.png", Icon = "" });
                results.Add(new Options() { Name = "Insumos", Height = 2, Width = 2, ImagePath = @"/Assets/LOGO.png", Icon = "" });
                results.Add(new Options() { Name = "Promociones", Height = 1, Width = 3, ImagePath = @"/Assets/LOGO.png", Icon = "" });
                results.Add(new Options() { Name = "Ingredientes compuestos", Height = 2, Width = 3, ImagePath = @"/Assets/LOGO.png", Icon = "" });
                results.Add(new Options() { Name = "Productos", Height = 2, Width = 3, ImagePath = @"/Assets/LOGO.png", Icon = "" });
                results.Add(new Options() { Name = "Paquetes", Height = 1, Width = 3, ImagePath = @"/Assets/LOGO.png", Icon = "" });

                return results;
            }
        }

        public List<Options> optionsStorage
        {
            get
            {
                List<Options> results = new List<Options>();

                results.Add(new Options() { Name = "Almacenes", Height = 3, Width = 3, ImagePath = @"/Assets/LOGO.png", Icon = "" });
                results.Add(new Options() { Name = "Entrada de Almacen", Height = 1, Width = 2, ImagePath = @"/Assets/LOGO.png", Icon = "" });
                results.Add(new Options() { Name = "Salida de Almacen", Height = 2, Width = 2, ImagePath = @"/Assets/LOGO.png", Icon = "" });
                results.Add(new Options() { Name = "Traspaso de Almacen", Height = 3, Width = 3, ImagePath = @"/Assets/LOGO.png", Icon = "" });


                return results;
            }
        }


        public List<Options> optionsProducts
        {
            get
            {
                List<Options> results = new List<Options>();

                results.Add(new Options() { Name = "Promociones", Height = 1, Width = 8, ImagePath = @"/Assets/LOGO.png", Icon = "" });
                results.Add(new Options() { Name = "Paquetes", Height = 2, Width = 4, ImagePath = @"/Assets/LOGO.png", Icon = "" });
                results.Add(new Options() { Name = "Productos", Height = 2, Width = 4, ImagePath = @"/Assets/LOGO.png", Icon = "" });


                return results;
            }
        }

        public List<Options> optionsSupplies
        {
            get
            {
                List<Options> results = new List<Options>();

                results.Add(new Options() { Name = "Insumos", Height = 3, Width = 4, ImagePath = @"/Assets/LOGO.png", Icon = "" });
                results.Add(new Options() { Name = "Ingredientes Compuestos", Height = 3, Width = 4, ImagePath = @"/Assets/LOGO.png", Icon = "" });

                return results;
            }
        }

        public List<Options> optionsPurchases
        {
            get
            {
                List<Options> results = new List<Options>();

                results.Add(new Options() { Name = "Promociones", Height = 3, Width = 3, ImagePath = @"/Assets/LOGO.png", Icon = "" });
                results.Add(new Options() { Name = "Paquetes", Height = 3, Width = 3, ImagePath = @"/Assets/LOGO.png", Icon = "" });
                results.Add(new Options() { Name = "Productos", Height = 2, Width = 6, ImagePath = @"/Assets/LOGO.png", Icon = "" });


                return results;
            }
        }

    }
}
