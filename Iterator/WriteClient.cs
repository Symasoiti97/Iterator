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
            IteratorDouble iterator = client.CreateIterator();
            while (iterator.HasNext())
            {
                double num = iterator.Next();
                Console.Write(num + " ");
            }
        }
    }
}
