public class Autopark
{
    public string NameOfAutopark{get;set;}
    public List<string> cars = new List<string>();
    public Autopark (string nameOfAutopark)
    {
        NameOfAutopark = nameOfAutopark;
    }
    public void AddAuto(string car)
    {
        cars.Add(car);
    }

    public override string ToString()
    {
        
        for (int i = 0; i < cars.Count; i++)
        {
            Console.WriteLine(cars[i]);
        }
        return $"Autopark {NameOfAutopark}  ";
    }



}