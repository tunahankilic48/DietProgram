using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Country : BaseClass
    {
        public string? Name { get; set; }

        // Navigation Properties
        public List<City>? City{ get; set; }
        public List<Address>? Addresses { get; set; }
    }
}
