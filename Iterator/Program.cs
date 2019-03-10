using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            IteratorDouble iterator = client.CreateIterator();

            while (iterator.HasNext())
            {
                double num = iterator.Next();
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
