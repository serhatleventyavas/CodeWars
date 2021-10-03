using System.Linq;
namespace CodeWars
{
    public class FindTheSmallestIntegerInTheArray
    {
        public int FindSmallestInt(int[] args)
        {
            return args.OrderBy(p => p).ToList()[0];
        }
    }
}