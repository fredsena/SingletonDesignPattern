using System;
using System.IO;

namespace SingletonDesignPattern.Singleton
{
    class FileLogger
    {
        private static FileLogger _instance;
        private static System.IO.StreamWriter TextFile = new System.IO.StreamWriter(Directory.GetCurrentDirectory() + "\\Log.txt", true);
        private static object lockThis = new object();
        
        private FileLogger() { }
        public static FileLogger Instance
        {
            get
            {
                lock (lockThis) { 
                    Console.WriteLine("Singleton invoked.");
                    if (_instance == null)
                    {
                        _instance = new FileLogger();
                        Console.WriteLine("Singleton Initialized.");
                    }
                    return _instance;
                }
            }
        }

        public void WriteToFile(string text)
        {
            Console.WriteLine("Writing to File...");
            TextFile.WriteLine(text);
        }

        public void CloseFile()
        {
            TextFile.Close();
            TextFile.Dispose();
        }
    
    }
}
