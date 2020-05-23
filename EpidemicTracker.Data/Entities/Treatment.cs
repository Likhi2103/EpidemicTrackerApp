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
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public HospitalStaff HospitalStaff { get; set; }
        public int DiseaseTypeId { get; set; }
        [ForeignKey("DiseaseId")]
        public DiseaseType DiseaseType { get; set; }
        public int DiseaseId { get; set; }
        [ForeignKey("DiseaseId")]
        public Disease Disease { get; set; }
        public int TreatmentStatusId { get; set; }
        [ForeignKey("TreatmentStatusId")]
        public TreatmentStatus TreatmentStatus { get; set; }
        [Required]
        public DateTime AdmittedDate { get; set; }
        [Required]
        public DateTime DischargeDate { get; set; }
      

    }
}
