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

        //delete
        //[HttpPost]
        //public IActionResult Delete(int EId)
        //{
        //    Estate? toDelete = _db.Estates.FirstOrDefault(d => d.Estate_Id == EId);
        //    if(toDelete == null)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    _db.Estates.Remove(toDelete);
        //    _db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    //Estate? estateFromDb = _db.Estates.Find(id);
        //    Estate? estateFromDb = _db.Estates.FirstOrDefault(u => u.Estate_Id == id);
        //    //Estate? estateFromDb2 = _db.Estates.Where(u => u.Estate_Id == id).FirstOrDefault();
        //    if (estateFromDb == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(estateFromDb);
        //}

        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeletePost(int? id)
        //{
        //    Estate? obj = _db.Estates.FirstOrDefault(u => u.Estate_Id == id);
        //    if (obj == null)
        //    {

        //        return NotFound();
        //    }
        //    _db.Estates.Remove(obj);
        //    _db.SaveChanges();
        //    TempData["success"] = "Estate deleted successfully";
        //    return RedirectToAction("Index", "Estate");


        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    //Estate obj = _db.Estates.FirstOrDefault(u => u.Estate_Id == id);
        //    //Estate obj = _db.Estates.Where(e=>e.Estate_Id == id).FirstOrDefault();
        //    Estate obj = _db.Estates.Find(id);
        //    if (obj != null)
        //    {
        //        _db.Estates.Remove(obj);
        //        _db.SaveChanges();
        //    }


        //    return RedirectToAction("Index");
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var obj = await _db.Estates.FirstOrDefaultAsync(u => u.Estate_Id == id);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }

        //    _db.Estates.Remove(obj);
        //    Console.WriteLine(obj);
        //    await _db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}


        //[HttpDelete]
        //[Route("{userId}")]
        //public IActionResult Delete(int userId)
        //{
        //    // Retrieve the user from the database
        //    var userToDelete = _db.Estates.SingleOrDefault(user => user.Estate_Id == userId);

        //    if (userToDelete == null)
        //    {
        //        return NotFound(); // Or handle the case where the user doesn't exist
        //    }

        //    // Delete the user
        //    _db.Estates.Remove(userToDelete);
        //    _db.SaveChanges();

        //    return RedirectToAction("Index"); // Redirect to the index page or any other appropriate action
        //}

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    // Retrieve the user from the database
            

        //    if (_db.Estates == null)
        //    {
        //        return Problem("Entity set 'AppDbContext.Estates' is null"); 
        //    }
        //    var estate = await _db.Estates.FindAsync(id);
        //    if(estate != null)
        //    {
        //        _db.Estates.Remove(estate);
        //    }

        //    await _db.SaveChangesAsync();

        //    return RedirectToAction(nameof(Index)); 
        //}

        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            Estate? estateFromDb = _db.Estates.Find(id);
            if(estateFromDb == null)
            {
                return NotFound();
            }
            return View(estateFromDb);

        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Estate? obj = _db.Estates.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Estates.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Estate deleted successfully";
            return RedirectToAction("Index");
        }



    }
}

