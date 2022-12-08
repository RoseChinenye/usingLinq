using System;

namespace usingLinq;

public class Program
{
    public static void Main(string[] args)
    {
        /*practice p = new practice();
        p.getPractice();*/
        LambdaExpressionSyntax();
        
    }
   public static void LambdaExpressionSyntax()
    {
        // Make a list of integers.
        List<int> list = new List<int>();
        list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

       

        var ListOfEvenNumbers = list.FindAll(x => (x % 2) == 0);
        foreach(var s in ListOfEvenNumbers)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}