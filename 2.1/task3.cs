using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 5, 2, 8, 1, 2};
            bool identical = false;
            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = 0; j < nums.Count; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] == nums[j])
                        {
                            identical = true;
                        }
                    }
                }
            }
            Console.WriteLine(identical);
        } 
    }
}