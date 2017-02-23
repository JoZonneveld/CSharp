/**
 * Created by Joost on 23-2-2017.
 */
public class UserStory
{
    public int Hours;
    public String Description;


    public UserStory(int hours, String description)
    {
        this.Hours = hours;
        this.Description = description;
    }

    public String ToString()
    {
        String output = "";
        output += this.Hours;
        return output;
    }

}
