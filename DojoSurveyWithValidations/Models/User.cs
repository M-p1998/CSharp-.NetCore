
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidations.Models
{
    public class User{
        [Display(Name="Name: ")]
        [Required]
        [MinLength(2,ErrorMessage ="Name should be at least 2 characters!")]
        public string YourName{get;set;}
        
        [Display(Name="Location: ")]
        [Required]
        public string Location{get;set;}

        [Display(Name="Language: ")]
        [Required]
        public string Language{get;set;}

        [Display(Name="Comment(Optional): ")]
        [MinLength(5, ErrorMessage ="Comment should be at least more than 5 characters!")]
        public string Comment{get;set;}

    }
}