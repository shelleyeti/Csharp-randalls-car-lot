using System;
using System.Collections.Generic;

namespace randalls_car_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Option 1
            var ford2 = new Car();
            ford2.Year = 2017;
            ford2.Model = "Fiesta";
            ford2.Make = "Ford";
            ford2.Price = 32500.65;

            //Option 2
            var tesla2 = new Car()
            {
                Year = 2017,
                Model = "x",
                Make = "Tesla",
                Price = 80000.42,
            };

            //Add cars to the garage
            var garage = new List<Car>() { ford2, tesla2 };

            tesla2.Drive();
            tesla2.Drive(1000);


            foreach (Car automobile in garage)
                automobile.Drive();
        }
    }
}