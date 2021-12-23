// See https://aka.ms/new-console-template for more information
using Deconstruct;

var person = new Person("Andrei", "Fedotov");
Console.WriteLine(person);

(string name, string lastName) = person;
Console.WriteLine(name);
Console.WriteLine(lastName);

var name2 = string.Empty;
var lastname2 = string.Empty;
(name2, lastname2) = person;
Console.WriteLine(name2);
Console.WriteLine(lastname2);

Console.WriteLine("This is new C# 10 feature");
Console.WriteLine("You can reuse existing variable and create new variables within the same decosntruct statement");

var lastname3 = string.Empty;
(var name3, lastname3) = person;
Console.WriteLine(name3);
Console.WriteLine(lastname3);