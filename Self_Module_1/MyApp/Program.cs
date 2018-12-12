using System;
using MyApp.Models;
using System.Linq;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            var dbContext = new sakilaContext();
            var actors = dbContext.Actor.ToList();
            foreach (var a in actors) {
                System.Console.WriteLine($"ID:{a.ActorId} Name:{a.FirstName} {a.LastName}");
            }
        }
    }
}
