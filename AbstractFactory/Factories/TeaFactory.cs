using System;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Put in a tea bag, boil water, pour {amount}  ml, add lemon, emjoy!");
            return new Tea();
        }
    }
}