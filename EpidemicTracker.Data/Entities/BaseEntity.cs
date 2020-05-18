using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EpidemicTracker.Data.Entities
{
    public class BaseEntity
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public string UserCreated { get; set; }
        [Required]
        public DateTime DateModified { get; set; }
        [Required]
        public string UserModified { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
