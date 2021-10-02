using System.Linq;
namespace CodeWars
{
    public class NumberOfOccurrences
    {

        public int FindOccurrencesCount(int element, int[] samples)
        {

            return samples.Count(sample => sample == element);
        }
    }
}