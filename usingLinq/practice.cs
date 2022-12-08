using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingLinq
{
    public class practice
    {
        public static void LambdaExpressionSyntax()
        {

            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            var ListOfEvenNumbers = list.FindAll(x => (x % 2) == 0);
            foreach (var s in ListOfEvenNumbers)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
