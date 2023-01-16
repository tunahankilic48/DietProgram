﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class City : BaseClass
    {
        public string? Name { get; set; }
        public int? CountryId { get; set; }

        // Navigation Properties
        public Country? Country{ get; set; }


    }
}