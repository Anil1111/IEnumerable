using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        IEnumerable<int> result = from value in Enumerable.Range(0, 4)
                                  select value;

        // Loop.
        foreach (int value in result)
        {
            Console.WriteLine(value);
        }

        // We can use extension methods on IEnumerable<int>
        double average = result.Average();

        // Extension methods can convert IEnumerable<int>
        List<int> list = result.ToList();
        foreach (int value in list)
        {
            Console.WriteLine(value);
        }

        int[] array = result.ToArray();
        foreach (int value in array)
        {
            Console.WriteLine(value);
        }

    }
}
