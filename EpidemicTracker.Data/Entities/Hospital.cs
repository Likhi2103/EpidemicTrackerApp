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
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

    }
}
