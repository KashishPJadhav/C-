using System;

namespace session_one
{
    internal class Program
    {
        class M1
        {
            public void method1()
            {
                int a = 10;
                int b = 10;
                Console.WriteLine("Sum: " + (a + b));
                Console.WriteLine("Sub: " + (a - b));
                Console.WriteLine("Multiply: " + (a * b));
                Console.WriteLine("Divide: " + (a / b));

                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Age: " + age);
            }

            public static void method2()
            {
                int i;
                Console.WriteLine("Enter a number");
                i = Convert.ToInt32(Console.ReadLine());
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }

            public static void method3()
            {
                char alpha = 'a';
                switch (alpha)
                {
                    case 'a': Console.WriteLine("a"); break;
                    case 'e': Console.WriteLine("e"); break;
                    case 'i': Console.WriteLine("i"); break;
                    case 'o': Console.WriteLine("o"); break;
                    case 'u': Console.WriteLine("u"); break;
                    default: Console.WriteLine("Invalid"); break;
                }
            }

            public static void method4()
            {
                int a;
                Console.WriteLine("Enter a number ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0) Console.WriteLine("Number is Positive ");
                else if (a < 0) Console.WriteLine("Number is Negative");
                else Console.WriteLine("Number is Zero");
            }
        }

        static void Main(string[] args)
        {
            M1 obj1 = new M1();
            obj1.method1();

            M1.method2();
            M1.method3();
            M1.method4();
        }
    }
}