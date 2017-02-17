using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Sprint
    {
        private string[][] UserStory;
        
        public Sprint(string[][] userstory)
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
            string hours = Console.ReadLine();

            string[][] NewList = { new string[]{hours, description} };
            this.UserStory = (string[][]) UserStory.Concat(NewList);

        }

        public int totalHours()
        {
            int count = this.UserStory.Count();
            int output = 0;
            for (int i = 0; i < count; i++)
            {
                try
                {
                    int j = Int32.Parse(UserStory[i][0]);
                    output += j;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return output;
        }
    }
}
