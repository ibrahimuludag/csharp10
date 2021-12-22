using ScopedNamespace;

Car car = new()
{
    Make = "Ssangyong",
    Model = "Korando",
    Year = 2020
};
Console.WriteLine($"Your car is {car.Make} {car.Model} {car.Year}");
