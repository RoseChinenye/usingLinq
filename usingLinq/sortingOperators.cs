using static usingLinq.dataSource;
using static usingLinq.dataSource.Formula1;

namespace usingLinq
{
    public class sortingOperators
    {
        public static void SortingViaQuerySyntax()
        {
            var racers = from racer in GetChampions()
                         orderby racer.Country, racer.FirstName, racer.LastName
                         select racer;
            var descendingRacers = from racer in GetChampions()
                                   orderby racer.Country descending, racer.FirstName descending
                                   select racer;
            foreach(var racer in descendingRacers)
            {
                Console.WriteLine($"Country:{racer.Country}, Firstname: {racer.FirstName}");
            }

        }

        public static void sortingViaMethodSyntax()
        {
            var racer = GetChampions()
                .OrderBy(x => x.Country)
                .ThenBy(x => x.FirstName);
        }
    }
}
