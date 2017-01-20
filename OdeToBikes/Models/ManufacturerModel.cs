using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdeToBikes.Models
{
    public class ManufacturerModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1024)]
        [Display(Name = "Model")]
        public string Name { get; set; }

        [Range(1850, 2050)]
        [Required]
        public int Year { get; set; }

        [Required]
        [StringLength(1024)]
        public string Info { get; set; }
        public int ManufacturerId { get; set; }
    }
}