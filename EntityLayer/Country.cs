﻿using System;
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
            Cities= new List<City>();
            Addresses= new List<Address>();
        }
        public string? Name { get; set; }

        // Navigation Properties
        public List<City>? Cities{ get; set; }
        public List<Address>? Addresses { get; set; }
    }
}
