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
           
            IQueryable<Country> countries = from temp in _context.Country select temp;
            var listCountries = countries.ToList();
            var idCountry = _context.Country.Find(id);
            
            if (idCountry != null)
                return View("Detail", idCountry);
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
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        //---------------------------------------------------------------------------------------
        /* public IActionResult Index(IList<Country> countries) {
            //IQueryable<Country> countries = from temp in _context.Country select temp;
            //var listCountries = countries.ToList();
            //return View(listCountries);
            return View(countries);
        }*/

         public IActionResult Index() {
            IQueryable<Country> countries = from temp in _context.Country select temp;
            var listCountries = countries.ToList();
            return View(listCountries);
        }

    }
}