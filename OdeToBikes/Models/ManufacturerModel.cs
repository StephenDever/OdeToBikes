using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdeToBikes.Models
{
    public class ManufacturerModel : IValidatableObject
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1024)]
        [Display(Name = "Model")]

        public string Name { get; set; }

        [Range(1850, 2050, ErrorMessage ="That's probably not right.")]
        [Required]
        public int Year { get; set; }

        [Required]
        [StringLength(1024)]
        public string Info { get; set; }
        public int ManufacturerId { get; set; }

        // use this to validate what people can put into the Name field
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Name.ToLower().StartsWith("pos"))
            {
                yield return new ValidationResult("That's not nice!");
            }
        }
    }
}