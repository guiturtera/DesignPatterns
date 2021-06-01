using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /* Singleton design pattern
     *  - They are used when you only want to have one SINGLE instance of your class.
     *  - They are similar to the Static class, though they have the ability to inherit and implement interfaces.
     *  - PROBLEM - Violater SRP (Single Responsability Principle) [Not fatal! This pattern is widely used].
     */

    // The class can be accessed by the server.
    public class SingletonExample
    {
        #region First class role -> Singleton

        // YOU CAN NOT INSTANTIATE IT OUTSIDE THE CLASS
        private SingletonExample() { }

        // It will keep an instance of the SingletonExample class.
        // Note that the reference is private
        private static SingletonExample singleton;

        // To instantiate it, or call the already instantiated object, you will cal the method
        public static SingletonExample GetInstance() 
        {
            if (singleton == null)
                singleton = new SingletonExample();

            return singleton;
        }

        #endregion

        #region Second class role -> That's why it violates SRP.
        public string Nome { get; set; } 
        #endregion
    }
}
