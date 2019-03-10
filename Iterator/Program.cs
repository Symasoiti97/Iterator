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
            WriteClient wClient = new WriteClient(client);
            wClient.PrintClient();

            Console.ReadKey();
        }
    }
}
