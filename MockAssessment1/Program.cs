using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace MockAssessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(istheSame(3, 3));
            Console.WriteLine(istheSame(3, 5));

            Console.WriteLine(Subtract(5, 3));

            Console.WriteLine(FindBuildingType(3));
            Console.WriteLine(FindBuildingType(4));
            Console.WriteLine(FindBuildingType(11));
            Console.WriteLine(FindBuildingType(50));
        }

        static bool istheSame(int num1, int num2)
        {
            return num1 == num2;
        }
        static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        static string FindBuildingType(int num)
        {
            if(num <= 3)
            {
                return "This is a house";
            }
            else if(num >= 4 && num <= 10)
            {
                return "This is an office building";
            }
            else if(num >= 11 && num <= 49)
            {
                return "This is a skyscraper";
            }
            else
            {
                return "This is SUPER skyscraper";
            }
        }
    }
}
