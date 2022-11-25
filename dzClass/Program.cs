using System;

namespace Program 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Audi", 550,2022);
            PassengerCar car2 = new PassengerCar("Audi", 550,2022,5);
            Truck truck1 = new Truck("Mersedes",560,2023,1500,"Ivan");
            
            Console.WriteLine(truck1.ToString());
            truck1.ChangeDriver();
            Console.WriteLine(truck1.ToString());

        }

    }
}