// See https://aka.ms/new-console-template for more information
using MaxMethodUsingGenerics;

Console.WriteLine("Welcome to MAximum Method Using Generics!");
while(true)
{
    Console.WriteLine("PLease choose the option :\n1)Maximum of three Integers\n2)Maximum of three Float values\n3) Maximum of three Strings\n4)Maximum using generic Method\n5)Max value sing generic class and method");
    Console.WriteLine("------------------------------------------");
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
        case 5:
            int genClass1 = GenericClass<int>.MaxValueGeneric<int>(10, 30, 50);
            Console.WriteLine("Maximum value when comparing three integers  using generic class and method is : " + genClass1);
            double genClass2 = GenericClass<double>.MaxValueGeneric<double>(10.4, 30.6, 50.9);
            Console.WriteLine("Maximum value when comparing three float using generic class and method is : " + genClass2);
            string genClass3 = GenericClass<string>.MaxValueGeneric<string>("Animal", "Bananas", "Apple");
            Console.WriteLine("Maximum value when comparing three strings using generic class and method is : " + genClass3 + "\n");
            break;
        default:
            Console.WriteLine("Please choose the correct option :");
            break;

    }
}
