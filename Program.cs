using System;

namespace SimulatedMemoryLeak
{
    class Program
    {
        static Foo[] array;
        static int i;

        static void Main(string[] args)
        {
            array = new Foo[2048];
            i = 0;

            Console.WriteLine("Press Enter to allocate large memory.");
            Console.WriteLine("Press Ctrl + C to exit");

            while (true)
            {
                Console.ReadLine();
                array[i] = new Foo();
                i++;
                Console.WriteLine("10M bytes are allocated.");
            }
        }

        public class Foo
        {
            private byte[] m_buffer = new byte[10240000]; //Allocate 10M bytes
        }
    }
}
