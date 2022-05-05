// See https://aka.ms/new-console-template for more information
using MaxMethodUsingGenerics;

Console.WriteLine("Welcome to MAximum Method Using Generics!");
while(true)
{
    Console.WriteLine("PLease choose the option :");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            UsingInt obj1 = new UsingInt();
            int maxValueInt = obj1.MaxValueInt(40, 20, 10);
            Console.WriteLine("Maximum value when comparing three integers is : " + maxValueInt);
            break;
        case 2:
            UsingFloat obj2 = new UsingFloat();
            double maxValueFloat = obj2.MaxValueFloat(1.2, 2.4, 8.9);
            Console.WriteLine("Maximum value when comparing three integers is : " + maxValueFloat);
            break;
        default:
            break;

    }
}
;