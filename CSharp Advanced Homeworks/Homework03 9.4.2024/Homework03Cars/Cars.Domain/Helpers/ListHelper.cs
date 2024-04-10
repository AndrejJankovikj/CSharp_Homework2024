using Cars.Domain.Entities;
using System.Collections;

namespace Cars.Domain.Helpers
{
    public static class ListHelper
    {
        public static void PrintSimple<T>(this List<T> list)
        {
            Console.WriteLine("Printing List...");
            Console.WriteLine("------------------------------");
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
        }
        public static void PrintCollectionItems(IEnumerable collection)
        {
          
            foreach (var item in collection)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
