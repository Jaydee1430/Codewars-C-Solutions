using System.Collections;

public class Kata
{
    public static int DigitalRoot(long n)
    {
        int y = 10;
        while (y >= 10)
        {
            string snum = n.ToString();
            ArrayList num = new ArrayList();
            for (int x = 0; x < snum.Length; x++)
            {
               num.Add(int.Parse(snum[x].ToString()));
            }
            y = 0;
            for (int x = 0; x< snum.Length; x++)
            {
                y += (int)num[x];
            }
            if (y>=10){
                n = y;
            }
        }
        return y;
    }
}
