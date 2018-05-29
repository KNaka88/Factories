using System;

namespace AbstractFactory.Models
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This tea is nice but I'd prefer it with milk");
        }
    }
}