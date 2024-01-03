using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace WeatherApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your zipcode: ");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";
            Console.WriteLine();

            Console.WriteLine($"it is currently {WeatherMap.GetTemp(apiCall)} degree F in your location.");
        }
    }
}
