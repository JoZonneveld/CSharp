/**
 * Created by Joost on 22-2-2017.
 */

import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(System.in);

        System.out.println("Voer een diameter in");
        int num = in.nextInt();

        int eenderde = num/3;
        int tweederde = num/3*2;
        int helft = num/2;

        String output = "";
        for(int x = 0; x < num; x++)
        {
            output = "";
            for(int y = 0; y < num; y++)
            {
                if(x == 0 || x == (num -1) || y == 0 || y == (num -1)) // gezicht
                {
                    output += "*";
                }
                else if((y == eenderde || y == tweederde) && x == eenderde) // ogen
                {
                    output += "0";
                }
                else if(y == helft && x == helft) // neus
                {
                    output += "7";
                }
                else if(x == tweederde && y >= eenderde && y <= tweederde) //mond
                {
                    if(y > eenderde && y < tweederde)
                    {
                        output += "_";
                    }
                    else if(y == eenderde)
                    {
                        output += "\\";
                    }
                    else if(y == tweederde)
                    {
                        output += "/";
                    }

                }
                else {
                    output += " ";
                }
            }
            System.out.println(output);
        }

    }
}
