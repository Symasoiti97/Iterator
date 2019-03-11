using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    class Client
    {
        List<object> list = new List<object>();

        public Client()
        {
            list.AddRange(new List<object> {1,2,3,4,5});
        }

        public Iterator CreateIterator()
        {
            return new Iterator(list);
        }
    }
}
