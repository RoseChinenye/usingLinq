using static usingLinq.dataSource;
using static usingLinq.dataSource.Formula1;
using static usingLinq.sortingOperators;
using static usingLinq.TakePartitiioningOperators;
using static usingLinq.skipPartitiioningOperators;
using static usingLinq.AggregateOperators;

namespace usingLinq;

public class Program
{
    public static void Main(string[] args)
    {
        //usingAggregates();
        usingQuantification();

        /*
        //practicing Extension methods
        int i = 10;

        bool result = i.IsGreaterThan(100);

        Console.WriteLine(result);
        Console.WriteLine();*/
    }
   
}