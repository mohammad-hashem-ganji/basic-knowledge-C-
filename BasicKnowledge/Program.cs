﻿
using BasicKnowledge;

MyExeption ex = new MyExeption();
ex.Myexeption();
Function function = new Function();
//____________________________________________________________________
// Explicitly typed variables
//string word = "ABC";
//int number = 5;
// implicitly typed variables
//var word = "ABC";
//word = 10; errore
//var name; "Implicitly-typed variable must ve initialized"
//var number = 5;

//______________________________________________________________
//var userChoice = Console.ReadLine();
//if (userChoice.Length == 0)
//{
//    Console.WriteLine("Evpty choice");
//    int number = 5;
//    Console.WriteLine(number);
//    var word = "ABC";
//    if (word.Length > 0)
//    {
//Console.WriteLine(number); // it is ok to use "number" in this scope 
//}
//}
//else
//{
//    Console.WriteLine("Non-empty choice :" + userChoice);
//Console.WriteLine(number); => the name "number" does not exist in the current context .
// variable "number" in if statement is in the scope
//int number = 10;
// in both scopes if and else I have defined same variable but the copiler doesn't give me an errore 
// because they have defined in differrent scope . so they don't see each other.
//}
//Console.WriteLine("Your choice is :" + userChoice);
//________________________________________________________________
//var userChoice = Console.ReadLine();
//bool isLong = IsLong(userChoice);

//bool IsLong(string? userChoice)
//{
//    return userChoice.Length > 10;
//}
//bool IsLong(string input)
//{
//    return input.Length > 10;
//}
//_________________________________________________________________
// C# is statically typed prgaramming language .
//var word = "abc";
//word = 10; errore static type





