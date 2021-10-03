using System.Collections.Generic;
namespace CodeWars
{
    public class CountingDuplicates
    {
        public int DuplicateCount(string str)
        {
            var duplicateCount = 0;
            var hashMap = new Dictionary<string, int>();
            
            foreach (var c in str.ToCharArray())
            {
                var cAsString = c.ToString().ToLower();
                if (hashMap.ContainsKey(cAsString))
                {
                    var count = hashMap[cAsString];
                    hashMap[cAsString] = count + 1;
                }
                else
                {
                    hashMap.Add(cAsString, 1);
                }
            }
            
            foreach (var hashMapKey in hashMap.Keys)
            {
                var count = hashMap[hashMapKey];
                if (count > 1)
                {
                    duplicateCount += 1;
                }
            }
            
            return duplicateCount;
        }
    }
}