using System;
using System.Collections;
using System.Linq;

namespace _006_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);

            var query=from int n in numbers select n * 2;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
