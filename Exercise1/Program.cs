using System;
using System.Threading;

namespace Exercise1
{
    class Program
    {
        static void Main( string[] args )
        {
            FuelTank fuel = new FuelTank(500);
            Console.Out.WriteLine("Fuel: " + fuel.GetAmount());
            fuel.Fill(6);
            Console.Out.WriteLine("Fuel: " + fuel.GetAmount());
            fuel.Fill(23);
            Console.Out.WriteLine("Fuel: " + fuel.GetAmount());
            Console.Out.WriteLine("Level: " + Math.Round(fuel.GetLevel(), 2) + "%");


            Engine eng = new Engine();
            Console.Out.WriteLine("State: " + eng.GetState());
            Console.Out.WriteLine();

            eng.Start();
            Console.Out.WriteLine("State: " + eng.GetState());
            Thread.Sleep(2000);
            Console.Out.WriteLine();

            eng.Stop();
            Console.Out.WriteLine("State: " + eng.GetState());

            Console.ReadKey();
        }
    }
}
