using System;
using System.Threading;

namespace Exercise4
{
    class Timer
    {
        public Timer(float x)
        {
            
        }
    }

    public class Wait : IStateMachine
    {
        public bool done { get; set; }
        public int Time;

        public Wait(int time)
        {
            this.done = false;
            this.Time = time;
            this.update(this.Time);
        }

        public void update(float x)
        {
            if (x == 0)
            {
                this.done = true;
            }
            else
            {
                x -= 1;
                this.update(x);
                Console.WriteLine(x);
            }
        }
    }
}