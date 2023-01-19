using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class WeightsAndHeights : BaseClass
    {
        public int? Height { get; set; }
        public decimal? Weight { get; set; }

        public int? AppUserId { get; set; }

        public decimal? BodyMassIndex //boy ve kilo 
        {
            get
            {
                decimal squareOfLength = (decimal)Math.Pow((double)Height / 100, 2);
                return Math.Round((decimal)Weight * squareOfLength, 2);
            }
        }
        public decimal? DailyRequiredCalori
        {
            get
            {
                if (AppUser.IsMale == true)
                    return Math.Round((decimal)(66.5m + (13.75m * Weight) + (5m * (decimal?)Height) - (6.77m * (DateTime.Now.Year - AppUser.BirtDate.Value.Year))) * 1.45m, 2);
                else
                    return Math.Round((decimal)(655.1m + (9.56m * Weight) + (1.85m * (decimal?)Height) - (4.67m * (DateTime.Now.Year - AppUser.BirtDate.Value.Year))) * 1.45m, 2);

            }
        }
        //Navigation Props

        public AppUser? AppUser { get; set; }
    }
}
