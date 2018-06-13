using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClarisseStore.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        
        [Required]
        [Display(Name= "Name")]
        [StringLength(100,ErrorMessage ="{0} must be at least {2} characters long.", MinimumLength =2)]
        public string Name { get; set; }
        
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Mobile Phone")]
        [StringLength(15, ErrorMessage = "{0} must be at least {2} characters long.", MinimumLength = 5)]
        public string MobilePhone { get; set; }

        [UIHint("Date")]
        public DateTime BirthDate { get; set; }
        
        [Required]
        public Address DeliveryAddress { get; set; }

        [Required]
        public bool TermsAccepted { get; set; }
        
        public Role Role { get; set; }

    }
}
