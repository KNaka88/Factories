using System;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Grind some beans, boil water, pour {amount} ml enjoy");
            return new Coffee();
        }
    }
}