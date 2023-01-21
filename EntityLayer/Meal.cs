using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Meal : BaseClass
    {
        public Meal()
        {
            CreatedDate = DateTime.Now;
            MealContents = new List<MealContent>();
        }
        public int? UserId { get; set; }
        public int? MealCategoryId { get; set; }
        public DateTime? MealDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        // Navigation Properties
        public AppUser? User { get; set; }
        public MealCategory? MealCategory { get; set; }
        public List<MealContent> MealContents { get; set; }
    }
}
