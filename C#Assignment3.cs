using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethod
{
    internal class Program
    {
        static void Method(int[] integer)
        {
            int sum = 0;
            for (int i = 0; i < integer.Length; i++)
                sum += integer[i];

            Console.WriteLine("Sum of all integers {0}", sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Values");
            int[] integer = new int[5];
            for (int i = 0; i < integer.Length; i++)
                integer[i] = Convert.ToInt32(Console.ReadLine());
            Method(integer);
        }
    }
}
