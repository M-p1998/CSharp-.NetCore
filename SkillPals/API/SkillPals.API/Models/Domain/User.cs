using System;
namespace SkillPals.API.Models.Domain
{
	public class User
	{

        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string password { get; set; }

        //public string Description { get; set; }

        //public string Creator { get; set; }

        public DateTime JoinDate { get; set; }
    }
}

