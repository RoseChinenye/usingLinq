
namespace usingLinq;

public static class intExtensions
{
    public static bool IsGreaterThan(this int i, int value)
    {
        return i > value;
    }
}

public class anonymousTypes
{
    public void getAnonymousTypes() 
    {
        /* var purchasedItem = new
         {
             books = "English",
             chapters = new {chapter1 = "pg1", chapter2 = "pg2", chapter3 = "pg3" }
         };*/

        string[] names = { "Bill", "Steve", "James", "Mohan" };

        var newList = from name in names
                      where name.Contains('a')
                      select name;
    }
}

    