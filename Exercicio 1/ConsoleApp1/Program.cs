using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 20);
            }


            Console.WriteLine(Comparar(array, 2));
            
            
        }

        



        public static int Comparar(int [] a, int b)
        {
            int c = 0;
            for (int i = 0; i < a.Length; i++)

            {
                if( a[i] == b)
                {
                    c++;
                }
                
            }
            return c;
        }
    }
}
