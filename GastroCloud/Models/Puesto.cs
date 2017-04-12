using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Puesto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public double sueldo { get; set; }
        public int tipo { get; set; }

        public List<Puesto> getDescuento()
        {
            List<Puesto> desc = new List<Puesto>();

            desc.Add(new Puesto { id = 1, descripcion = "Gerente", sueldo = 120.00, tipo = 1 });
            desc.Add(new Puesto { id = 2, descripcion = "Gerente", sueldo = 120.00, tipo = 1 });
            desc.Add(new Puesto { id = 3, descripcion = "Gerente", sueldo = 120.00, tipo = 1 });
            desc.Add(new Puesto { id = 4, descripcion = "Gerente", sueldo = 120.00, tipo = 1 });
            desc.Add(new Puesto { id = 5, descripcion = "Gerente", sueldo = 120.00, tipo = 1 });

            return desc;
        }
    }
}
