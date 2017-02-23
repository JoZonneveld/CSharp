/**
 * Created by Joost on 23-2-2017.
 */
public class Interval
{
    public int Begin;
    public int Eind;

    public Interval(int begin, int eind)
    {
        this.Begin = begin;
        this.Eind = eind;
    }

    public int Sum()
    {
        int output = 0;
        for(int i = Begin; i <= Eind; i++)
        {
            output += i;
        }
        return output;
    }

    public String Product()
    {
        String output = "";
        for(int i = (Begin+1); i < Eind; i++)
        {
            output += i;
        }
        return output;
    }
}
