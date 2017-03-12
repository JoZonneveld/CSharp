using System;
using System.Threading;

namespace Exercise4
{

    public class Timer
    {
        float initial_time;

        public Timer(float time)
        {
            this.time = time;
            initial_time = time;
        }

        float time;
        bool busy = true;

        public bool Busy
        {
            get { return busy; }

            set { busy = value; }
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
        }
        public void Update(float x)
        {
            new Timer(x);
            this.Time -= 1;
            if (this.Time == 0)
            {
                this.done = true;
            }
        }
    }
}