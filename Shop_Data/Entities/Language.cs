using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Data.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public List<ProductTransaction> ProductTransactions { get; set; }
        public List<CategoryTransaction> CategoryTransactions { get; set; }
    }
}
