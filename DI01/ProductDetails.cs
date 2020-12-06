using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI01
{
    public class ProductDetails
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public string ListPrice { get; set; }
        public string Size { get; set; }
        public string ProductLine{ get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        

        public override string ToString()
        {
            return $"{Name} -- {Description} -- {ProductNumber} -- {Color} -- {ListPrice} --" +
                $" {Size} -- {ProductLine} -- {Class} -- {Style} -- {Category} -- {SubCategory} ";
        }
    }
}
