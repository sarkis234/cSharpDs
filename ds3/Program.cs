using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds3
{
    public class Money
    {
        private int num;
        private int fraction;

        public Money(int num, int fraction)
        {
            this.num = num;
            if (fraction >=100) 
            {
                this.num += fraction / 100;
                this.fraction = fraction %= 100;
            }
            else this.fraction = fraction;
        }
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public int Fraction 
        {
            get { return fraction; }
            set
            {
                if (value >= 100)
                {
                    num += value / 100;
                    this.fraction = value %= 100;
                }
                else this.fraction = value;
            }
        }
        public void print()
        {
            Console.WriteLine($"{num}.{fraction}");
        }
    }
    public class Product {
        private string name;
        private string category;
        private Money price;

        public Product(string name, string category, Money price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Category
        {
            get { return category; }
            set { Category = value; }
        }
        public Money Price
        {
            get { return price; }
            set
            {
                price.Num = value.Num;
                price.Fraction = value.Fraction;
            }
        }
        public static Product operator -(Product prod1, double price)
        {
            string priceStr = Convert.ToString(price);
            Console.WriteLine(price);
            string[] priceElems = priceStr.Split(',');
            int a = Convert.ToInt32(priceElems[0]);
            int b = Convert.ToInt32(priceElems[1]);
            if ((prod1.price.Fraction - b) < 0)
            {
                a++;
                prod1.price.Fraction -= (b - 100);
            }
            else prod1.price.Fraction -= b;
            prod1.price.Num -= a;

            return prod1;
        }
        public void print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Category: {category}");
            Console.Write($"Price: ");
            price.print();
        }
    }
    abstract class Device
    {
        public void Sound() { }
        public void Show() { }
        public void Desc() { }
    }

    class Teapot : Device
    {
        public void Sound()
        {
            Console.WriteLine("Sound of teapot");
        }
        public void Show()
        {
            Console.WriteLine("Teapot");
        }
        public void Desc()
        {
            Console.WriteLine("Description of teapot");
        }
    }
    class Microwave : Device
    {
        public void Sound()
        {
            Console.WriteLine("Sound of microwave");
        }
        public void Show()
        {
            Console.WriteLine("Microwave");
        }
        public void Desc()
        {
            Console.WriteLine("Description of microwave");
        }
    }
    class Car : Device
    {
        public void Sound()
        {
            Console.WriteLine("Sound of car");
        }
        public void Show()
        {
            Console.WriteLine("Car");
        }
        public void Desc()
        {
            Console.WriteLine("Description of car");
        }
    }
    class Steamboat : Device
    {
        public void Sound()
        {
            Console.WriteLine("Sound of steamboat");
        }
        public void Show()
        {
            Console.WriteLine("Steamboat");
        }
        public void Desc()
        {
            Console.WriteLine("Description of steamboat");
        }
    }
    abstract class Instrument
    {
        public void Sound() { }
        public void Show() { }
        public void Desc() { }
        public void History() { }
    }
    class Violin : Instrument
    {
        public void Sound()
        {
            Console.WriteLine("Sound of violin");
        }
        public void Show()
        {
            Console.WriteLine("Violin");
        }
        public void Desc()
        {
            Console.WriteLine("Description of violin");
        }
        public void History()
        {
            Console.WriteLine("History of creation violin");
        }
    }
    class Trombone : Instrument
    {
        public void Sound()
        {
            Console.WriteLine("Sound of trombone");
        }
        public void Show()
        {
            Console.WriteLine("Trombone");
        }
        public void Desc()
        {
            Console.WriteLine("Description of trombone");
        }
        public void History()
        {
            Console.WriteLine("History of creation trombone");
        }
    }
    class Ukulele : Instrument
    {
        public void Sound()
        {
            Console.WriteLine("Sound of ukulele");
        }
        public void Show()
        {
            Console.WriteLine("Ukulele");
        }
        public void Desc()
        {
            Console.WriteLine("Description of ukulele");
        }
        public void History()
        {
            Console.WriteLine("History of creation ukulele");
        }
    }
    class Cello : Instrument
    {
        public void Sound()
        {
            Console.WriteLine("Sound of cello");
        }
        public void Show()
        {
            Console.WriteLine("Cello");
        }
        public void Desc()
        {
            Console.WriteLine("Description of cello");
        }
        public void History()
        {
            Console.WriteLine("History of creation cello");
        }
    }
    abstract class Worker 
    {
        public void print() { }
    }
    class President : Worker
    {
        public void print()
        {
            Console.WriteLine("Information about president");
        }
    }
    class Security : Worker
    {
        public void print()
        {
            Console.WriteLine("Information about security");
        }
    }
    class Manager : Worker
    {
        public void print()
        {
            Console.WriteLine("Information about manager");
        }
    }
    class Engineer : Worker
    {
        public void print()
        {
            Console.WriteLine("Information about engineer");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            //Money price = new Money(5, 18);
            //Product p1 = new Product("Test", "test2", price);
            //p1.print();
            //p1 -= 1.97;
            //p1.print();

            // 2
            //Teapot a = new Teapot();
            //a.Sound();
            //Car b = new Car();
            //b.Sound();

            // 3
            //Ukulele a = new Ukulele();
            //a.Sound();
            //Violin b = new Violin();
            //b.Sound();

            // 4
            President a = new President();
            a.print();
            Security b = new Security();
            b.print();
        }
    }
}
