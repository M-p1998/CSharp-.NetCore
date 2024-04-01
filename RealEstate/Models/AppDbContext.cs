
using Microsoft.EntityFrameworkCore;
namespace RealEstate.Models
{
	public class AppDbContext : DbContext
	{
		 
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
			
		}
		public DbSet<Estate> Estates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estate>().HasData(
                new Estate { Estate_Id = 1, Name = "Home sweet home", Address = "Apple Street", Description = "Very nice house" }
                );
            //base.OnModelCreating(modelBuilder);
        }
    }
}

