using System;
using Mod2P2_MyApp.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Mod2P2_MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new sakilaContext();

            // Console.WriteLine("Hello World!");
            // var dbContext = new sakilaContext();
            // var actors = dbContext.Actor.ToList();
            // foreach (var a in actors) {
            //     System.Console.WriteLine($"ID:{a.ActorId} Name:{a.FirstName} {a.LastName}");
            // }

            // Module 2 Part 2 section - Adding, inserting and removing a database entry for city
            // var dbContext = new sakilaContext();
            // var records = dbContext.Film.Include(f => f.FilmActor).ThenInclude(r => r.Actor).ToList();
            // foreach (var record in records) {
            //     System.Console.WriteLine($"Film: {record.Title}");
            //     var counter = 1;
            //     foreach (var fa in record.FilmActor) {
            //         System.Console.WriteLine($"\tActor {counter++}: {fa.Actor.FirstName} {fa.Actor.LastName}");
            //     }
            // }

            // var city = new City() { CityId = 1001, Name = "Redmond", CountryId = 103 };
            // dbContext.Add(city);
            // dbContext.SaveChanges();

            // 
            // var uTarget = dbContext.City.SingleOrDefault(c => c.CityId == 1001);
            // if (uTarget != null) {
            //     uTarget.Name = "Kirkland";  // change Name to City1 if you did not update the City class file
            //     dbContext.Update(uTarget);
            //     dbContext.SaveChanges();
            // }

            // var dTarget = dbContext.City.SingleOrDefault(c => c.CityId == 1001);
            // if (dTarget != null) {
            //     dbContext.Remove(dTarget);
            //     dbContext.SaveChanges();
            // }

            

        }
    }
}
