using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdeToBikes.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        [Display(Name = "Brand")]
        public string Name { get; set; }

        [StringLength(128)]
        public string Location { get; set; }
        public virtual ICollection<ManufacturerModel> Models { get; set; }
    }
}