using static usingLinq.dataSource;

namespace usingLinq
{
    internal class TakePartitiioningOperators
    {
        //Take, TakeWhile, TakeLast
        public static void usingTake()
        {
            var takeSampleOne = Formula1.GetChampions();
            foreach (var racer in takeSampleOne)
            {
                Console.WriteLine($"Country:{racer.Country}, Firstname: {racer.FirstName}");
            }
        }

        public static void usingTakeWhile()
        {
            var takeWhileSampleOne = Formula1.GetChampions()
                .TakeWhile(x => x.FirstName.Contains('o'));

            foreach (var racer in takeWhileSampleOne)
            {
                Console.WriteLine($"Country:{racer.Country}, Firstname: {racer.FirstName}");
            }
        }

        public static void usingTakeLast()
        {
            var takeLastSampleOne = Formula1.GetChampions()
                .TakeLast(5);

            foreach (var racer in takeLastSampleOne)
            {
                Console.WriteLine($"Country:{racer.Country}, Firstname: {racer.FirstName}");
            }
        }


    }
}
