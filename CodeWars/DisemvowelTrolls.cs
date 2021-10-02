using System.Linq;
using System.Text;
namespace CodeWars
{
    public class DisemvowelTrolls
    {
        public string Disemvowel(string str)
        {
            var vowelLetters = new[]
            {
                'a', 'e', 'i', 'o', 'u',
                'A', 'E', 'I', 'O', 'U',
            };

            var builder = new StringBuilder();
            foreach (var c in str.ToCharArray())
            {
                if (!vowelLetters.Contains(c))
                {
                    builder.Append(c);
                }
            }
            return builder.ToString();
        }
    }
}