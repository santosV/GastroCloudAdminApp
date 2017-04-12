using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Paquete
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public byte[] imagen { get; set; }
        public double precio { get; set; }
        public double iva { get; set; }
        public int numeroProductos { get; set; }
        public int grupoId { get; set; }

        public List<Paquete> getDescuento()
        {
            List<Paquete> desc = new List<Paquete>();

            desc.Add(new Paquete { id = 1, imagen = ReadImageFile(), nombre = "Paquetellenes",precio = 90.00, iva = 12.00, numeroProductos =3,grupoId=2 });
            desc.Add(new Paquete { id = 2, imagen = ReadImageFile(), nombre = "Paquetellenes", precio = 90.00, iva = 12.00, numeroProductos = 3, grupoId = 2 });
            desc.Add(new Paquete { id = 3, imagen = ReadImageFile(), nombre = "Paquetellenes", precio = 90.00, iva = 12.00, numeroProductos = 3, grupoId = 2 });
            desc.Add(new Paquete { id = 4, imagen = ReadImageFile(), nombre = "Paquetellenes", precio = 90.00, iva = 12.00, numeroProductos = 3, grupoId = 2 });
            desc.Add(new Paquete { id = 5, imagen = ReadImageFile(), nombre = "Paquetellenes", precio = 90.00, iva = 12.00, numeroProductos = 3, grupoId = 2 });

            return desc;
        }

        public static byte[] ReadImageFile()
        {
            String imageLocation = @"/Assets/images.jpg";

            byte[] imageData = null;
            FileInfo fileInfo = new FileInfo(imageLocation);
            long imageFileLength = fileInfo.Length;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imageData = br.ReadBytes((int)imageFileLength);
            return imageData;
        }
    }
}
