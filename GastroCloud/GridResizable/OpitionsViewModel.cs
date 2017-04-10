using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastroCloud.GridResizable
{
    public class OptionsViewModel : BindableBase
    {
        public List<Options> options
        {
            get
            {
                List<Options> results = new List<Options>();

                results.Add(new Options() { Name = "Beer", Height = 1, Width = 1, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Hops", Height = 2, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Malt", Height = 1, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Water", Height = 1, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Yeast", Height = 1, Width = 1, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Sugar", Height = 2, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Herbs", Height = 2, Width = 1, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Beer", Height = 2, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Hops", Height = 1, Width = 1, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Malt", Height = 1, Width = 1, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Water", Height = 2, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Yeast", Height = 1, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Sugar", Height = 1, Width = 1, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Herbs", Height = 2, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Beer", Height = 1, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Hops", Height = 1, Width = 1, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Malt", Height = 2, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Water", Height = 1, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Sugar", Height = 1, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Yeast", Height = 2, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Herbs", Height = 2, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Yeast", Height = 1, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Sugar", Height = 1, Width = 1, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Herbs", Height = 2, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Beer", Height = 1, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Hops", Height = 1, Width = 1, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Malt", Height = 2, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Water", Height = 1, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                results.Add(new Options() { Name = "Sugar", Height = 1, Width = 2, ImagePath = @"/Assets/tellers_restaurant_and_bar__lawrence_kansas-wallpaper-2880x1800.jpg" });
                // And so on, and so forth ...

                return results;
            }
        }

        private Options selectedOption;

        public Options SelectedOption
        {
            get { return selectedOption; }
            set { this.SetProperty(ref selectedOption, value); }
        }
    }
}
