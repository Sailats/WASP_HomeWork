public class Car
{
    public string Brand{get;set;}
    public int Power{get;set;}
    public int Years{get;set;}

    public Car(string brand,int power, int years)
    {
        Brand = brand;
        Power = power;
        Years = years;
    }
    
    public override string ToString()
    {
        return $"Object: {Brand} {Power} {Years} ";
    }
 
}