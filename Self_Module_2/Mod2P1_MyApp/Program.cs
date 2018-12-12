using System;
using Mod2P1_MyApp.Models;
using System.Linq;

namespace Mod2P1_MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dbContext = new sakilaContext();
            var actors = dbContext.Actor.ToList();
            foreach (var a in actors) {
                System.Console.WriteLine($"ID:{a.ActorId} Name:{a.FirstName} {a.LastName}");
            }
        }
    }
}
