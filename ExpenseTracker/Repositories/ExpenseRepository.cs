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

        public async Task<Category> GetById(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task Update(Category cat) 
        {
            var category = await _context.Categories.FindAsync(cat.CategoryId);
            if(category != null)
            {
                category.Title = cat.Title;
                category.Icon = cat.Icon;
                category.Type = cat.Type;
                _context.Update(category);
                await Save();
            }

        }

        public async Task Delete(int id)
        {
            var cat = await _context.Categories.FindAsync(id);
            if(cat != null)
            {
                _context.Categories.Remove(cat);
                await Save();
            }
        }

        private async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}

