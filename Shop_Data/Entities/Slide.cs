﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Data.Enums;

namespace Shop_Data.Entities
{
    public class Slide
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
        public Status Status { get; set; }
    }
}
