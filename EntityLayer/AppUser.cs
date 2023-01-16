using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AppUser : BaseClass
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? Length { get; set; }
        public decimal? Weigth { get; set; }
        public DateTime? BirtDate { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsActive { get; set; }

        // Navigation Properties
        public List<Meal>? Meals { get; set; }

    }
}
