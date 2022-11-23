using Allup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> NewArrivals { get; set; }
        public IEnumerable<Product> BestSellers { get; set; }
        public IEnumerable<Product> Featured { get; set; }



    }
}
