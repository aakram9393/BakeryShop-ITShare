using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryShop.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Describtion { get; set; }
        public decimal Price { get; set; }
        public string ImageName { get; set; }
    }
}
