import java.util.ArrayList;
import java.util.List;

/**
 * Created by Joost on 23-2-2017.
 */
public class Main
{
    public static void main(String[] args)
    {
        List<UserStory> userstories = new ArrayList<UserStory>();
        userstories.add(new UserStory(5, "US1"));
        userstories.add(new UserStory(10, "US2"));
        userstories.add(new UserStory(15, "US3"));

        System.out.println(userstories.get(1).ToString());

        Sprint sprint = new Sprint(userstories);

        System.out.println(sprint.totalHours());

        sprint.NewUserStory();

        System.out.println(sprint.totalHours());

    }
}
