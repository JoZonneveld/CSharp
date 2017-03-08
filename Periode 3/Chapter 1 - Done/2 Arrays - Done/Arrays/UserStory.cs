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
        public int Hours;
        public string Description;

        public UserStory(int hours, string description)
        {
            this.Hours = hours;
            this.Description = description;
        }

        public string ToString()
        {
            return "Uren: " + Hours + " Description: " + Description;
        }
    }
}
