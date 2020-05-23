using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EpidemicTracker.Data.Entities
{
    public class Hospital : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Line1 { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

    }
}
