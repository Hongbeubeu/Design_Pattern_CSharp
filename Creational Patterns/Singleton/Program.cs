﻿using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Singleton s1 = Singleton.instance;
            Singleton s2 = Singleton.instance;

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
