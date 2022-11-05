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
            Console.WriteLine("");
            Console.WriteLine("-------------");
            Console.WriteLine(" Enter array elements");
            Console.WriteLine("-------------");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i-1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        } 
        public void Algorithm()
        {
            char ch;
            do
            {
                Console.WriteLine("\nEnter element want you to search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                int lowerbund = 0;
                int upperbund = n - 1;

                int mid = (lowerbund + upperbund) / 2;
                int ctr = 1;

                while ((item !=arr[mid]) && (lowerbund <= upperbund))
                {
                    if (item !=arr[mid])
                        lowerbund = mid + 1;
                    else
                        upperbund = mid - 1;
                    mid = (lowerbund + upperbund) / 2;
                    ctr++;
                }
                if (item ==arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                Console.WriteLine("\nNumber of comparasion : " + ctr);

                Console.WriteLine("\nCountinue search (y/n):");
                ch = char.Parse(Console.ReadLine());

            } while ((ch == 'y') || (ch == 'Y'));     
        }
    }
}