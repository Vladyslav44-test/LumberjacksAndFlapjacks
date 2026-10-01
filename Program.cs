using System;
using System.Collections.Generic;
using System.Text;

namespace LumberjacksAndFlapjacks
{
    internal class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();
            string name = "";
            do
            {
                if (lumberjacks.Count == 0) Console.Write("First lumberjack's name: ");
                else Console.Write("Next lumberjack's name (blank to end): ");
                name = Console.ReadLine();
                if ((name != "") && (name != null))
                {
                    Lumberjack lumberjack = new Lumberjack() { Name = name };
                    Console.Write("Number of flapjacks: ");
                    if (int.TryParse(Console.ReadLine(), out int numberOfFlapjacks))
                    {
                        for (int i = 0; i < numberOfFlapjacks; i++)
                        {
                            lumberjack.TakeFlapjack((Flapjack)random.Next(4));
                        }
                        lumberjacks.Enqueue(lumberjack);
                    }
                }
                else name = "";
            } while (name != "");
            while (lumberjacks.Count > 0)
            {
                lumberjacks.Dequeue().EatFlapjacks();
            }
        }
    }
}
