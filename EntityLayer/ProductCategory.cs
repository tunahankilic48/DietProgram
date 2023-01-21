using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ProductCategory : BaseClass
    {
        public ProductCategory()
        {
            CreatedDate = DateTime.Now;
            Products = new List<Product>();
        }

        public string? Name { get; set; }
        public DateTime? ModifiedDate { get; set; }

        // Navigation Properties
        public List<Product>? Products { get; set; }
    }
}
