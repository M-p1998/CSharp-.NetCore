using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpenseTracker.Models;
using ExpenseTracker.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Controllers
{

    public class CategoryController : Controller
    {
        private readonly IExpenseRepository _Repo;

        public CategoryController(IExpenseRepository context)
        {
            _Repo = context;
        }

        // GET: /<Category>/
        public async Task<IActionResult> Index()
        {
            var categories = await _Repo.GetAll();
            return View(categories);

        }

        // GET: /Category/Create
        public IActionResult Create()
        {
            
            return View(new Category());

        }


    }
}

