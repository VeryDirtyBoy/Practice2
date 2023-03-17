using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] candidates = { 9, 3, 8, 5, 2, 1, 5, 7 };
            int target = 10;

            List<List<int>> result = ComboSum(candidates, target);

            Console.WriteLine("Комбинации чисел, сумма которых равна цели:");
            foreach (List<int> combination in result)
            {
                Console.WriteLine(string.Join(", ", combination));
            }
        }
        static List<List<int>> ComboSum(int[] candidates, int target)
        {
            List<List<int>> result = new List<List<int>>();
            
            Array.Sort(candidates);
            LocateCombo(candidates, target, new List<int>(), result, 0);
            return result;
        }
        static void LocateCombo(int[] candidates, int target, List<int> current, List<List<int>> result, int start)
        {
            if (target == 0)
            {
                result.Add(new List<int>(current));
                return;
            }
            for (int i = start; i < candidates.Length && candidates[i] <= target; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1])
                {
                    continue; 
                }
                
                current.Add(candidates[i]);
                LocateCombo(candidates, target - candidates[i], current, result, i + 1);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}