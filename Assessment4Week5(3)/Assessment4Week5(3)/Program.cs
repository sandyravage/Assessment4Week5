using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4Week5_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };

            int result = GetSum(array1);

            Console.WriteLine(result);
        }

        private static int GetSum(int[] array1)
        {
            int sum = 0;
            foreach (int item in array1)
            {
                sum += item;
            }
            return sum;
        }
    }
}
