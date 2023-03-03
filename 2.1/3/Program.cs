using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool function(int[] nums)
            {
                List<int> num = new List<int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (num.Contains(nums[i]))
                    {
                        return true;
                    }
                    else
                    {
                        num.Add(nums[i]);
                    }

                     
                }
                return false;
            }
             
            
            int[] nums = { 1, 2, 3, 4, 5 };

            bool fun = function(nums);
            Console.WriteLine(fun);

        }
        }
    }