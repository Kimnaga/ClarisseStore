using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClarisseStore.Models
{
    public class Address
    {
        [Required]
        public string Line1 { get; set; }
        
        [Required]
        [Display (Name ="City")]
        [StringLength(25,ErrorMessage= "{0} must be at least {2} characters long", MinimumLength = 8)]
        public string City { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        [StringLength(10, ErrorMessage = "{0} must be at least {2} characters long", MinimumLength = 5)]
        public string PostalCode { get; set; }
        
    }
}
