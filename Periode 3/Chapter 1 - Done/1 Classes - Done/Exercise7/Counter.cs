using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Counter
    {
        public int cnt = 1;

        public void Tick()
        {
            cnt = cnt + 1;
        }

        public void Reset()
        {
            cnt = 1;
        }

        public override string ToString()
        {
            return "Count is " + cnt;
        }
    }
}
