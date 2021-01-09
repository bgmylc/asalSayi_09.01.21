using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asalSayi_09._01._21
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 2; i < 10001; i++)
            {
                bool asalMisin = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        asalMisin = false;
                    }
                }
               
                if (asalMisin)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();

        }
    }
}
