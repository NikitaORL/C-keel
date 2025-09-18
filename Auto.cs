using System;

public class Class1
{
    public string Brand;
    public int Year;
    public int MaxSpeed;  

    public Class1(string brand, int year, int maxSpeed)
    {
        Brand = brand;
        Year = year;
        MaxSpeed = maxSpeed;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Машина: {Brand}, год выпуска: {Year}, максимальная скорость: {MaxSpeed} км/ч");
    }
}