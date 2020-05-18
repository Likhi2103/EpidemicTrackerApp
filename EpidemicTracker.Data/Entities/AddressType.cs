using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EpidemicTracker.Data.Entities
{
    public class AddressType : BaseEntity
    {
        
        //public new int Id { get; set; }
        public string Name { get; set; }
    }
}

