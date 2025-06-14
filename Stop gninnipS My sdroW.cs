using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    string[] As = sentence.Split(" ");

    for (int x = 0; x < As.Length; x++) { 
        if (As[x].Length >= 5)
        {
            String rev = "";
            for (int x2 = As[x].Length -1; x2 >= 0; x2--)
            {
                rev = rev + As[x][x2];  
            }
            As[x] = rev;
        }
    }
    String sen = "";
    for (int x = 0; x < As.Length; x++)
    {
        sen = sen + As[x] + " ";
        if (x == As.Length - 1)
        {
            sen = sen.TrimEnd();
        }
    }
    return sen;
  }
}
