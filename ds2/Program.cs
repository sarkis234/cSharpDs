using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds2
{
    internal class Program
    {
        static void task1 (int size, char sym)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(sym);
                }
                Console.WriteLine();
            }
        }
        static bool task2 (int num)
        {
            string numStr = num.ToString();
            string numStrRev = new string(numStr.Reverse().ToArray());
            if (numStr == numStrRev) return true;
            else return false;
        }
        static int[] task3(int[] numbers, int[] clear)
        {
            List<int> newNumbers = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < clear.Length; j++)
                {
                    if (numbers[i] == clear[j])
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    newNumbers.Add(numbers[i]);
                }
            }
            return newNumbers.ToArray();
        }
        public class WebSite
        {
            private string name;
            private string url;
            private string descr;
            private int ip;

            public WebSite(string name, string url, string descr, int ip)
            {
                this.name = name;
                this.url = url;
                this.descr = descr;
                this.ip = ip;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }
            public string Url
            {
                get { return this.url; }
                set { this.url = value; }
            }
            public string Descr
            {
                get { return this.descr; }
                set { this.descr = value; }
            }
            public int Ip
            { 
                get { return this.ip; }
                set { this.ip = value; } 
            }
            public void print()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Url: {url}");
                Console.WriteLine($"Descr: {descr}");
                Console.WriteLine($"Ip: {ip}");
            }
        }
        public class Journal
        {
            private string name;
            private int phone;
            private string mail;
            private string descr;
            private int year;

            public Journal(string name, int phone, string descr, string mail, int year)
            {
                this.name = name;
                this.phone = phone;
                this.descr = descr;
                this.mail = mail;
                this.year = year;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }
            public int Phone
            {
                get { return this.phone; }
                set { this.phone = value; }
            }
            public string Descr
            {
                get { return this.descr; }
                set { this.descr = value; }
            }
            public string Mail
            {
                get { return this.mail; }
                set { this.mail = value; }
            }
            public int Year
            {
                get { return this.year; }
                set { this.year = value; }
            }
            public void print()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Release year: {year}");
                Console.WriteLine($"Descr: {descr}");
                Console.WriteLine($"Contact mail: {mail}");
                Console.WriteLine($"Contact phone: {phone}");
            }
        }
        public class Shop
        {
            private string name;
            private int phone;
            private string mail;
            private string descr;
            private string adress;

            public Shop(string name, int phone, string descr, string mail, string adress)
            {
                this.name = name;
                this.phone = phone;
                this.descr = descr;
                this.mail = mail;
                this.adress = adress;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }
            public int Phone
            {
                get { return this.phone; }
                set { this.phone = value; }
            }
            public string Descr
            {
                get { return this.descr; }
                set { this.descr = value; }
            }
            public string Mail
            {
                get { return this.mail; }
                set { this.mail = value; }
            }
            public string Adress
            {
                get { return this.adress; }
                set { this.adress = value; }
            }
            public void print()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Adress: {adress}");
                Console.WriteLine($"Descr: {descr}");
                Console.WriteLine($"Contact mail: {mail}");
                Console.WriteLine($"Contact phone: {phone}");
            }
        }
        static void Main(string[] args)
        {
            task1(5, '*');
            Console.WriteLine(task2(12221));
            int[] numbers = { 1, 23, 76, 167, 10 };
            int[] clear = { 76, 167 };
            int[] nums = task3(numbers, clear);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            WebSite test1 = new WebSite("aded", "foeofeof", "efjfjeojfj", 120);
            test1.Name = "new site";
            test1.print();
            // ne proveryal zadanie 5 i 6, tam to zhe samoe chto i v 4
        }
    }
}
