using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EpidemicTracker.Data.Entities
{
    public class HospitalStaff : BaseEntity
    {
        public int HospitalId { get; set; }
        [ForeignKey("HospitalId")]
        public Hospital Hospital { get; set; }
        public int StaffRoleId { get; set; }
        [ForeignKey("StaffRoleId")]
        public StaffRole StaffRole { get; set; }
        public string StaffName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
               
    }
}
