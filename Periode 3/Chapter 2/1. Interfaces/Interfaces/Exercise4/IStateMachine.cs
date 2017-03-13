using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise4
{
    interface IStateMachine
    {
        void update(float x);
        bool done { get; set; }
    }
}
