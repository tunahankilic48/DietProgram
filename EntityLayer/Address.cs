using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Address : BaseClass
    {
        public Address()
        {
            CreatedDate = DateTime.Now;
        }
        public int? CityId { get; set; }
        public int? UserId { get; set; }
        public DateTime? ModifiedDate { get; set; }

        // Navigation Properties

        public City? City { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
