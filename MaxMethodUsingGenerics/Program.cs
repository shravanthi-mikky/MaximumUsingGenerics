// See https://aka.ms/new-console-template for more information
using MaxMethodUsingGenerics;

Console.WriteLine("Welcome to MAximum Method Using Generics!");
while(true)
{
    Console.WriteLine("PLease choose the option :\n1)Maximum of three Integers\n2)Maximum of three Float values\n3) Maximum of three Strings");
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
        case 3:
            UsingStrings obj3 = new UsingStrings();
            string maxValueStrings = obj3.MaxValueStrings("Apple", "Ball", "Cat");
            Console.WriteLine("Maximum value when comparing three integers is : " + maxValueStrings);
            break;
        default:
            break;

    }
}
;