using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil et : ");
            int num = Convert.ToInt32(Console.ReadLine());
            string eded = Convert.ToString(num);

            for (int i = eded.Length - 1; i >= 0; i--)
            {
                Console.Write(eded[i] + " ");
            }
            Console.ReadLine();


        }
    }
}
