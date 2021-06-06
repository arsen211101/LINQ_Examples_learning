using System;
using System.Collections.Generic;
using System.Linq;

namespace _004_LINQ
{
    public static class MySet
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T,bool> predicate)
        {
            Console.WriteLine("realizacia Where.");
            return System.Linq.Enumerable.Where(source, predicate);
        }

        public static IEnumerable<R> Select<T,R>(this IEnumerable<T> source,Func<T,R> selector)
        {
            Console.WriteLine("realizacia Select.");
            return System.Linq.Enumerable.Select(source, selector);
        }

        
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                if (list.Count > 0) return list[0];
            }
            else
            {
                using (IEnumerator<TSource> e = source.GetEnumerator())
                {
                    if (e.MoveNext()) return e.Current;
                }
            }
            return default(TSource);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            var query = from x in numbers
                        where x % 2 == 0
                        select x;

            var q = query.ToList();

            q.FirstOrDefault();

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
