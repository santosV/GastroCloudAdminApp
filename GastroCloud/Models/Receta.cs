using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Receta
    {
        public int id { get; set; }
        public int cantidad { get; set; }
        public int tipo { get; set; }
        public int insumoId { get; set; }
        public int productoId { get; set; }
        public int extraId { get; set; }
        public int insumoElaboradoId { get; set; }
        public bool paraLlevar { get; set; }

        public List<Receta> getDescuento()
        {
            List<Receta> desc = new List<Receta>();

            desc.Add(new Receta { id = 1, cantidad = 31, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 2, cantidad = 21, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 3, cantidad = 41, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 3, cantidad = 41, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 3, cantidad = 41, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 3, cantidad = 41, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 3, cantidad = 41, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 3, cantidad = 41, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });

            desc.Add(new Receta { id = 1, cantidad = 31, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 2, cantidad = 21, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 3, cantidad = 41, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 3, cantidad = 41, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 3, cantidad = 41, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 3, cantidad = 41, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 3, cantidad = 41, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 3, cantidad = 41, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 4, cantidad = 51, tipo = 2, extraId = 1 });
            desc.Add(new Receta { id = 5, cantidad = 61, tipo = 2, extraId = 1 });

            return desc;
        }
    }
}
