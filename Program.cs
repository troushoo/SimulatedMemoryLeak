using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatedMemoryLeak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte[]> mybytelist = new List<byte[]>();
            int i = 0;

            Console.WriteLine("Press Enter to allocate large memory.");
            Console.WriteLine("Press Ctrl + C to exit");

            while (true)
            {
                Console.Read();
                mybytelist.Add(new byte[10240000]); //Allocate 10M bytes

                for (int j = 0; j < mybytelist[i].Length; j++)
                {
                    (mybytelist[i])[j] = 255; //assign data
                }
                i++;
            }
            
            

        }
    }
}
