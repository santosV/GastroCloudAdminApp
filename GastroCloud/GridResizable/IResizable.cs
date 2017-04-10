using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.GridResizable
{
    public interface IResizable
    {
        int Width { get; set; }
        int Height { get; set; }
    }
}
