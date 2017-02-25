namespace Constructors.Collections
{
    public class UserStory
    {
        public int Hours;
        public string Description;
        public bool ToDo;
        public bool InProgress;
        public bool Done;

        public UserStory(int hours, string description)
        {
            this.Hours = hours;
            this.Description = description;
            this.ToDo = true;
            this.InProgress = false;
            this.Done = false;
        }

        public void USInProgress()
        {
            this.InProgress = true;
        }

        public void USDone()
        {
            this.ToDo = false;
            this.InProgress = false;
            this.Done = true;
        }

        public void USNotDone()
        {
            this.ToDo = true;
            this.InProgress = false;
            this.Done = false;
        }
    }
}