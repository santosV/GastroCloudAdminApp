using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public double iva { get; set; }
        public Byte[] imagen { get; set; }
        public int grupoId { get; set; }
        public bool custom { get; set; }
        public int usuarioId { get; set; }

        public List<Producto> getDescuento()
        {
            List<Producto> desc = new List<Producto>();

            desc.Add(new Producto { id = 1, imagen = ReadImageFile(), nombre = "Hamburguesa", precio = 50.00, iva = 12.00, custom = false, grupoId = 2 ,usuarioId=2});
            desc.Add(new Producto { id = 2, imagen = ReadImageFile(), nombre = "Hamburguesa", precio = 50.00, iva = 12.00, custom = false, grupoId = 2, usuarioId = 2 });
            desc.Add(new Producto { id = 3, imagen = ReadImageFile(), nombre = "Hamburguesa", precio = 50.00, iva = 12.00, custom = false, grupoId = 2, usuarioId = 2 });
            desc.Add(new Producto { id = 4, imagen = ReadImageFile(), nombre = "Hamburguesa", precio = 50.00, iva = 12.00, custom = false, grupoId = 2, usuarioId = 2 });
            desc.Add(new Producto { id = 5, imagen = ReadImageFile(), nombre = "Hamburguesa", precio = 50.00, iva = 12.00, custom = false, grupoId = 2, usuarioId = 2 });

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
