

using OOP;
using TodoList;

Console.WriteLine($"1+ 2 is {StaticCalculator.Add(1, 2)}");
Console.WriteLine(Rectangle.DescribeGenerally());
Console.WriteLine("Number of sides is " + Rectangle.NumberOfSides);// like static methodes
var rectangle1 = new Rectangle(5,10);
var rectangle2 = new Rectangle(50,100);
Console.WriteLine(
    "Count of Rectangle objects is " + Rectangle.CountOfInstances);
Console.WriteLine(StaticCalculator.Add(2, 3)); 
Console.WriteLine(StaticCalculator.Add(2, 4)); 
StaticCalculator.Add(2, 5);
/* Issues caused by procedural programming 
-spaghetti code
-No way to control who can access methods
-No separation by levels of abstraction
-Changes in requirements are hard to implement
-logic is not easily configurable*/
/*
 * OOP is a coding paradigm in which objects containing data and methods play a central role.
 * We define what data and methods objects of some type will contain by defining classes.
 * We can gave many objects (instances) of the same class.
 * code is modular, which makes it easier to maintain, reuse, and modify.
 * cod is more flexible, and we can adjust its behavior to changing needs easily.
 * dode is easier to understand.
 * It's easy to control how some methods and data can be accessed, Which makes the code less error-prone.
 * Encapsulation.
 * polymorphism 
 * Abstracion
 * inheritance
 */