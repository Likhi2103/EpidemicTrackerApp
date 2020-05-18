using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EpidemicTracker.Data.Entities
{
    public class EPContext : DbContext
    {
        public DbSet<OccupationType> OccupationType { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<AddressType> AddressType { get; set; }
        public DbSet<Address> Address { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server=LAPTOP-TU4G9408;DataBase=EpidemicTrackerAppData;"+"Trusted_Connection =True;");
        }
    }
}
