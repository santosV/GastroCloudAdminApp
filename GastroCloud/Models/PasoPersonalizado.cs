using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    public class PasoPersonalizado
    {
        public int id { get; set; }
        public List<Insumo> listaInsumos { get; set; }

        public List<PasoPersonalizado> getDescuento()
        {
            List<PasoPersonalizado> desc = new List<PasoPersonalizado>();

            GastroCloud.Models.Insumo insumo = new Models.Insumo();
            

            desc.Add(new PasoPersonalizado { id = 1, listaInsumos = insumo.getDescuento() });
            desc.Add(new PasoPersonalizado { id = 2, listaInsumos = insumo.getDescuento() });
            desc.Add(new PasoPersonalizado { id = 3, listaInsumos = insumo.getDescuento() });
            desc.Add(new PasoPersonalizado { id = 4, listaInsumos = insumo.getDescuento() });
            desc.Add(new PasoPersonalizado { id = 5, listaInsumos = insumo.getDescuento() });
            return desc;
        }
    }
}
