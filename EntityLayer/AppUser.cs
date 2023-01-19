using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AppUser : BaseClass
    {
        public AppUser()
        {
            Meals = new List<Meal>();

            WeightsAndHeights = new List<WeightsAndHeights>();
        }
        // to do: default values will be added in the created date 
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public int? Length { get; set; }
        public decimal? Weigth { get; set; }
        public decimal BodyMassIndex
        {
            get
            {
                decimal squareOfLength = (decimal)Math.Pow((double)Length / 100, 2);
                return Math.Round((decimal)Weigth * squareOfLength, 2);
            }
        }
        public decimal DailyRequiredCalori
        {
            get
            {
                if (IsMale == true)
                    return Math.Round((decimal)(66.5m + (13.75m * Weigth) + (5m * (decimal?)Length) - (6.77m * (DateTime.Now.Year - BirtDate.Value.Year))) * 1.45m, 2);
                else
                    return Math.Round((decimal)(655.1m + (9.56m * Weigth) + (1.85m * (decimal?)Length) - (4.67m * (DateTime.Now.Year - BirtDate.Value.Year))) * 1.45m, 2);

            }
        }
        public DateTime? BirtDate { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsMale { get; set; }
        public bool? IsActive { get; set; }
        public int? AddressId { get; set; }


        // Navigation Properties
        public List<Meal>? Meals { get; set; }
        public Address? Address { get; set; }
        public List<WeightsAndHeights>? WeightsAndHeights { get; set; }

        // Not Mapped
        public string Name
        {
            get
            {
                return (FirstName + " " + MiddleName).Trim();
            }
        }

    }
}
