using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = -1.4;
            double tKon = 4.5;
            double h = 0.3;
            double y = 0;
            while (t <= tKon)
            {
                if (t <= 3)
                    y = Math.Sin(4 * t);
                else
                    y = Math.Cos(t - 3 / t);
                Console.WriteLine("t = {0:0.##}\ty= {1:0.###}", t, y);
                t += h;
            }
            Console.ReadLine();



        }
            
    }
}
