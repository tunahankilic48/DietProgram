using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Country : BaseClass
    {
        public Country()
        {
            CreatedDate = DateTime.Now;
            Cities = new List<City>();
        }
        public string? Name { get; set; }

        // Navigation Properties
        public List<City>? Cities { get; set; }
    }
}
