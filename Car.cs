using System;

namespace randalls_car_lot
{
    class Car
    {
        //this is referred to as a field, does not have a get/setter 
        private int _miles = 0;

        //these are referred to as propterties
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

        //constructor above methods
        public Car(int startingMiles)
        {
            _miles = startingMiles;
            Console.WriteLine("A new car is being instantiated");
        }

        public Car() { }

        public void Drive(int miles)
        {
            _miles += miles;
            Console.WriteLine($"{Make} is driving for {miles} miles");
            Console.WriteLine($"The odometer on the {Make} {Model} now reads {_miles}");
        }

    }
}