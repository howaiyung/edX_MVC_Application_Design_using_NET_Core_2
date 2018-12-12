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
            /* var country = _context.Country.get(id);
            if (product != null)
                return View("Detail", product);
            else
                return RedirectToAction("Index");*/

            //var idCountry = _context.Country.FindAsync(id);

            //var dbCountry = idCountry
            

            IQueryable<Country> countries = from temp in _context.Country select temp;
            var listCountries = countries.ToList();
            var idCountry = _context.Country.Find(id);
            

            //var listCountries = countries.ToList();


            if (idCountry != null)
                return View("Detail", idCountry);
            else
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