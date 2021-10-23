using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 0, 0, 1, 1, 2 };

            Console.Write("[");
            foreach (int inp in input)
            {
                Console.Write($" {Convert.ToString(inp)}, ");
            }
            Console.WriteLine("]");


            int k = RemoveDuplicates(input);

            Array.Resize(ref input, k);

            //int[] expectedNums = input;

            Console.WriteLine(Convert.ToString(k));

            Console.Write("[");
            foreach (int inp in input)
            {
                Console.Write($" {Convert.ToString(inp)}, ");
            }
            Console.WriteLine("]");

            Console.Read();

           
            
            int RemoveDuplicates(int[] nums)
            {
                if (nums == null) return 0;             
                if (nums.Length == 0) return 0;

                int counter = 0;                                // счетчик кол-во перезаписей

                for (int i = 1; i < nums.Length; i++)
                {                                               // { 0, 0, 1, 1, 2 }
                    if (nums[counter] != nums[i])               // [0]!=[1] - пропуск
                    {                                           // [1]!=[2] - запись [2] в [1]  { 0, 1, 1, 1, 2 }
                        nums[counter++ + 1] = nums[i];          // ...
                    }                                           // [2]!=[4] - запись [4] в [2]  { 0, 1, 2, 1, 2 }
                }
                return counter + 1;                             
            }




            int RemoveDuplicates1(int[] nums)
            {
                if (nums == null) return 0;
                if (nums.Length == 0) return 0;

                int counter = 0;

                for (int j = 1; j < nums.Length - 1; j++)
                {
                    for (int i = 1; i < nums.Length - 1; i++)
                    {
                        if (nums[i] == nums[i - 1])
                        {
                            nums[i] = nums[i + 1];
                        }
                    }
                }

                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] == nums[i - 1])
                    {
                        counter += 1;
                    }
                }

                return nums.Length - counter;
            }


        }

    }

}

