using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EpidemicTracker.Data.Entities
{
    public class OccupationType : BaseEntity
    {
        
        //public new int Id { get; set; }
        public string Type { get; set; }
    }
}
