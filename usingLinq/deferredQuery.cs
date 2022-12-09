
namespace usingLinq
{
    internal class deferredQuery
    {
        static List<int> numbers = new()
        {
                1, 2, 3, 5, 6
            };
        public static void TestDeferredQueries()
        {
            //converting a query to store in a list
            var query = (from number in numbers
                         where number % 2 == 0
                         select number).ToList();

            
            
            //converting a query to store in a dictionary
            /*Dictionary<string, int> query = (from number in numbers
                         where number % 2 == 0
                         select number).ToDictionary(x => x);*/

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            numbers.Add(4);
            numbers.Add(12);
            numbers.Add(7);
            numbers.Add(6);

            Console.WriteLine("\nSecond Query\n");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
