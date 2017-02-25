using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Interval
    {
        public int Begin;
        public int End;

        public Interval(int Begin, int End)
        {
            this.Begin = Begin;
            this.End = End;
        }

        public int Sum()
        {
            int output = 0;
            for (int i = this.Begin; i <= this.End; i++)
            {
                output = output + i;
            }
            return output;
        }

        public string Product()
        {
            string output = "";
            for (int i = (this.Begin+1); i < this.End; i++)
            {
                output = output + i;
            }
            return output;
        }
    }
}
