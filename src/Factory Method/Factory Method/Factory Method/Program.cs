using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    // A factory method can simply be a static method, which has a method for the object construction

    // Default Factory Method
    // It can also be an interface
    abstract public class AbsFoodFactory
    {
        // This method creates n IFood object:
        // You can also add some param to it, in order to do some logic.
        // In this case could also be a Enumerator, telling what's the meal.
        // Though it would be kind of an Abstract Factory
        public abstract IFood FactoryMethod();

        // You can and is part of the design to do some logic here, such as:
        // This is the main part of the Factory Method. 
        public string SatisfyHunger()
        {
            IFood food = FactoryMethod();
            return String.Format($"Hmmm..., I'm starving!\n{food.Eat()}\nI am not starve anymore!");
        }
    }

    public class HealthyFactory : AbsFoodFactory
    {
        public override IFood FactoryMethod()
        {
            return new Apple();
        }
    }

    public class DirtyFactory : AbsFoodFactory
    {
        public override IFood FactoryMethod()
        {
            return new Hamburguer();
        }
    }

    public class Apple : IFood
    {
        public string Eat()
        {
            return "Eating apple...";
        }
    }

    public class Hamburguer : IFood
    {
        public string Eat()
        {
            return "Eating Hamburguer...";
        }
    }

    public interface IFood
    {
        string Eat();
    }

    class Program
    {
        static void Main(string[] args)
        {
            var healthyFactory = new HealthyFactory();
            var dirtyFood = new DirtyFactory();
            // You can instantiate it here and get the food.
            Console.WriteLine(dirtyFood.SatisfyHunger());
            Console.WriteLine();
            Console.WriteLine(healthyFactory.SatisfyHunger());
            Console.WriteLine();

            // Or also get the food (product)
            Console.WriteLine(dirtyFood.FactoryMethod().Eat());
            Console.WriteLine(healthyFactory.FactoryMethod().Eat());

            Console.ReadLine();
        }
    }
}
