using System;
using System.Collections.Generic;

namespace Sorting
{
    public class TwoSum
    {
        public List<int> FindTwoSum(List<int> numbers, int target)
        {
            List<Int32> result = new List<Int32>();
            Dictionary<int, int> resultDict = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int requiredNumber = target - currentNumber;
                if (resultDict.ContainsKey(requiredNumber))
                {
                    result.Add(resultDict[requiredNumber]);
                    result.Add(i);
                    return result;
                }
                resultDict[currentNumber] = i;
            }
            result.Add(-1);
            result.Add(-1);

            return result;
        }
    }
}
