using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GlobalCityManager.Models;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System;

namespace GlobalCityManager.Controllers {
    public class CountryController : Controller {

        private readonly worldContext _context;

        public CountryController(){
            _context = new worldContext();
        }

        //---------------------------------------------------------------------------------------
        
        public IActionResult ShowDetail(string id) {
            
            var sCountry = _context.Country.Find(id);

            if (sCountry != null)
                return View("Detail", sCountry);
            else
                return RedirectToAction("Index");

        }

        //---------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country newCountry) {
            if (ModelState.IsValid) {
                _context.Country.Add(newCountry);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        //---------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult Edit(string id) {
            return View(_context.Country.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Country uCountry) {
            if (ModelState.IsValid){
                _context.Country.Update(uCountry);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        //---------------------------------------------------------------------------------------

        [HttpPost]
        public IActionResult Remove(string id) {

            var dCountry = _context.Country.Find(id);

            if (dCountry != null){
                _context.Country.Remove(dCountry);
                _context.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }

        //---------------------------------------------------------------------------------------
         public IActionResult Index() {
            
            IQueryable<Country> countries = from temp in _context.Country select temp;
            var listCountries = countries.ToList();
            return View(listCountries);
        }

    }
}