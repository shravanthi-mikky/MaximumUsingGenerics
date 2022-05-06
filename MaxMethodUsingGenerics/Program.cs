// See https://aka.ms/new-console-template for more information
using MaxMethodUsingGenerics;

Console.WriteLine("Welcome to MAximum Method Using Generics!");
while(true)
{
    Console.WriteLine("PLease choose the option :\n1)Maximum of three Integers\n2)Maximum of three Float values\n3) Maximum of three Strings\n4)Maximum using generic Method");
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
        case 4:
            GenericMethod obj4 = new();
            int genValue1 = GenericMethod.MaxValueGenerics<int>(10,20,30);
            Console.WriteLine("Maximum value when comparing three integers is : " + genValue1);
            double genValue2 = GenericMethod.MaxValueGenerics<double>(1.2,6.5,8.9);
            Console.WriteLine("Maximum value when comparing three Float values is : " + genValue2);
            string genValue3 = GenericMethod.MaxValueGenerics("Animal", "Bananas", "Apple");
            Console.WriteLine("Maximum value when comparing three strings is : " + genValue3);
            break;
        default:
            Console.WriteLine("Please choose the correct option :");
            break;

    }
}
