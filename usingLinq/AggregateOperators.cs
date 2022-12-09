using static usingLinq.dataSource;

namespace usingLinq
{
    internal class AggregateOperators
    {
        static List<int> numbers = new() { 1, 2, 3, 20, 5, 7, 8, 10};
        static List<int> numbersTwo  = new() { 1, 2, 3, 20, 5, 7, 8, 10 };
        static List<int> numbersThree = new() { 1, 2, 3, 20, 5, 7};

        public static void usingAggregates()
        {
            var query = numbers.Aggregate((x,y) => x + y);
            var queryTwo = numbers.Aggregate((x,y) => x > y ? x : y);
           

            //MaxBy is for custom object while Max is for c# inbuilt objects
            var queryThree =numbers.MaxBy(x => x % 2) ;

            var racer = Formula1.GetChampions()[0];

            var queryFour = Formula1.GetChampions().MaxBy(x => x.Wins);

            var queryFive = Formula1.GetChampions()
                .Aggregate(
                racer,
                (x,y) => x.Wins > y.Wins ? x : y, 
                x => new
                {
                    Name = x.FirstName,
                    Country = x.Country
                });
            Console.WriteLine($"{queryFive.Name} \n{queryFive.Country}");

            
        } 
        public static void usingQuantification()
        {

            //Any (Quantification)
            //it checks if at least one element satisfies your condition. If so, it returns true.
            //Instead of using list.count > 0, use list.Any for checking if a list is empty
            //Any is a predicate...it takes in a value and returns a bool


            //SequenceEquals
            //compare that 2 sequences (digits) is equal.
            var equal = numbers.SequenceEqual(numbersTwo);
            Console.WriteLine(equal);

        }
    }
}
