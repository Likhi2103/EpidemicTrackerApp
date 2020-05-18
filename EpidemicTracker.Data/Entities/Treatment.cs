using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EpidemicTracker.Data.Entities
{
    public class Treatment : BaseEntity
    {
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
        public int DiseaseId { get; set; }
        [ForeignKey("DiseaseId")]
        public DiseaseType DiseaseType { get; set; }
        [Required]
        public DateTime AdmittedDate { get; set; }
        [Required]
        public DateTime DischargeDate { get; set; }
        [Required]
        public byte[] Prescription { get; set; }
        [Required]
        public string CuredPrecentage { get; set; }
        [Required]
        public string IsFatality { get; set; }

    }
}
