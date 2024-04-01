using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    public class EstateController : Controller
    {
        private readonly AppDbContext _db;
        public EstateController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        { 
            List<Estate> objEstateList = _db.Estates.ToList();
            return View(objEstateList);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Estate e)
        {
            if (e.Name == e.Description.ToString())
            {
                ModelState.AddModelError("Name", "Name and Description cannot exactly match.");
            }
            if (ModelState.IsValid)
            {
                _db.Estates.Add(e);
                _db.SaveChanges();
                TempData["success"] = "Estate created successfully";
                return RedirectToAction("Index");
            }
            return View();
            
            
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            //Estate? estateFromDb = _db.Estates.Find(id);
            Estate estateFromDb = _db.Estates.FirstOrDefault(u => u.Estate_Id == id);
            //Estate? estateFromDb2 = _db.Estates.Where(u => u.Estate_Id == id).FirstOrDefault();
            if (estateFromDb == null)
            {
                return NotFound();
            }
            return View(estateFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Estate updatedEstate)
        {
            
            if (ModelState.IsValid)
            {
                // Load the existing entity from the database
                var existingEstate = _db.Estates.FirstOrDefault(e => e.Estate_Id == updatedEstate.Estate_Id);
                if(existingEstate == null)
                {
                    return NotFound();
                }
                existingEstate.Name = updatedEstate.Name;
                existingEstate.Address = updatedEstate.Address;
                existingEstate.Description = updatedEstate.Description;
                //_db.Estates.Update(existingEstate);
                _db.SaveChanges();
                TempData["success"] = "Estate updated successfully";
                Console.WriteLine(updatedEstate);
                return RedirectToAction("Index");
            }
            return View();


        }


        //public IActionResult Delete(int? id)
        //{
        //    if(id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    Estate? estateFromDb = _db.Estates.Find(id);
        //    if(estateFromDb == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(estateFromDb);

        //}

        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeletePost(int? id)
        //{
        //    Estate? obj = _db.Estates.Find(id);
        //    if(obj == null)
        //    {
        //        return NotFound();
        //    }
        //    _db.Estates.Remove(obj);
        //    _db.SaveChanges();
        //    TempData["success"] = "Estate deleted successfully";
        //    return RedirectToAction("Index");
        //}

        [Route("Delete/{id}")]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Estate obj = _db.Estates.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            // Check if the request is POST
            if (Request.Method == "POST")
            {
                _db.Estates.Remove(obj);
                _db.SaveChanges();
                TempData["success"] = "Estate deleted successfully";
                return RedirectToAction("Index");
            }

            return View(obj);
        }




    }
}

