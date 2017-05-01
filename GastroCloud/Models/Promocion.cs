using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.Models
{
    class Promocion
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public byte[] imagen { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public TimeSpan horaInicio { get; set; }
        public TimeSpan horaFin { get; set; }
        public double precio { get; set; }
        public double iva { get; set; }
        public string diasDisponibles { get; set; }

        public List<Promocion> getDescuento()
        {
            List<Promocion> desc = new List<Promocion>();

            desc.Add(new Promocion { id = 1,  nombre = "3x2", fechaInicio = DateTime.Today, fechaFin = DateTime.Today, horaInicio = DateTime.Now.TimeOfDay, horaFin = DateTime.Now.TimeOfDay, precio = 90.00, iva = 12.00, diasDisponibles = "L;M;V" });
            desc.Add(new Promocion { id = 2,  nombre = "3x2", fechaInicio = DateTime.Today, fechaFin = DateTime.Today, horaInicio = DateTime.Now.TimeOfDay, horaFin = DateTime.Now.TimeOfDay, precio = 90.00, iva = 12.00, diasDisponibles = "L;M;V" });
            desc.Add(new Promocion { id = 3,  nombre = "3x2", fechaInicio = DateTime.Today, fechaFin = DateTime.Today, horaInicio = DateTime.Now.TimeOfDay, horaFin = DateTime.Now.TimeOfDay, precio = 90.00, iva = 12.00, diasDisponibles = "L;M;V" });
            desc.Add(new Promocion { id = 4,  nombre = "3x2", fechaInicio = DateTime.Today, fechaFin = DateTime.Today, horaInicio = DateTime.Now.TimeOfDay, horaFin = DateTime.Now.TimeOfDay, precio = 90.00, iva = 12.00, diasDisponibles = "L;M;V" });
            desc.Add(new Promocion { id = 5,  nombre = "3x2", fechaInicio = DateTime.Today, fechaFin = DateTime.Today, horaInicio = DateTime.Now.TimeOfDay, horaFin = DateTime.Now.TimeOfDay, precio = 90.00, iva = 12.00, diasDisponibles = "L;M;V" });

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
