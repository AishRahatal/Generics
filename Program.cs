using System;
using System.Collections.Generic;
namespace GenericPractice
{
    class Program
    {
        static T Maximum<T>(T x, T y, T z) where T : IComparable //Generic method for 3 vaiable-Refactor1
        {
            
            T max = x; // assume x is initially the largest
           
            if (y.CompareTo(max) > 0)
                max = y; // y is the largest 

            if (z.CompareTo(max) > 0)
                max = z; // z is the largest
            
            Console.WriteLine("Printing value inside Generic method Maximum  value :  " + max);// UC5-printing value using generic method
            return max; // returns the largest object

        }
        //end method maximum


        static void Main(string[] args)
        {
            
            
            Console.WriteLine("\n Generic Program ");
            Console.WriteLine("\n Using  method:");
            Console.WriteLine("------------UC1-------------------");
            Console.WriteLine("\n Find largest of three integer in order:");
          
            Console.WriteLine("Numbers in decrease order :");
            maxint.MaximumInt(99, 34, 65);
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-----------UC2--------------------");
            Console.WriteLine("\n Find largest of three fractions in order:");
          
            Console.WriteLine("Numbers in decrease order :");
            Maxdouble.MaximumDouble(9.6, 0.4, 2.5);
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-------------UC3------------------");

            Console.WriteLine("\n Find largest of three string in order:");
          
            Console.WriteLine("Strings in decrease order :");
            MaxString.MaxStrings("Apple", "Peach", "Lemon");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("----------Refactor 1---------------------");
            Console.WriteLine("\n Using generic method:");

            Console.WriteLine("--------------------------------");

            Console.WriteLine("\n numbers to compare:");

            Console.WriteLine("Maximum of  :33 ,22 , 45");
            var a = Maximum(33,22,45);
            Console.WriteLine("Maximum value :  " + a);
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" fraction number to compare:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Maximum of  :3.3 ,2.2 , 0.5");
            var b = Maximum(3.3, 2.2, 0.5);
            Console.WriteLine("Maximum value :  "+b);
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" words or alphabet to compare:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Maximum of  : M, A , o");
            var c = Maximum("M","A","o");
            Console.WriteLine("Maximum value :  " + c);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Maximum of  : Cat, Dog , Bird");
            var d = Maximum("Cat", "Dog", "Bird");
            Console.WriteLine("Maximum value :  " + d);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("-------------UC4------------------");
            //Taking more than 3 numbers-UC4 and Refactor2 using generic class to find maximum
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMax<int> generic = new GenericMax<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMax<double> genericDouble = new GenericMax<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "Apple", "Banana", "Peach", "Sweet Lemon", "Watermelon" };
            GenericMax<string> genericString = new GenericMax<string>(stringArray);
            genericString.PrintMaxValue();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------UC5-------------------");
            generic.PrintMaxValue();
            genericDouble.PrintMaxValue();
            genericString.PrintMaxValue();


        }







    }
    }
