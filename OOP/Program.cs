

using OOP;
using TodoList;

Console.WriteLine($"1+ 2 is {StaticCalculator.Add(1, 2)}");
Console.WriteLine(Rectangle.DescribeGenerally());
Console.WriteLine("Number of sides is " + Rectangle.NumberOfSides);// like static methodes
var rectangle1 = new Rectangle(5,10);
var rectangle2 = new Rectangle(50,100);
Console.WriteLine(
    "Count of Rectangle objects is " + Rectangle.CountOfInstances);
