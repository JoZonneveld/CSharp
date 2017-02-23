/**
 * Created by Joost on 23-2-2017.
 */
public class Main
{
    public static void main(String[] args)
    {
        int[] i = {1,2,3,4,5};

        IntArrayOpperations x = new IntArrayOpperations(i);

        System.out.println(x.Sum());
        System.out.println(x.Product());


    }
}
