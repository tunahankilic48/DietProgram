using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class City : BaseClass
    {
        public City()
        {
            CreatedDate = DateTime.Now;
            Addresses = new List<Address>();
        }
        public string? Name { get; set; }
        public int? CountryId { get; set; }

        // Navigation Properties
        public Country? Country { get; set; }
        public List<Address> Addresses { get; set; }


    }
}
