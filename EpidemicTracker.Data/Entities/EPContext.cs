using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EpidemicTracker.Data.Entities
{
    public class EPContext : DbContext
    {
        public DbSet<OccupationType> OccupationType { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<AddressType> AddressType { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<DiseaseType> DiseaseType { get; set; }
        public DbSet<Disease> Disease { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<HospitalStaff> HospitalStaff { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<StaffRole> StaffRole { get; set; }
        public DbSet<TreatmentStatus> TreatmentStatus { get; set; }
        public DbSet<Treatment> Treatment { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server=LAPTOP-TU4G9408;DataBase=EpidemicTrackerData;"+"Trusted_Connection =True;");
        }
    }
}
