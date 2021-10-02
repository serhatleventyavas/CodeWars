using System.Linq;
namespace CodeWars
{
    public class SumOfTwoLowestPositiveIntegers
    {
        public int SumTwoSmallestNumbers(int[] numbers)
        {
            var orderedNumbers = numbers.OrderBy(p => p).ToArray();
            return orderedNumbers[0] + orderedNumbers[1];
        }
    }
}