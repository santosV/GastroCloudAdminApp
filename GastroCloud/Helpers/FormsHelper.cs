using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GastroCloud.Binding;

namespace GastroCloud.Helpers
{
    class FormsHelper
    {

        public List<Form> formGroup
        {
            get
            {

                List<Form> textBoxes = new List<Form>();
                textBoxes.Add(new Form() { atributo = "nombre", descripcion = "Nombre de grupo" });
                return textBoxes;
            }
        }

        public List<Form> formStorage
        {
            get
            {

                List<Form> textBoxes = new List<Form>();
                textBoxes.Add(new Form() { atributo = "nombre", descripcion = "Nombre de almacén" });
                return textBoxes;
            }
        }

        public List<Form> formAreas
        {
            get
            {
                List<Form> textBoxes = new List<Form>();
                textBoxes.Add(new Form() { atributo = "nombre", descripcion = "Nombre de área" });
                return textBoxes;
            }
        }

        public List<Form> formDescount
        {
            get
            {
                List<Form> textBoxes = new List<Form>();
                textBoxes.Add(new Form() { atributo = "descuento", descripcion = "Cantidad de descuento" });
                return textBoxes;
            }
        }

        public List<Form> formEmployee
        {
            get
            {
                List<Form> textBoxes = new List<Form>();
                textBoxes.Add(new Form() { atributo = "nombre", descripcion = "Nombre" });
                textBoxes.Add(new Form() { atributo = "apellidos", descripcion = "Apellidos" });
                return textBoxes;
            }
        }

        public List<Form> formExtras
        {
            get
            {
                List<Form> textBoxes = new List<Form>();
                textBoxes.Add(new Form() { atributo = "descripcion", descripcion = "Nombre del extra" });
                textBoxes.Add(new Form() { atributo = "costo", descripcion = "Costo en extra" });

                return textBoxes;
            }
        }

        public List<Form> formMesas
        {
            get
            {
                List<Form> textBoxes = new List<Form>();
                textBoxes.Add(new Form() { atributo = "numMesa", descripcion = "Número de mesa" });
                textBoxes.Add(new Form() { atributo = "capacidad", descripcion = "Capacidad" });

                return textBoxes;
            }
        }

        public List<Form> formPaquete
        {
            get
            {
                List<Form> textBoxes = new List<Form>();
                textBoxes.Add(new Form() { atributo = "nombre", descripcion = "Descripción" });
                textBoxes.Add(new Form() { atributo = "precio", descripcion = "Precio" });
                textBoxes.Add(new Form() { atributo = "numProductos", descripcion = "Productos permitidos" });

                return textBoxes;
            }
        }

        public List<Form> formProducto
        {
            get
            {
                List<Form> textBoxes = new List<Form>();
                textBoxes.Add(new Form() { atributo = "nombre", descripcion = "Descripción" });
                textBoxes.Add(new Form() { atributo = "precio", descripcion = "Precio" });
                return textBoxes;
            }
        }
    }
}
