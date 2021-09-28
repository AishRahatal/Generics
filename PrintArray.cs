using System;
using System.Collections.Generic;


namespace PrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Array of Different Data Types: ");
            Console.WriteLine("-----------------------------------------------");

            
            int[] intarr = { 1, 2, 3, 4, 5 };

            double[] doublearr = { 0.1, 2.3,6.8, 3.0, 7.4, 5.5 };
            char[] chararr = { 'a', 'b', 'c', 'd' };
            decimal[] decimalarr = { 3, 89, 0 };
            Console.WriteLine("Printing  different types of elements of an array  with one method:");
            Program.toPrint(intarr);
            Program.toPrint(doublearr);
            Program.toPrint(chararr);
            Program.toPrint(decimalarr);
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("Printing Integer elements of an array :");
            Program.PrintInteger(intarr);
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("Printing double elements of an array :");
            Program.PrintDouble(doublearr);
             Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("Printing Character elements of an array :");
            Program.PrintChar(chararr);
                         Console.WriteLine("\n-----------------------------------------------");

        }
                   
        public static void toPrint<T>(T[] inputArray)
        {

            foreach (var element in inputArray)
            {
                Console.Write("{0}  ",element) ;
            }
            
        }

        public static void PrintInteger(int[] intarr)
        {
            foreach (double element in intarr)
            {
                Console.Write("{0} ", element);
            }
           
        }

        public static void PrintDouble(double[] doublearr)
        {
            foreach (double element in doublearr)
            {
                Console.Write("{0}  ", element);
            }
        }

        public static void PrintChar(char[] chararr)
        {
            foreach (char element in chararr)
            {
                Console.Write("{0} ", element);
            }
        }


    }

    
}
