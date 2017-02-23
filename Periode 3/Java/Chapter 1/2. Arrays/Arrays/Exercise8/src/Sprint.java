import java.util.List;
import java.util.Scanner;

/**
 * Created by Joost on 23-2-2017.
 */
public class Sprint
{
    public List<UserStory> Userstory;

    public Sprint(List<UserStory> userstory)
    {
        this.Userstory = userstory;
    }

    public int totalHours()
    {
        int output = 0;

        for(int i = 0; i < Userstory.size(); i++)
        {
            output += this.Userstory.get(i).Hours;
        }
        return output;
    }

    public String ToString()
    {
        return "";
    }

    public void NewUserStory()
    {
        Scanner in = new Scanner(System.in);

        System.out.println("Enter description");
        String d = in.nextLine();
        System.out.println("Enter hours");
        int h = in.nextInt();

        this.Userstory.add(new UserStory(h, d));
    }

}
