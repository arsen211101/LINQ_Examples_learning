using System;
using System.Linq;

namespace _009_LINQ
{
    public class Result
    {
        public Result(int input, int output)
        {
            Input = input;
            Output = output;
        }
        public int Input { get; set; }
        public int Output { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };

            var query = from x in numbers
                        select new Result(x, x * 2);

            numbers[0] = 777;

            foreach (var item in query)
            {
                Console.WriteLine("Input={0}, \t Output={1}",item.Input,item.Output);
            }
        }
    }
}
