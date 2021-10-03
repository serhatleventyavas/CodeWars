using System.Collections.Generic;
using System.Linq;
namespace CodeWars
{
    public class ListFiltering
    {
        public IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {

            return listOfItems.OfType<int>().ToList();
        }
    }
}