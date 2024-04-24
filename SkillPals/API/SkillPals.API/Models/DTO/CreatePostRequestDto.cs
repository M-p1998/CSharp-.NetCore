using System;
namespace SkillPals.API.Models.DTO
{
	public class CreatePostRequestDto
	{
        public string Title { get; set; }

        public string Picture { get; set; }

        public string Description { get; set; }

        public string Creator { get; set; }

        //public DateTime PublishedDate { get; set; }
    }
}

