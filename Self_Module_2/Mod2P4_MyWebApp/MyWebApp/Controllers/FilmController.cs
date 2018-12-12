using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers {
    public class FilmController : Controller {
        [HttpGet]
        public IActionResult CreateOrUpdate() {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrUpdate(CreateOrUpdateDTO dto) {
            var film = new Film() {
                ID = dto.ID, Name = dto.Name, Year = dto.Year,
                Genres = dto.Genres, IsInStore = dto.IsInStore
            };

            if (dto.Operation == Operation.Create) {
                // create a new film ... Note: the ID from the dto will be ignored
                return View("Created");
            } else if (dto.Operation == Operation.Update) {
                // update the existing film by ID
                return View("Updated");
            } else {
                return View("Error"); // we don't implement the Error view now
            }
        }
    }
}