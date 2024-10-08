using System.Xml.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using WheatherAppSol.Models;
namespace WheatherAppSol.Controllers
{
    public class HomeController : Controller
    {
            
        [Route("/")]
        public IActionResult Index()
        {
            List<CityWeather> CityWeathers = new List<CityWeather>() {
               new CityWeather() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = DateTime.Parse("2030-01-01 8:00"),  TemperatureFahrenheit = 33 },
               new CityWeather() { CityUniqueCode = "NYC", CityName = "Newyork City", DateAndTime = DateTime.Parse("2030-01-01 3:00"),  TemperatureFahrenheit = 60 },
               new CityWeather() { CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = DateTime.Parse("2030-01-01 9:00"),  TemperatureFahrenheit = 82}
            };
    
                return View(CityWeathers);
        }

        [Route("/city-details/{cityCode}")]
        public IActionResult Details()
        {
            List<CityWeather> CityWeathers = new List<CityWeather>() {
               new CityWeather() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = DateTime.Parse("2030-01-01 8:00"),  TemperatureFahrenheit = 33 },
               new CityWeather() { CityUniqueCode = "NYC", CityName = "Newyork City", DateAndTime = DateTime.Parse("2030-01-01 3:00"),  TemperatureFahrenheit = 60 },
               new CityWeather() { CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = DateTime.Parse("2030-01-01 9:00"),  TemperatureFahrenheit = 82}
            };

            string? Code = Convert.ToString(Request.RouteValues["cityCode"]);

            CityWeather? matchingCity = CityWeathers.Where(temp => temp.CityUniqueCode == Code).FirstOrDefault();
            return View("Details",matchingCity);  //Views/Home/Details.cshtml


        }
    }
}
