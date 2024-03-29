using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GogiaBagut
{
    internal class Program
    {
        public static int Above(int[] arr, int num)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) 
           {
            sum+= arr[i];
                if (sum > num)
                {
                    return i;
                }

            }
            return -1;
        }

        
        static void Main(string[] args)
        {
        }
    }
}
