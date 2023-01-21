using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Product : BaseClass
    {
        public Product()
        {
            MealContents = new List<MealContent>();
        }   
        public string? Name { get; set; }
        public int? Calorie { get; set; }
        public string? QuantityPerUnit { get; set; }
        public int ProductCategoryId { get; set; }
        public DateTime? ModifiedDate { get; set; }

        // Navigation Property
        public ProductCategory ProductCategory { get; set; }
        public List<MealContent> MealContents { get; set; }
    }
}
