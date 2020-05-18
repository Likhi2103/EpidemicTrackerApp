using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EpidemicTracker.Data.Entities
{
    public class User : BaseEntity
    {
        //public new int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }
        [Key]
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]
        public string GovernmentIdNo { get; set; }
        public int OccupationTypeId { get; set; }
        [ForeignKey("OccupationTypeId")]
        public OccupationType OccupationType { get; set; }
        public string OccCompanyName { get; set; }
        public string OccupationPhoneNo { get; set; }
    }
}
