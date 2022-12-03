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
            
            // Console.WriteLine(truck1.ToString());
            // truck1.ChangeDriver();
            // Console.WriteLine(truck1.ToString());
            //car2.GetInfoRepairBook();


            Autopark park1 = new Autopark(car1.ToString());
            park1.AddAuto(car1.ToString());
            park1.AddAuto(car2.ToString());
            park1.AddAuto(truck1.ToString());
            park1.ToString();

        }
    }
}