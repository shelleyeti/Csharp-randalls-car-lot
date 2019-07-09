using System;
using System.Collections.Generic;

namespace randalls_car_lot
{
  class Program
  {
    static void Main(string[] args)
    {
      // var carsOnLot = new Dictionary<string, Dictionary<string, string>>();

      // var vehicle = new Dictionary<string, string>() {
      // ("year", "2008"),
      // ("model", "Damfresh"),
      // ("make", "Biotraxquote"),
      // ("color", "sky magenta")
      // };


      // carsOnLot.Add(vehicle, );

      // Dictionary<string, string> salesAgent = new Dictionary<string, string>();
      // new Dictionary<string, string>();

      // salesAgent.Add("mobile", "2008");
      // salesAgent.Add("lastName", "Botsford");
      // salesAgent.Add("firstName", "Shaina");

      // carsOnLot.Add(salesAgent);

      // Dictionary<string, string> credit = new Dictionary<string, string>();
      // new Dictionary<string, string>();

      // credit.Add("creditProvider", "J.P.Morgan Chase & Co");
      // credit.Add("account", "601109582720302");

      // carsOnLot.Add(salesAgent);

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


      // foreach (List<Car> automobile in garage)
      //   Console.WriteLine($"{automobile}");
    }
  }
}