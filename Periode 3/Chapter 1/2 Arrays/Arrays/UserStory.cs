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
        private object Hours;
        private object Description;

        public UserStory(object hours, object description)
        {
            this.Hours = hours;
            this.Description = description;
        }

        public object RetHours()
        {
            return Hours;
        }

        public string RetDescription()
        {
            return this.Description.ToString();
        }
    }
}
