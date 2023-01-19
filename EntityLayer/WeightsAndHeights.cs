using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class WeightsAndHeights : BaseClass
    {
        public int Height { get; set; }
        public int Weight { get; set; }

        public int AppUserId { get; set; }
        //Navigation Props

        public AppUser AppUsers { get; set; }
    }
}
