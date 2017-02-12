using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class IntArrayOpperations
    {
        private int[] List;

        public IntArrayOpperations(int[] list)
        {
            this.List = list;
        }

        public int Sum()
        {
            int output = 0;
            for (int i = 0; i < List.Count(); i++)
            {
                output = output + List[i];
            }
            //return List.Sum(); // <-- veel makkelijker
            return output;
        }

        public string Product()
        {
            string output = "";
            for (int i = 0; i < List.Count(); i++)
            {
                output = output + List[i];
            }
            
            return output;
        }
    }
}
