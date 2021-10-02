using System.Linq;
namespace CodeWars
{
    public class SumOfAllTheMultiples3Or5
    {
        public int FindSum(int n)
        {
            // var sum = 0;
            //
            // for (var i = 1; i <= n; i++)
            // {
            //     if (i % 3 == 0)
            //     {
            //         sum += i;
            //     } else if (i % 5 == 0)
            //     {
            //         sum += i;
            //     }
            // }
            //
            // return sum;
            return Enumerable.Range(1, n).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
        }
    }
}