using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.GridResizable
{
    public class OptionsViewModel : BindableBase
    {
        static List<Options> results = new List<Options>();
        static String number = "1";
        public List<Options> options
        {
            get
            {
                return results;
            }
        }

        public string MaximumRowsOrColumns
        {
            get
            {
                return number;
            }

            set { }
        }

        private Options selectedOption;

        public void setOption(List<Options> opciones)
        {
            results = opciones;
        }

        public Options SelectedOption
        {
            get { return selectedOption; }
            set { this.SetProperty(ref selectedOption, value); }
        }
    }
}
