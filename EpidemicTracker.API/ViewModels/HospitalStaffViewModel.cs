using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpidemicTracker.API.ViewModels
{
    public class HospitalStaffViewModel
    {
      
            public int Id { get; set; }
            public string StaffName { get; set; }
            public string UserName { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string PhoneNo { get; set; }
            public string GovernmentIdNo { get; set; }
            public string EmailId { get; set; }
            public string Password { get; set; }
            public int HospitalId { get; set; }
            public int StaffRoleId { get; set; }
            public string AddressLine { get; set; }
            public string Area { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
            public int Pincode { get; set; }
            
            
    }
}
