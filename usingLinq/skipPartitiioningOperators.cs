

using static usingLinq.dataSource;

namespace usingLinq
{
    internal class skipPartitiioningOperators
    {
        public static void usingSkip()
        {
            var skipSampleOne = Formula1.GetChampions()
                .Skip(5);

            foreach (var racer in skipSampleOne)
            {
                Console.WriteLine($"Country:{racer.Country}, Firstname: {racer.FirstName}");
            }
        }

        public static void usingSkipWhile()
        {
            var skipWhileSampleOne = Formula1.GetChampions()
                .SkipWhile(x => x.Country.Contains('a'));

            foreach (var racer in skipWhileSampleOne)
            {
                Console.WriteLine($"Country:{racer.Country}, Firstname: {racer.FirstName}");
            }
        }
    }

    internal class PartitiioningOperatorsWithRangeAndIndex
    {
        Index index = 1;
        Range range = 1..3;

        public static void usingSkip()
        {
            var skipSampleOne = Formula1.GetChampions()
                .Skip(5)
                .Take(2);
            /*var skipSampleTwo = Formula1.GetChampions()
                .3..2;*/

            foreach (var racer in skipSampleOne)
            {
                Console.WriteLine($"Country:{racer.Country}, Firstname: {racer.FirstName}");
            }
        }

    }
}
