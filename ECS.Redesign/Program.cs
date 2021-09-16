using System;

namespace ECS.Redesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing ECS.Legacy");
            var tempsensor = new TempSensor();
            var heater = new Heater();
            // Make an ECS with a threshold of 23
            var control = new ECS(23,tempsensor,heater);

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine($"Running regulation number {i}");

                control.Regulate();
            }
        }
    }
}
