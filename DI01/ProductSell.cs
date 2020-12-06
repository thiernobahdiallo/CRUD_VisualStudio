using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI01
{
    public class ProductSell
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string sellStartDate { get; set; }

        public string sellEndDate { get; set; }
        public override string ToString()
        {
            return $"{Name} -- {Description} -- {sellStartDate} -- {sellEndDate}";
        }
    }
}
