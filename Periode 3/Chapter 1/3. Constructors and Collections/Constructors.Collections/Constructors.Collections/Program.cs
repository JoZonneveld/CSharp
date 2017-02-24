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

            var sprint = new Sprint(userstory);

            Console.WriteLine(sprint.totalHours());

            sprint.NewUserstory();

            Console.WriteLine(sprint.totalHours());

            Console.ReadKey();
        }
    }
}
