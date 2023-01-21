using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class MealContent
    {
        public MealContent()
        {
            CreatedDate = DateTime.Now;
        }

        public int? MealId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public int? TotalCalorie
        {
            get
            {
                return Product.Calorie * Quantity;
            }
        }
        public DateTime? CreatedDate { get; protected set; }
        public DateTime? ModifiedDate { get; set; }

        // Navigation Properties
        public Meal? Meal { get; set; }
        public Product? Product { get; set; }
    }
}
