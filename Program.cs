using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "T-Mobile", "Dooo do dooo");
            Nokia elevenHundred = new Nokia("1100", 60, "Metro PCS", "Ringgg ring ringgg");

            s8.DisplayINfo();
            System.Console.WriteLine(s8.Ring());
            System.Console.WriteLine(s8.Unlock());
            System.Console.WriteLine("");

           elevenHundred.DisplayINfo();
           System.Console.WriteLine(elevenHundred.Ring());
           System.Console.WriteLine(elevenHundred.Unlock());
           System.Console.WriteLine("");
        }
    }
}
