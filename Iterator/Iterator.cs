using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    class Iterator : IIterator
    {
        List<object> list;
        int position = 0;

        public Iterator(List<object> list)
        {
            this.list = list;
        }

        public object First()
        {
            position = 0;

            return list[position];
        }

        public object Next()
        {
            if (position == list.Count - 1)
            {
                position = 0;
            }
            else
            {
                position++;
            }

            return list[position];
        }

        public object Prev()
        {
            if (position == 0)
            {
                position = list.Count - 1;
            }
            else
            {
                position--;
            }

            return list[position];
        }
    }
}
