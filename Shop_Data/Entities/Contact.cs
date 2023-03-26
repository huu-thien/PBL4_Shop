using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Data.Enums;

namespace Shop_Data.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Email { get; set; }
        public int PhoneNumber { get; set; }
        public int Message { get; set; }
        public Status Status { get; set; }
    }
}
