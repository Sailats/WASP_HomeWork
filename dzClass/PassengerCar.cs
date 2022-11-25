public class PassengerCar:Car
{
    public int CountOfpassengers {get;set;}
    public  Dictionary<string, int> repairbook = new Dictionary<string, int>();
    
    public PassengerCar(string brand,int power,int years,int countOfpassengers) 
        :base(brand,power,years)
    {
        CountOfpassengers = countOfpassengers;
    }
    
    public override string ToString()
    {
        return $"Object: {Brand} {Power} {Years} {CountOfpassengers} ";
    }

    public void AddRepair()
    {
        repairbook.Add("Engine", 2022);
        repairbook.Add("Wheels", 2021);
        repairbook.Add("Light", 2020);
        repairbook.Add("Car", 1941);

        Console.WriteLine("Enter the repaired part of the car: ");
        string part = Console.ReadLine();
        Console.WriteLine("Enter year when the part was repaired: ");
        int repairYear = Convert.ToInt32(Console.ReadLine());
        repairbook.Add(part,repairYear);

    }
    public void GetYearFromPart()
    {
        repairbook.Add("Engine", 2022);
        repairbook.Add("Wheels", 2021);
        repairbook.Add("Light", 2020);
        repairbook.Add("Car", 1941);

        Console.Write("Enter the repaired part of the car: ");
        string repairedPart = Console.ReadLine();
        ICollection<string> Info = repairbook.Keys;
        foreach (string i in Info)
        {
            if (i==repairedPart){Console.WriteLine("Your {0} was repaired in {1}", i, repairbook[i]);}
        }
    }
    public void GetInfoRepairBook()
    {

        repairbook.Add("Engine", 2022);
        repairbook.Add("Wheels", 2021);
        repairbook.Add("Light", 2020);
        repairbook.Add("Car", 1941);

        Console.WriteLine("Your repair book");
            ICollection<string> Info = repairbook.Keys;
            foreach (string i in Info)
            Console.WriteLine("{0} -- {1}", i, repairbook[i]);
    }

} 