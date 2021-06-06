using System;
using System.Linq;

namespace _010_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };

            var query = from x in numbers
                        select new { Input = x, Output = x * 2 };

            foreach (var item in query)
            {
                Console.WriteLine("input={0}, \t Output={1}",item.Input,item.Output);
            }

        }
    }
}
