using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherEx
{
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            List<string> cities = new List<string>() { "Karaganda", "Almaty", "London", "Moskow", "Piterburg" };

            List<string> randomWeather = new List<string>() { "Solnechno", "Dojdlivo", "Moroz" };
            Random random = new Random();

            Console.WriteLine("Input city:");
            string inputCity = Console.ReadLine();

            Console.WriteLine("Input now your time(YYYY.MM.dd)");
            string time = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            if (cities.Contains(inputCity)){
               
                Console.WriteLine($"Weather in {inputCity} time {time}");
                var rnd = randomWeather[new Random().Next(randomWeather.Count)];
                Console.WriteLine(rnd);
            }
            else
            {
                Console.WriteLine("This city not found");
            }
        }
    }
}
