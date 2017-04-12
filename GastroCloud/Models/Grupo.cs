using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Grupo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public byte[] imagen { get; set; }
        public int tipoId { get; set; }
        public bool custom { get; set; }

        public List<Grupo> getDescuento()
        {
            List<Grupo> desc = new List<Grupo>();

            desc.Add(new Grupo { id = 1, imagen = ReadImageFile(), nombre = "Hamburguesa", custom = false, tipoId = 2 });
            desc.Add(new Grupo { id = 2, imagen = ReadImageFile(), nombre = "Hamburguesa", custom = false, tipoId = 2 });
            desc.Add(new Grupo { id = 3, imagen = ReadImageFile(), nombre = "Hamburguesa", custom = false, tipoId = 2 });
            desc.Add(new Grupo { id = 4, imagen = ReadImageFile(), nombre = "Hamburguesa", custom = false, tipoId = 2 });
            desc.Add(new Grupo { id = 5, imagen = ReadImageFile(), nombre = "Hamburguesa", custom = false, tipoId = 2 });

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
