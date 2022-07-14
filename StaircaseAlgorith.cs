using System;


class Staircase
{
    public static void Main(string[] args)
    {
        var t = string.Empty;
        var n = Console.ReadLine();
        int c;
        Int32.TryParse(n, out c);
        if (c > 0 && c <= 100)
        {
            for (int i = 1; i <= c; i++)
            {
                t += "#";
                t = t.PadLeft(c);
                Console.WriteLine(t);
                t = t.Replace(" ", "");
            }
            return;
        }
    }
}