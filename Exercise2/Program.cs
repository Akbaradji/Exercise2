using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class program
    {
        int[] arr = new int[41];
        int n;
        int i;

        public void input()
        {
            while(true)
            {
                Console.WriteLine("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <=41))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 41 elements.\n");
            }
        }
    }
}