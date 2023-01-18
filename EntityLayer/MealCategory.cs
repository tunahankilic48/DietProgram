using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class MealCategory : BaseClass
    {
        public MealCategory()
        {
            Meals= new List<Meal>();
        }
        public string? Name { get; set; }

        // Navigation Properties
        public List<Meal>? Meals { get; set; }
    }
}
