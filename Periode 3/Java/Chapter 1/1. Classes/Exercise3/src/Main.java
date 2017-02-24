/**
 * Created by Joost on 23-2-2017.
 */
public class Main
{
    public static int sums(int x, int y)
    {
        int output = 0;
        for(int i = x; i <= y; i++)
        {
            output += i;
        }
        return output;
    }

    public static void main(String[] args)
    {
        System.out.println(sums(1,5));
    }
}
