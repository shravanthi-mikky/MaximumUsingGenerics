// See https://aka.ms/new-console-template for more information
using MaxMethodUsingGenerics;

Console.WriteLine("Welcome to Maximum Method Using Generics!");
while(true)
{
    Console.WriteLine("PLease choose the option :\n1)Maximum of three Integers\n2)Maximum of three Float values\n3) Maximum of three Strings\n4)Maximum using Generic Method\n5)Max value using Generic Class and Method\n6) Using Params\n7)Max of multiple values using Generics");
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
        case 6:
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 1.4, 2.6, 6.8, 7.3 };
            string[] stringArray = {"Bananas","Apple","Animal" };
            int one = MaxOfMultipleInputs.ArrayOfIntegers(intArray);
            Console.WriteLine("Maximum of IntArray is :"+one);
            double one2 = MaxOfMultipleInputs.ArrayOfDouble(doubleArray);
            Console.WriteLine("Maximum of given double values is :"+one2);
            string one3 = MaxOfMultipleInputs.ArrayOfStrings(stringArray );
            Console.WriteLine("Maximum of given string values is :" + one3);
            break;
        case 7:
            int[] inputArray = { 1, 2, 3, 4, 5, 6 };
            int two = Uc5GenericParams<int>.MaxOfMultipleUsingGenerics(inputArray);
            Console.WriteLine("Max value of integers array using generics is :" + two);
            double[] doubleInputArray = { 1.1,2.1,3.1,5.1,9.3};
            double two2 = Uc5GenericParams<double>.MaxOfMultipleUsingGenerics(doubleInputArray);
            Console.WriteLine("Max value of double array using generics :"+two2);
            string[] stringInputArray = {"Apple","Banana","Grapes","GrapeFruit"};
            string two3 = Uc5GenericParams<string>.MaxOfMultipleUsingGenerics(stringInputArray);
            Console.WriteLine("Maximum of given string values is :" + two3);
            break;
        default:
            Console.WriteLine("Please choose the correct option :");
            break;

    }
}
