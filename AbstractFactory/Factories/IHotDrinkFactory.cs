using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}