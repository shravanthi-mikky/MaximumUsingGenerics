// See https://aka.ms/new-console-template for more information
using MaxMethodUsingGenerics;

Console.WriteLine("Welcome to MAximum Method Using Generics!");
UsingInt obj1 = new UsingInt();
int maxValueInt = obj1.MaxValueInt(40, 20, 10);
Console.WriteLine("Maximum value when comparing three integers is : " + maxValueInt);