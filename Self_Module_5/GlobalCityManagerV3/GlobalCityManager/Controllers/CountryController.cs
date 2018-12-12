using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GlobalCityManager.Models;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System;

namespace GlobalCityManager.Controllers {
    public class CountryController : Controller {

        //public worldContext dbContext { get; set; }

        //public CountryController(worldContext context) => dbContext = new worldContext();

        public worldContext _context;

        /* public CountryController(worldContext context){
            _context = context;

        }*/

        public CountryController(){
            _context = new worldContext();
        }


        public IActionResult Index() {
            IQueryable<Country> countries = from temp in _context.Country select temp;
            var listCountries = countries.ToList();
            return View(listCountries);
            
        }

    }
}