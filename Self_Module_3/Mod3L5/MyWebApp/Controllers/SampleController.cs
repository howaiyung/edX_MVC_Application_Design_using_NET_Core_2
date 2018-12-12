using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers {

    public class SampleController {

        public string SayHello() {
            return "Hello, ASP.NET Core!";
        }

        // Example URL: http://localhost:5000/sample/sayhello 
        public double Add(double a, double b) {
            return a + b;
        }

        // Example URL: http://localhost:5000/sample/add?a=10&b=20
        // The result is returned as a JSON object
        public IActionResult CylinderVolume(double r, double h) {
            double v = System.Math.PI * System.Math.Pow(r, 2) * h;
            return new JsonResult(v);
        }

        // Example URL: https://localhost:5001/sample/CylinderVolume?r=10.0&h=20.0
        // The result is returned as a JSON object
    }
}