using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Descuento
    {
        public int id { get; set; }
        public double descuento { get; set; }
        public int tipo { get; set; }

        public List<Descuento> getDescuento()
        {
            List<Descuento> desc = new List<Descuento>();

            desc.Add(new Descuento { id = 1, descuento = 20.00, tipo = 1 });
            desc.Add(new Descuento { id = 2, descuento = 25.00, tipo = 1 });
            desc.Add(new Descuento { id = 3, descuento = 30.00, tipo = 2 });
            desc.Add(new Descuento { id = 4, descuento = 25.00, tipo = 1 });
            desc.Add(new Descuento { id = 5, descuento = 250.00, tipo = 2 });

            return desc;
        }

    }


}
