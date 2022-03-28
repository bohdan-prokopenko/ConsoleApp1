namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // целые числа
            int sergeyMoney = 100;

            double gekaMoney = 0.000100;

            float arturMoney = 0.000500f;

            decimal bohdanMoney = 15.00m;

            string hello = "Hello";

            string world = " world";

            string helloWorld = hello + world + $" I'm superman and I have {sergeyMoney - bohdanMoney} baks!)";

            char f = 'f';

            ushort a = 65535;

         // long     (ushort)   int
            long b = (a + a) * 100000; // 222098112 - why?
            long c = (a + a);          // 131070     
            
            Console.WriteLine(sergeyMoney);
            Console.WriteLine(gekaMoney);
            Console.WriteLine(arturMoney);
            Console.WriteLine(bohdanMoney);
            Console.WriteLine(helloWorld);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
