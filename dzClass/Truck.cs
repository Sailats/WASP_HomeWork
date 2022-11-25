public class Truck : Car
{
    public int MaxLoadCapacity{get;set;}
    private string _fullName = "None";
    public string FullName
    {
        get
        {
            return _fullName;    // возвращаем значение свойства
        }
        set
        {
            _fullName = value;   // устанавливаем новое значение свойства
        }
    }
    public  Dictionary<string, int> CargoInMoment = new Dictionary<string, int>(); // name and weight
    public Truck(string brand,int power,int years,int maxLoadCapacity,string fullName)    
        :base(brand,power,years)
    {
        MaxLoadCapacity = maxLoadCapacity;
        FullName = fullName;
    }

    public void ChangeDriver()
    {
        Console.Write("Enter name to change:");
        string newdriver = Console.ReadLine();
        _fullName = newdriver;
        Console.WriteLine("Now your driver is " + _fullName);
    }

    public void addCargo()
    {
        Console.Write("Enter new cargo to add:");
        
    }
    public void delCargo()
    {
        Console.Write("Enter name of cargo to delete:");
    }

    public override string ToString()
    {
        return $"Object: {Brand} {Power} {Years} {MaxLoadCapacity} {FullName}";
    }
}