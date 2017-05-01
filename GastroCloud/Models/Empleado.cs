using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Empleado
    {
        public int id { get; set; }
        public byte[] imagen { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string  correo { get; set; }
        public string contraseña { get; set; }
        public int puestoId { get; set; }

        public List<Empleado> getDescuento()
        {
            List<Empleado> desc = new List<Empleado>();

            desc.Add(new Empleado { id = 1, nombre = "Santos", apellidos="Vega Arellano",correo="Hjasdja@hdahshd.com",contraseña="123",puestoId=1 });
            desc.Add(new Empleado { id = 2,  nombre = "Santos", apellidos = "Vega Arellano", correo = "Hjasdja@hdahshd.com", contraseña = "123", puestoId = 1 });
            desc.Add(new Empleado { id = 3,  nombre = "Santos", apellidos = "Vega Arellano", correo = "Hjasdja@hdahshd.com", contraseña = "123", puestoId = 1 });
            desc.Add(new Empleado { id = 4,  nombre = "Santos", apellidos = "Vega Arellano", correo = "Hjasdja@hdahshd.com", contraseña = "123", puestoId = 1 });
            desc.Add(new Empleado { id = 5,  nombre = "Santos", apellidos = "Vega Arellano", correo = "Hjasdja@hdahshd.com", contraseña = "123", puestoId = 1 });

            return desc;
        }

        public async Task<byte[]> ReadImageFile( )
        {
            String imageLocation = "ms-appx:///Assets/images.jpg";

            byte[] imageData = null;
            FileInfo fileInfo = new FileInfo(@"C:/Users/Santos Vega/Desktop/santos.jpg");
            long imageFileLength = fileInfo.Length;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imageData = br.ReadBytes((int)imageFileLength);
            return imageData;
        }
    }
}
