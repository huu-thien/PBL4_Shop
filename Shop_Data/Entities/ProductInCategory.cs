using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Data.Entities
{
    public class ProductInCategory
    {
        public int Productid { get; set; }
        public Product Product { get; set; }
        public int Categoryid { get; set; } 
        public Category Category { get; set; }
    }
}
