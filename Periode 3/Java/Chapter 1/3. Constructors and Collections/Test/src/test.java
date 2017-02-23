/**
 * Created by Joost on 23-2-2017.
 */
import java.text.ParseException;
import java.util.Date;
import java.util.Calendar;
import java.text.SimpleDateFormat;


public class test
{
    public static void main(String[] args) {
        Date dNow = new Date();
        SimpleDateFormat ft = new SimpleDateFormat("yyyy.MM.dd");

        System.out.println("Current Date: " + ft.format(dNow));
        System.out.println(dNow);
    }
}
