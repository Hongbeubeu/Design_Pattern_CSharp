using System;

namespace Singleton
{
    // The singleton class defines the instance method that serves as 
    // an alternative to constructor and lets clients access the name instance of
    // this class over and over
    public class Singleton
    {
        // The Singleton's constructor should always be private to prevent
        // direct constructioncalls with the 'new' operator

        private Singleton() { }

        // The Singleton's instance is stored in a static field. There are
        // multiple ways to initialize this field, and of them have various pros 
        // and cons. Inthis example we'll show the simplest of these ways,
        // which, however, doesn't work really well in multithreaded program.

        private static Singleton _instance;

        // This is the static method that controls the access to the singleton
        // instance. On the first run, it creats a singleton object and places
        // it into the static field. On subsequent runs, it returns the client
        // existing object stored in the static field.
        public static Singleton instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();
                return _instance;
            }
        }

        // Finally, any singleton should define some business logic, which can 
        // be executed on its instance.
        public static void SoSomething()
        {
            // ..
        }

    }
}