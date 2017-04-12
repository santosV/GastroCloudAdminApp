using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Insumo
    {
        public int id { get; set; }
        public double costo { get; set; }
        public bool iva { get; set; }
        public double rendimiento { get; set; }
        public string descripcion { get; set; }
        public int unidadId { get; set; }
        public double minimo { get; set; }
        public double maximo { get; set; }
        public int tipo { get; set; }
        public int grupoId { get; set; }

        public List<Insumo> getDescuento()
        {
            List<Insumo> desc = new List<Insumo>();

            desc.Add(new Insumo { id = 1, descripcion = "Pepino", costo = 10.00, iva = true, grupoId = 2, rendimiento = 2.00, unidadId = 2, minimo = 10, maximo = 100, tipo = 1, });
            desc.Add(new Insumo { id = 2, descripcion = "Pepino", costo = 10.00, iva = true, grupoId = 2, rendimiento = 2.00, unidadId = 2, minimo = 10, maximo = 100, tipo = 1, });
            desc.Add(new Insumo { id = 3, descripcion = "Pepino", costo = 10.00, iva = true, grupoId = 2, rendimiento = 2.00, unidadId = 2, minimo = 10, maximo = 100, tipo = 1, });
            desc.Add(new Insumo { id = 4, descripcion = "Pepino", costo = 10.00, iva = true, grupoId = 2, rendimiento = 2.00, unidadId = 2, minimo = 10, maximo = 100, tipo = 1, });
            desc.Add(new Insumo { id = 5, descripcion = "Pepino", costo = 10.00, iva = true, grupoId = 2, rendimiento = 2.00, unidadId = 2, minimo = 10, maximo = 100, tipo = 1, });

            return desc;
        }

    }
}
