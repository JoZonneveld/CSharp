using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserStory> userstory = new List<UserStory>
            {
                new UserStory(15, "US1"),
                new UserStory(65, "US2"),
                new UserStory(40, "US3"),
                new UserStory(40, "US4"),
            };

            DateTime date = new DateTime(2017, 02, 25);

            var sprint = new Sprint(userstory, "1 Week", date);
            Console.WriteLine(sprint.HoursDone());
            Console.WriteLine(sprint.HoursRemain());
            Console.WriteLine(sprint.SprintDone());
            Console.WriteLine(sprint.hack());
            Console.WriteLine(sprint.SprintDone());
            //Console.WriteLine(sprint.totalHours());

            //sprint.NewUserstory();

            //Console.WriteLine(sprint.totalHours());

            Console.ReadKey();
        }
    }
}
