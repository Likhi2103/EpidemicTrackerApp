using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EpidemicTracker.Data.Entities
{
    public class Patient : BaseEntity
    {
        [Key]
        [Required]
        public new int Id { get; set; }
        [Required]
        public string PatientName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]
        public string GovernmentIdNo { get; set; }
        public int AddressTypeId { get; set; }
        [ForeignKey("AddressTypeId")]
        public AddressType AddressType { get; set; }
        public int DiseaseTypeId { get; set; }
        [ForeignKey("DiseaseTypeId")]
        public DiseaseType DiseaseType { get; set; }
        public int OccupationTypeId { get; set; }
        [ForeignKey("OccupationTypeId")]
        public OccupationType OccupationType { get; set; }
        public string OccCompanyName { get; set; }
        public string OccupationPhoneNo { get; set; }
    }
}
