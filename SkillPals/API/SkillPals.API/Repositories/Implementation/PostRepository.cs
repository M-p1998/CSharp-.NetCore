using System;
using Microsoft.EntityFrameworkCore;
using SkillPals.API.Data;
using SkillPals.API.Models.Domain;
using SkillPals.API.Repositories.Interface;

namespace SkillPals.API.Repositories.Implementation
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PostRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Post> CreateAsync(Post post)
        {
            await _dbContext.Posts.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return post;
        }
    }
}

