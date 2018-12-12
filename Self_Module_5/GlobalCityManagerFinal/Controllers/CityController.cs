using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GlobalCityManager.Models;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System;

namespace GlobalCityManager.Controllers {
    public class CityController : Controller {

        private readonly worldContext _contextCity;

        public CityController(){
            _contextCity = new worldContext();
        }

        //---------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(City newCity) {
            if (ModelState.IsValid) {
                _contextCity.City.Add(newCity);
                _contextCity.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newCity);
        }
        //---------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult Edit(int id) {
            return View(_contextCity.City.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(City uCity) {
            if (ModelState.IsValid){
                _contextCity.City.Update(uCity);
                _contextCity.SaveChanges();
                return RedirectToAction("Index");
            }

            
            return View(uCity);

        }

        //---------------------------------------------------------------------------------------

        public IActionResult Delete(int id) {

            var dCity = _contextCity.City.Find(id);
            
            Console.WriteLine(dCity.Id);

            if (dCity != null){
                _contextCity.City.Remove(dCity);
                _contextCity.SaveChanges();
            }
            
            return RedirectToAction("Index");
            
        }

        //---------------------------------------------------------------------------------------
        public IActionResult Index() {
            
            IQueryable<City> cities = from temp in _contextCity.City select temp;
            var listCities = cities.ToList();
            return View(listCities);
        }

    }


}