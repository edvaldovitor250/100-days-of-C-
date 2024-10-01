using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 5, 7, -1, 5 };
        int targetSum = 6;

        List<Tuple<int, int>> pairs = FindPairsWithSum(numbers, targetSum);

        Console.WriteLine("Pares com soma igual a " + targetSum + ":");
        foreach (var pair in pairs)
        {
            Console.WriteLine("(" + pair.Item1 + ", " + pair.Item2 + ")");
        }
    }

    static List<Tuple<int, int>> FindPairsWithSum(List<int> numbers, int targetSum)
    {
        Dictionary<int, int> numFrequency = new Dictionary<int, int>();
        List<Tuple<int, int>> result = new List<Tuple<int, int>>();

        foreach (int num in numbers)
        {
            int complement = targetSum - num;

            if (numFrequency.ContainsKey(complement) && numFrequency[complement] > 0)
            {
                result.Add(new Tuple<int, int>(complement, num));
                numFrequency[complement]--;
            }
            else
            {
                if (numFrequency.ContainsKey(num))
                    numFrequency[num]++;
                else
                    numFrequency.Add(num, 1);
            }
        }

        return result;
    }
}
