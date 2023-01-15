﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class MealContent
    {
        public int? MealId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public int? TotalCalorie { get; set; }

        // Navigation Properties
        public Meal? Meal { get; set; }
        public Product? Product { get; set; }
    }
}
