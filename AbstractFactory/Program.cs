using System;
using System.Collections.Generic;
using AbstractFactory.Factories;
using static System.Console;
namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 100);
            drink.Consume();

        }
    }
}
