using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Product : BaseClass
    {
        public string? Name { get; set; }
        public int? Calorie { get; set; }
        public string? QuantityPerUnit { get; set; } // Fluent api

        // Navigation Property

        public List<MealContent> MealContents { get; set; }
    }
}
