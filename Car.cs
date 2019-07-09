using System;

namespace randalls_car_lot
{
  class Car
  {
    public int Year { get; set; }

    public string Model { get; set; }

    public string Make { get; set; }

    public double Price { get; set; }

    //method -----void means you return nothing
    public void Drive()
    {
      if (Make == null)
      {
        Console.WriteLine($"Sorry Dog, no make");
      }
      else
      {
        Console.WriteLine($"I'm drivin' my {Make} here!!");
      }
    }

    public void Drive(int miles)
    {
      Console.WriteLine($"{Make} is driving for {miles} miles");
    }

  }
}