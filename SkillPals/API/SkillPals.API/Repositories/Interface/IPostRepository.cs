using System;
using SkillPals.API.Models.Domain;

namespace SkillPals.API.Repositories.Interface
{
	public interface IPostRepository
	{
		Task<Post> CreateAsync(Post post);

		Task<IEnumerable<Post>> GetAllAsync();

	}
}

