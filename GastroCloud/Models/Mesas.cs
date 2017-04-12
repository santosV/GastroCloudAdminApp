using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Mesas
    {
        public int id { get; set; }
        public int numMesa { get; set; }
        public int capacidad { get; set; }
        public int grupoId { get; set; }

        public List<Mesas> getDescuento()
        {
            List<Mesas> desc = new List<Mesas>();

            desc.Add(new Mesas { id = 1, numMesa = 2, capacidad = 4, grupoId = 2 });
            desc.Add(new Mesas { id = 2, numMesa = 2, capacidad = 4, grupoId = 2 });
            desc.Add(new Mesas { id = 3, numMesa = 2, capacidad = 4, grupoId = 2 });
            desc.Add(new Mesas { id = 4, numMesa = 2, capacidad = 4, grupoId = 2 });
            desc.Add(new Mesas { id = 5, numMesa = 2, capacidad = 4, grupoId = 2 });


            return desc;
        }
    }

}
