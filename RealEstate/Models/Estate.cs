using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace RealEstate.Models
{
	public class Estate
	{
		[Key]
		public int Estate_Id { get; set; }
		[Required]
		[DisplayName("Estate Name: ")]
        [MinLength(2, ErrorMessage = "Name should be at least 2 characters!")]
        //[Range(3,100,ErrorMessage ="Name must be at least 3 characters long")]
		public string Name { get; set; }
        [Required]
        [DisplayName("Estate Address: ")]
        //[Range(1, 100)]
        [MinLength(2, ErrorMessage = "Address should be at least 2 characters!")]
        public string Address { get; set; }
        [Required]
        [DisplayName("Estate Description: ")]
        [MinLength(2, ErrorMessage = "Description should be at least 2 characters!")]
        //[Range(3, 100, ErrorMessage = "Description must be at least 3 characters long")]
        public string Description { get; set; }
         
		public Estate()
		{
		}
	}
}

