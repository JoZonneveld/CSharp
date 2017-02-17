using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var UserStory1 = new UserStory(15, "US1");
            var UserStory2 = new UserStory(6, "US2");
            var UserStory3 = new UserStory(40, "US3");

            object[][] userstory =
            {
                new object[] {15, "US1"},
                new object[] {65, "US2"},
                new object[] {40, "US3"},
                new object[] {40, "US4"}
            };
            string[] Userstorylist = {};
            for (int i = 0; i < userstory.Count(); i++)
            {
                Console.WriteLine(userstory[i][0]);
                //Userstorylist[i] = new UserStory(userstory[i][0], userstory[i][1]);
                Userstorylist[i] = "tet";
            }

            Console.WriteLine(Userstorylist[0]);
            /*
            string[][] list =
            {
                new string[] { UserStory1.RetHours(), UserStory1.RetDescription()},
                new string[] { UserStory2.RetHours(), UserStory2.RetDescription()},
                new string[] { UserStory3.RetHours(), UserStory3.RetDescription()}
            };
            //var Sprint1 = new Sprint();

            var sprint = new Sprint(list);

            sprint.NewUserstory();

            Console.WriteLine(sprint.totalHours());
            */
            Console.ReadKey();
        }
    }
}
