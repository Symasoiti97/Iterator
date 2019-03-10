using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    class WriteClient
    {
        Client client;

        public WriteClient(Client client)
        {
            this.client = client;
        }

        public void PrintClient()
        {
            double num;
            IteratorDouble iterator = client.CreateIterator();

            while (iterator.HasNext())
            {
                num = iterator.Next();
                Console.Write(num + " ");
            }

            Console.WriteLine();

            while (iterator.HasPrev())
            {
                num = iterator.Prev();
                Console.Write(num + " ");
            }
        }
    }
}
