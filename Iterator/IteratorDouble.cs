using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    class IteratorDouble : IIterator<double>
    {
        List<double> list;
        int position = 0;

        public IteratorDouble(List<double> list)
        {
            this.list = list;
        }

        public bool HasNext()
        {
            if (position >= list.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double Next()
        {
            double obj = list[position];
            position++;
            return obj;
        }

        public bool HasPrev()
        {
            if (position <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double Prev()
        {
            position--;
            double obj = list[position];
            return obj;
        }
    }
}
