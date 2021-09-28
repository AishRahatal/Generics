using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPractice
{
// finding maximum with all test cases
    class Maxdouble
    {

        public static void MaximumDouble(double a, double b, double c)
        {
            if ((a >= b) && (a >= c))
            {
                if (b >= c)
                {
                    Console.Write("\n Descending order :{0}  {1} {2}   ", a, b, c);

                }
                else
                {
                    Console.Write("\n Descending order :{0}  {1} {2}   ", a, c, b);

                }
            }
            else if ((b >= a) && (b >= c))
            {
                if (a >= c)
                {
                    Console.Write("\n Descending order :{0}  {1} {2}   ", b, a, c);

                }
                else
                {
                    Console.Write("\n Descending order :{0}  {1} {2}   ", b, c, a);
                    
                }
            }
            else if ((c >= a) && (c >= b))
            {
                if (a >= b)
                {
                    Console.Write("\n Descending order :{0}  {1} {2}   ", c, a, b);

                }
                else
                {
                    Console.Write("\n Descending order :{0}  {1} {2}   ", c, b, a);

                }
            }

        }
    }
    }
