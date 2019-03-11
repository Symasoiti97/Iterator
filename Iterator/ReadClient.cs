using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    class ReadClient
    {
        Client client;

        public ReadClient(Client client)
        {
            this.client = client;
        }

        public void PrintClient()
        {
            double num;
            bool flag = true;

            Iterator iterator = client.CreateIterator();

            Console.WriteLine("1.Next 2.Prev 3.First");

            while (flag)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.D1: GetNext(); break;
                    case ConsoleKey.D2: GetPrev(); break;
                    case ConsoleKey.D3: GetFirst(); break;
                    default: flag = false; break;
                }
            }

            void GetNext()
            {
                num = Convert.ToDouble(iterator.Next());
                Console.Write(num + " ");
            }

            void GetPrev()
            {
                num = Convert.ToDouble(iterator.Prev());
                Console.Write(num + " ");
            }

            void GetFirst()
            {
                num = Convert.ToDouble(iterator.First());
                Console.Write(num + " ");
            }
        }
    }
}
