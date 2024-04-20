using System;
using ExpenseTracker.Models;
using System.Collections.Generic;

namespace ExpenseTracker.Repositories
{
	public interface IExpenseRepository
    {

        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(int id);
        Task Add(Category model);
        Task Update(Category model);
        Task Delete(int id);
    }
}

