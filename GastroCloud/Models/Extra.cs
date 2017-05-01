using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Extra
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public double costo { get; set; }
        public double iva { get; set; }
        public byte[] imagen { get; set; }

        public List<Extra> getDescuento()
        {
            List<Extra> desc = new List<Extra>();

            desc.Add(new Extra { id = 1,  descripcion = "aderezo", costo = 15.00, iva = 10.00});
            desc.Add(new Extra { id = 2,  descripcion = "ketchup", costo = 5.00, iva = 18.00 });
            desc.Add(new Extra { id = 3,  descripcion = "mayonesa", costo = 23.00, iva = 28.00 });
            desc.Add(new Extra { id = 4,  descripcion = "pan", costo = 5.00, iva = 23.00 });
            desc.Add(new Extra { id = 5,  descripcion = "tomate", costo = 17.00, iva = 28.00 });

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
