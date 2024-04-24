using System;
using Microsoft.EntityFrameworkCore;
using SkillPals.API.Models.Domain;

namespace SkillPals.API.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}

