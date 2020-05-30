using EpidemicTracker.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpidemicTracker.API.ViewModels

    {
        public class PatientViewModel 
        {
        // public List<Patient> patient { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string PhoneNo { get; set; }
        public string GovernmentIdNo { get; set; }
        public int OccupationTypeId { get; set; }
        public string OccCompanyName { get; set; }
        public string OccupationPhoneNo { get; set; }

        public AddressViewModel permanentAddress { get; set; }
        public AddressViewModel currentAddress { get; set; }
        public AddressViewModel workAddress { get; set; }

        }
}
