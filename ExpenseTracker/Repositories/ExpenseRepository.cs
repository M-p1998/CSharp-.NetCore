using System;
using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Repositories
{
	public class ExpenseRepository : IExpenseRepository
	{
        private readonly ApplicationDbContext _context;
        public ExpenseRepository(ApplicationDbContext context)
		{
            _context = context;
		}

        public async Task Add(Category model)
        {
            await _context.Categories.AddAsync(model);
            await Save();
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            var exp = await _context.Categories.ToListAsync();
            return exp;
        }

        private async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}

