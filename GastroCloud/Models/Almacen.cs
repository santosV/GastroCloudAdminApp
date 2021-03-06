﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    public class Almacen
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public List<Almacen> getDescuento()
        {
            List<Almacen> desc = new List<Almacen>();

            desc.Add(new Almacen { id = 1, nombre = "Refrigerador"});
            desc.Add(new Almacen { id = 2, nombre = "Congelador" });
            desc.Add(new Almacen { id = 3, nombre = "General" });
            desc.Add(new Almacen { id = 4, nombre = "Siungarariunga" });
            desc.Add(new Almacen { id = 5, nombre = "BackYard Conge" });

            return desc;
        }

    }
}
