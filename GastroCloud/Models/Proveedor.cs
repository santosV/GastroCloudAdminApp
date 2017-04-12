using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Proveedor
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string razonSocial { get; set; }
        public string rfc { get; set; }
        public string calle { get; set; }
        public string noExterior { get; set; }
        public string codigoPostal { get; set; }
        public string colonia { get; set; }
        public string localidad { get; set; }
        public string municipio { get; set; }
        public string estado { get; set; }
        public string pais { get; set; }
        public string telefono { get; set; }
        public DateTime fecha { get; set; }
        public string sucursal { get; set; }
        public int sucursalId { get; set; }

        public List<Proveedor> getDescuento()
        {
            List<Proveedor> desc = new List<Proveedor>();

            desc.Add(new Proveedor { id = 1, nombre = "Juan Tenorio", razonSocial = "asdggf", rfc = "ABSBDA!12312SADB" });
            desc.Add(new Proveedor { id = 2, nombre = "Juan Tenorio", razonSocial = "asdggf", rfc = "ABSBDA!12312SADB" });
            desc.Add(new Proveedor { id = 3, nombre = "Juan Tenorio", razonSocial = "asdggf", rfc = "ABSBDA!12312SADB" });
            desc.Add(new Proveedor { id = 4, nombre = "Juan Tenorio", razonSocial = "asdggf", rfc = "ABSBDA!12312SADB" });
            desc.Add(new Proveedor { id = 5, nombre = "Juan Tenorio", razonSocial = "asdggf", rfc = "ABSBDA!12312SADB" });


            return desc;
        }
    }
}
