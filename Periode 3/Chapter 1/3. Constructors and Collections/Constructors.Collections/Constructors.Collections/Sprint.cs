using System;
using System.Collections.Generic;
using System.Linq;

namespace Constructors.Collections
{
    public class Sprint
    {
        public List<UserStory> UserStory;

        public Sprint(List<UserStory> userstory)
        {
            this.UserStory = userstory;
        }

        public string ToString(int i)
        {
            return i.ToString(); ;
        }

        public void NewUserstory()
        {
            Console.WriteLine("Voer beschrijving in: ");
            string description = Console.ReadLine();
            Console.WriteLine("Voer het aantal uren in: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            UserStory.Add(new UserStory(hours, description));
        }

        public int totalHours()
        {
            int output = 0;
            for (int i = 0; i < UserStory.Count(); i++)
            {
                output += UserStory[i].Hours;
            }
            return output;
        }
    }
}