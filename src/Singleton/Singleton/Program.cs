using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonExample instance1 = SingletonExample.GetInstance();
            SingletonExample instance2 = SingletonExample.GetInstance();

            if (instance1 == instance2)
                Console.WriteLine("Instances are the same! Singleton works!");
            else
                Console.WriteLine("Instances are not the same! You have two different objects!");

            Console.WriteLine();

            instance1.Nome = "Name1";
            Console.WriteLine(instance1.Nome);
            Console.WriteLine(instance2.Nome);
            Console.WriteLine();

            instance2.Nome = "Name2";
            Console.WriteLine(instance1.Nome);
            Console.WriteLine(instance2.Nome);
            Console.WriteLine();

            Console.WriteLine("As you can see, anywhere from your project that has a SingletonExample reference, will share the same one.");
            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();
        }
    }
}
