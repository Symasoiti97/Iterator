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
            bool flag = true;
            IteratorDouble iterator = client.CreateIterator();

            Console.WriteLine("1.Next 2.Prev");

            while (flag)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.D1: GetNext(); break;
                    case ConsoleKey.D2: GetPrev(); break;
                    default: flag = false; break;
                }
            }

            void GetNext()
            {
                if (iterator.HasNext())
                {
                    num = iterator.Next();
                    Console.Write(num + " ");
                }
            }

            void GetPrev()
            {
                if (iterator.HasPrev())
                {
                    num = iterator.Prev();
                    Console.Write(num + " ");
                }
            }
        }
    }
}
