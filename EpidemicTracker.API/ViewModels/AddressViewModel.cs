using EpidemicTracker.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EpidemicTracker.API.ViewModels
{
    public class AddressViewModel 
    {
        public string HouseNo { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int PatientId { get; set; }
        public int AddressTypeId { get; set; }



    }
}
