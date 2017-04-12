using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Area
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int tipo { get; set; }

        public List<Area> getDescuento()
        {
            List<Area> desc = new List<Area>();

            desc.Add(new Area { id = 1,nombre = "Bar", tipo = 1 });
            desc.Add(new Area { id = 2, nombre = "Barra", tipo = 2 });
            desc.Add(new Area { id = 3, nombre = "Web", tipo = 2 });
            desc.Add(new Area { id = 4, nombre = "Cocina", tipo = 1 });
            desc.Add(new Area { id = 5, nombre = "Almacen", tipo = 2 });
            return desc;
        }
    }
}
