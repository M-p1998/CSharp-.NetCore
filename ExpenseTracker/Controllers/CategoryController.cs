using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpenseTracker.Models;
using ExpenseTracker.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public async Task<IActionResult> Details(int id)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if(id == 0)
            {
                return View(new Category());
            }
            else
            {
                Category cate = await _Repo.GetById(id);
                return View(cate);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("CategoryId, Title, Icon, Type")] Category cat)
        {
            if (ModelState.IsValid)
            {
                if(cat.CategoryId == 0)
                {
                    await _Repo.Add(cat);
                }
                else
                {
                    await _Repo.Update(cat);
                }
                return RedirectToAction(nameof(Index));

            }

            return View(cat);

        }

        //Post: Category/Delete/id
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _Repo.GetById(id);
            if(category != null)
            {
                await _Repo.Delete(id);
                
            }

            return RedirectToAction("Index");

        }

        //        public async Task<IActionResult> Edit(int id)
        //        {
        //            if(id == null)
        //            {
        //                return NotFound();
        //            }
        //            var category = await _Repo.GetById(id);
        //            if (category == null)
        //            {
        //                return NotFound();
        //            }

        //            return View(category);
        //        }

        //        [HttpPost]
        //        public async Task<IActionResult> Edit(int id, [Bind("CategoryId, Title, Icon, Type")] Category cate)
        //        {
        //            if(id != cate.CategoryId)
        //            {
        //                return NotFound();
        //            }

        //            if (ModelState.IsValid)
        //            {
        //                await _Repo.Update(cate);
        //                return RedirectToAction(nameof(Index));
        //            }
        //            return View();

        //        }





    }
}

