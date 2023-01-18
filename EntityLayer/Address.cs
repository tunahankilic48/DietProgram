using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Address: BaseClass
    {
        
        public int? CountryId { get; set; }
        public int? UserId { get; set; }

        // Navigation Properties

        public Country? Country { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
