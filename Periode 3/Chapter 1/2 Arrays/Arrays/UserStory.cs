using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class UserStory
    {
        private int Hours;
        private string Description;

        public UserStory(int hours, string description)
        {
            this.Hours = hours;
            this.Description = description;
        }

        public int RetHours()
        {
            return Hours;
        }

        public string RetDescription()
        {
            return this.Description.ToString();
        }
    }
}
