using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Address: BaseClass
    {
        
        public int? CityId { get; set; }
        public int? UserId { get; set; }

        // Navigation Properties

        public City? City { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
