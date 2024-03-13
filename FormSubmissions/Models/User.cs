using System;
using System.ComponentModel.DataAnnotations;
namespace FormSubmissions.Models
{
    public class User
    {   
        [Display(Name="First Name")]
        [Required]
        [MinLength(4, ErrorMessage ="Field must be 4 characters or more")]
        public string FirstName{get;set;}


        [Display(Name="Last Name")]
        [Required]
        [MinLength(4)]
        public string LastName{get;set;}

        [Required]
        [Range(0,Int32.MaxValue, ErrorMessage="Age must be a positive number")]
        public int Age{get;set;}

        [Display(Name="Email ")]
        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Field must be 8 characters or more")]
        public string Password {get;set;}
    }
}