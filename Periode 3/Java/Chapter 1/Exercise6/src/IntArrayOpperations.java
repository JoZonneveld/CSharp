/**
 * Created by Joost on 23-2-2017.
 */
public class IntArrayOpperations
{
    int[] I;

    public IntArrayOpperations(int[] i)
    {
        this.I = i;
    }

    public int Sum()
    {
        int output = 0;
        for(int i = 0; i < this.I.length; i++)
        {
            output += this.I[i];
        }
        return output;
    }

    public String Product()
    {
        String output = "";
        for(int i = 1; i < (this.I.length - 1); i++)
        {
            output += this.I[i];
        }
        return output;
    }
}
