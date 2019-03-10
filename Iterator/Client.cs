using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    class Client
    {
        List<double> list = new List<double>();

        public Client()
        {
            list.AddRange(new List<double> {1,2,3,4,5});
        }

        public IteratorDouble CreateIterator()
        {
            return new IteratorDouble(list);
        }
    }
}
