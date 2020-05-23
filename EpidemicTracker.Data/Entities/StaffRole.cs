using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EpidemicTracker.Data.Entities
{
    public class StaffRole : BaseEntity
    {
        [Required]
        public string Type { get; set; }
    }
}
