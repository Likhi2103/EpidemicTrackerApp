using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EpidemicTracker.Data.Entities
{
    public class Address : BaseEntity
    {
        //[Key]
        //[Required]
        //public new int Id { get; set; }

        public string HouseNo { get; set; }

        public string Street { get; set; }

        public string Locality { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }
        public int UserId { get; set; }

        [ForeignKey("EmailId")]
        public User User { get; set; }
        public int AddressTypeId { get; set; }

        [ForeignKey("AddressTypeId")]
        public AddressType AddressType { get; set; }
    }
}
