using System;
using System.ComponentModel.DataAnnotations;

namespace SkillPals.API.Models.DTO
{
	public class PostDto
	{
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Picture { get; set; }

        public string Description { get; set; }

        public string Creator { get; set; }

        public DateTime PublishedDate { get; set; }
    }
}

