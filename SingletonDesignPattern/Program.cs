using System;
using SingletonDesignPattern.Singleton;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileLogger = FileLogger.Instance;

            fileLogger.WriteToFile("Singleton is awesome for Performance.");
            fileLogger.WriteToFile("More from Singleton..");

            //Test for to see if another instance will be created. 
            //Singleton Initialized should be printed twice.
            var fileLogger1 = FileLogger.Instance;

            fileLogger1.WriteToFile("Using another instance...");
            fileLogger1.WriteToFile("More from another instance.");

            fileLogger.CloseFile();
            fileLogger1.CloseFile();

            Console.ReadKey();
        }
    }

        
}
