using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            {
                var result = geometricMean(16.80, 12.40);
                Console.WriteLine(result);
            }

            // 2
            {
                var result = ACplusBC(1.40, -5.50, 0.60);
                Console.WriteLine(result);
            }
            
            // 3
            {
                var result = twoPointDistance(-6.20, 5.20, 2.10, 9.80);
                Console.WriteLine(result);
            }

            // 4
            {
                var result = reverseTwoDigit(41);
                Console.WriteLine(result);
            }

            // 5
            {
                var result = secondsToMinutes(10985);
                Console.WriteLine(result);
            }

            // 6
            {
                var result = yearDayToWeekDay(202);
                Console.WriteLine(result);
            }
        }

        // tasks:

        // 1
        static double geometricMean(double a, double b)
        {
            return Math.Sqrt(a * b);
        }

        //2
        static double ACplusBC(double a, double b, double c)
        {
            var ac = Math.Abs(a - c);
            var bc = Math.Abs(b - c);
            return ac + bc;
        }

        //3
        static double twoPointDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        //4
        static int reverseTwoDigit(int number) 
        {
            var firstDigit = number / 10;
            var lastDigit = number % 10;
            var reversedNumber = lastDigit * 10 + firstDigit;
            
            return reversedNumber;
        }

        //5
        static int secondsToMinutes(int n)
        {
            return n / 60;
        }

        static int yearDayToWeekDay(int day)
        {
            return day % 7;
        }
    }
}
