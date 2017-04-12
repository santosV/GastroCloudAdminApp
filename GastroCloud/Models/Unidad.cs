using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Unidad
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public List<Unidad> getDescuento()
        {
            List<Unidad> desc = new List<Unidad>();

            desc.Add(new Unidad { id = 1, nombre = "Kilogramos" });
            desc.Add(new Unidad { id = 2, nombre = "Kilogramos" });
            desc.Add(new Unidad { id = 3, nombre = "Kilogramos" });
            desc.Add(new Unidad { id = 4, nombre = "Kilogramos" });
            desc.Add(new Unidad { id = 5, nombre = "Kilogramos" });

            return desc;
        }
    }

   

}
