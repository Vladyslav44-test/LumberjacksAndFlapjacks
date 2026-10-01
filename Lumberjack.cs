using System;
using System.Collections.Generic;
using System.Text;

namespace LumberjacksAndFlapjacks
{
    internal class Lumberjack
    {
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();

        public string Name { get; private set; }

        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push(flapjack);
        }
        public void EatFlapjacks()
        {
            Console.WriteLine(Name + "is eating flapjacks");
            for (int i = 0; i < flapjackStack.Count; i++)
            {
                Console.WriteLine($"{Name} ate a {flapjackStack.Pop()} flapjack");
            }
        }
    }
}
