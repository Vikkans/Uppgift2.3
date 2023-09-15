using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur många dagar ska ni köra bilen?");
            string x = Console.ReadLine();
            double z = double.Parse(x);

            Console.WriteLine("Hur många kilometer ska ni köra bilen?");
            string l = Console.ReadLine();
            double y = double.Parse(l);

            double sum = 300 + y + 500*z -500;

            Console.WriteLine("Detta kommer att kosta dig " + sum + " kr");
            Console.ReadKey();
       



        }



    }



}