using System;
using System.Threading;

namespace RobloxMultipleInstance
{
    internal static class Program
    {
        public static Mutex Mutex1;
        public static void Main(string[] args)
        {
            Mutex1 = new Mutex(true, "ROBLOX_singletonEvent");

            ConsoleColor colorOriginal = Console.ForegroundColor;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Roblox Multiple Instance Enable");
            
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}