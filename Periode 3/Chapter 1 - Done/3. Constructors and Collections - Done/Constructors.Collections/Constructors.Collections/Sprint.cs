using System;
using System.Collections.Generic;
using System.Linq;

namespace Constructors.Collections
{
    public class Sprint
    {
        public List<UserStory> UserStory;
        public string Duration;
        public DateTime StartDate;

        public Sprint(List<UserStory> userstory, string duration, DateTime date)
        {
            this.UserStory = userstory;
            this.Duration = duration;
            this.StartDate = date;
        }

        public string retStartdate()
        {
            return this.StartDate.ToString("dd-MM-yy");
        }

        public void NewUserstory()
        {
            Console.WriteLine("Voer beschrijving in: ");
            string description = Console.ReadLine();
            Console.WriteLine("Voer het aantal uren in: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            UserStory.Add(new UserStory(hours, description));
        }

        public string HoursDone()
        {
            int output = 0;
            for (int i = 0; i < UserStory.Count; i++)
            {
                if (UserStory[i].Done == true)
                {
                    output += UserStory[i].Hours;
                }
            }

            return output + " hours are done";
        }

        public string hack()
        {
            for (int i = 0; i < UserStory.Count; i++)
            {
                UserStory[i].USDone();
            }
            return "Everything is done";
        }

        public string SprintDone()
        {
            int output = 0;
            for (int i = 0; i < UserStory.Count; i++)
            {
                if (UserStory[i].ToDo == true)
                {
                    output += UserStory[i].Hours;
                }
            }

            if(output == 0)
            {
                return "Yes the sprint is done";
            }
            else
            {
                return "No the sprint is not done";
            }
        }

        public string HoursRemain()
        {
            int output = 0;
            for (int i = 0; i < UserStory.Count; i++)
            {
                if (UserStory[i].ToDo == true)
                {
                    output += UserStory[i].Hours;
                }
            }

            return output + " hours must be realized.";
        }
    }
}