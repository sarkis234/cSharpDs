using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //if (n1 < 1 || n1 > 100)
            //{
            //    Console.WriteLine("Error: num must be from 1 to 100!");
            //}
            //else if (n1 % 3 == 0 && n1 % 5 == 0)
            //{
            //    Console.WriteLine("Fizz Buzz");
            //}
            //else if (n1 % 3 == 0)
            //{
            //    Console.WriteLine("Fizz");
            //}
            //else if (n1 % 5 == 0)
            //{
            //    Console.WriteLine("Buzz");
            //}
            //else Console.WriteLine(n1);

            // #2
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int persent = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(n2 * persent / 100);

            // #3
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int n3 = a * 1000 + b * 100 + c * 10 + d;
            //Console.WriteLine(n3);

            // #4
            //int n5 = Convert.ToInt32(Console.ReadLine());
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //string n = n5.ToString();
            //string n2 = "";
            //for (int i = 1; i < n.Length + 1; i++)
            //{
            //    if (i == a)
            //    {
            //        n2 += n[b - 1];
            //    }
            //    else if (i == b)
            //    {
            //        n2 += n[a - 1];
            //    }
            //    else
            //    {
            //        n2 += n[i - 1];
            //    }
            //}
            //n5 = Convert.ToInt32(n2);
            //Console.WriteLine(n5);

            // #5
            //string date = Console.ReadLine();
            //string[] date2 = date.Split('.');
            //foreach(string s in date2)
            //{
            //    Console.WriteLine(s);
            //}
            //int day = Convert.ToInt32(date2[0]);
            //int month = Convert.ToInt32(date2[1]);
            //int year = Convert.ToInt32(date2[2]);
            //bool isVes = false;
            //if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            //{
            //    isVes = true;
            //}
            //int monthCode = 0;
            //switch(month)
            //{
            //    case 1:
            //        monthCode = 1;
            //        if (isVes) monthCode--;
            //        Console.Write("Winter ");
            //        break;
            //    case 2:
            //        monthCode = 4;
            //        if (isVes) monthCode--;
            //        Console.Write("Winter ");
            //        break;
            //    case 3:
            //        monthCode = 4;
            //        Console.Write("Spring ");
            //        break;
            //    case 4:
            //        monthCode = 0;
            //        Console.Write("Spring ");
            //        break;
            //    case 5:
            //        monthCode = 2;
            //        Console.Write("Spring ");
            //        break;
            //    case 6:
            //        monthCode = 5;
            //        Console.Write("Summer ");
            //        break;
            //    case 7:
            //        monthCode = 0;
            //        Console.Write("Summer ");
            //        break;
            //    case 8:
            //        monthCode = 3;
            //        Console.Write("Summer ");
            //        break;
            //    case 9:
            //        monthCode = 6;
            //        Console.Write("Autumn ");
            //        break;
            //    case 10:
            //        monthCode = 1;
            //        Console.Write("Autumn ");
            //        break;
            //    case 11:
            //        monthCode = 4;
            //        Console.Write("Autumn ");
            //        break;
            //    case 12:
            //        monthCode = 6;
            //        Console.Write("Winter ");
            //        break;
            //    default:
            //        Console.WriteLine("Error");
            //        break;
            //}
            //int centCode = 6 - ((year / 100) % 4) * 2;
            //int yearCode = (centCode + (year % 100) + ((year % 100) / 4)) % 7;
            //int weekDay = (day + monthCode + yearCode) % 7;
            //switch (weekDay)
            //{
            //    case 0:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 1:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;
            //}

            // #6
            //int n6 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("1 - Celsiy to Farengeit, 2 - Farengeit to Celsiy");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a == 1) {
            //    n6 = n6 * 9 / 5 + 32;
            //}
            //else if (a == 2)
            //{
            //    n6 = (n6 - 32) * 5 / 9;
            //}
            //Console.WriteLine(n6);

            // #7
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if ( a > b)
            {
                int c = a;
                a = b;
                b = c;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
