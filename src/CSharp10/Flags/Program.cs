// See https://aka.ms/new-console-template for more information
using Flags;

Car car = new()
{
    Make = "Ssangyong",
    Model = "Korando",
    Year = 2020,
    Security = SecutityAddOn.BlindSpotWarning | SecutityAddOn.Abs
};

Console.WriteLine($"Your car is {car.Make} {car.Model} {car.Year}");
Console.WriteLine("Your car has the below security add ons");
Console.WriteLine($"{car.Security}");
