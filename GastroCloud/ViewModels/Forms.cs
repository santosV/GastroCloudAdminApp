using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GastroCloud.Binding;

namespace GastroCloud.ViewModels
{
    public class Forms
    {
        static List<Form> campos = new List<Form>();

        public List<Form> form
        {
            get
            {
                
                return campos;
            }
        }

        public void setTextBox(List<Form> textBoxList)
        {
            campos = textBoxList;
        }


    }
}
