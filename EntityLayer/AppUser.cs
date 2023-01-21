using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace EntityLayer
{
    public class AppUser : BaseClass
    {
        public AppUser()
        {
            CreatedDate = DateTime.Now;
            Meals = new List<Meal>();
            WeightsAndHeights = new List<WeightsAndHeights>();
        }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public byte[]? ProfilePhoto { get; set; }
        public DateTime? BirtDate { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsMale { get; set; }
        public bool? IsActive { get; set; }
        public int? AddressId { get; set; }
        public DateTime? ModifiedDate { get; set; }


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
