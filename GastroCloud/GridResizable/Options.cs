using GastroCloud.GridResizable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace GastroCloud.GridResizable

{
    public class Options : IResizable
    {

        public string Name { get; set; }
        public string Icon { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public ImageSource Image
        {
            get
            {
                return new BitmapImage(new Uri("ms-appx://" + this.ImagePath));
            }
        }

    }
}
