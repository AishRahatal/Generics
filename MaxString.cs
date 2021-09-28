using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPractice
{
// finding maximum with all test cases
    class MaxString
    {
        public static void MaxStrings(string a, string b, string c)
        {
             if (a.CompareTo(b) > 0 && (a.CompareTo(c)>0))
            {
                if (b.CompareTo(c)>0)
                {
                    Console.Write("\n Descending order :{0}  {1} {2}   ", a, b, c);

                }
                else
                {
                    Console.Write("\n Descending order :{0}  {1} {2}   ", a, c, b);

                }
            }
            else if ((b.CompareTo(a)>0) && (b.CompareTo(c)>0))
            {
                if (a.CompareTo(c)>0)
                {
                    Console.Write("\n Descending order :{0}  {1} {2}   ", b, a, c);

                }
                else
                {
                    Console.Write("\n Descending order :{0}  {1} {2}   ", b, c, a);
                   
                }
            }
            else if ((c.CompareTo(a)>0) && (c.CompareTo(b)>0))
            {
                if (a.CompareTo(b)>0)
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
